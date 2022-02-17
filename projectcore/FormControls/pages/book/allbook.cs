using projectcore.FormControls.pages.book;
using projectcore.models;
using projectcore.models.views;
using projectcore.Services;
using projectcore.Services.AllBookService;
using projectcore.Services.AuthorService;
using projectcore.Services.BookService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace projectcore.FormControls.pages
{
    public enum Status
    {
        ACTIVE = 0,
        DELETE = 1,
        DEACTIVE = 2,
    };
    public partial class allbook : Form
    {
        private readonly DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
        private readonly DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
        private readonly IAllBookService _allBookService;
        private readonly IAuthorService _authorService;
        private readonly IPublisher _publisherSerivce;
        private readonly IBookService _bookService;
        private readonly IGenreService _genreService;
        public allbook(IAllBookService allBookService, IAuthorService authorService, IPublisher publisher, IBookService bookService, IGenreService genreService)
        {
            InitializeComponent();
            _allBookService = allBookService;
            _authorService = authorService;
            _publisherSerivce = publisher;
            _bookService = bookService;
            _genreService = genreService;

            initData();
            table();
            RenderRow(_allBookService.GetAllBooks(null));
        }
        public void initData()
        {
            // author
            all_book_author.ValueMember = "id";
            all_book_author.DisplayMember = "name";

            List<Authors> authors = _authorService.GetActive();
            authors.Insert(0, new Authors { id = -1, name = "-Select-" }); ;
            all_book_author.DataSource = authors;
            all_book_author.DropDownStyle = ComboBoxStyle.DropDownList;

            all_book_author.SelectedIndex = 0;


            // Pub
            all_book_pub.ValueMember = "id";
            all_book_pub.DisplayMember = "name";
            List<Publishers> publishers = _publisherSerivce.GetActive();
            publishers.Insert(0, new Publishers { id = -1, name = "-Select-" }); ;

            all_book_pub.DataSource = publishers;
            all_book_pub.DropDownStyle = ComboBoxStyle.DropDownList;

            all_book_pub.SelectedIndex = 0;


        }
       
        private void table()
        {
            list_book.RowHeadersVisible = false;
            list_book.ColumnCount = 6;
            list_book.Columns[0].Name = "Book id";
            list_book.Columns[1].Name = "Title";
            list_book.Columns[2].Name = "ISBN";
            list_book.Columns[3].Name = "Quantity";
            list_book.Columns[4].Name = "Issued";
            list_book.Columns[5].Name = "Status";

            list_book.AllowUserToAddRows = false;
            list_book.Columns.Add(btnDelete);
            list_book.Columns.Add(btnEdit);
            addButton();


        }
        private void RenderRow(List<AllBook> allBooks)
        {
            list_book.Rows.Clear();
            
            foreach (AllBook book in allBooks)
            {
                string stt = "";
                switch (book.status)
                {
                    case (int)Status.ACTIVE:
                        stt = "Active";
                        break;
                    case (int)Status.DEACTIVE:
                        stt = "De Active";

                        break;
                }
                list_book.Rows.Add(
                    book.id,
                    book.title,
                    book.isbn,
                    book.quantity,
                    book.count,
                    stt
                    );
            }
        }
        private void addButton()
        {
            btnDelete.HeaderText = @"Delete";
            btnDelete.Name = "button";
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;

            /// btn edit;
            /// 
            btnEdit.HeaderText = @"Edit";
            btnEdit.Name = "button";
            btnEdit.Text = "Edit";
            btnEdit.UseColumnTextForButtonValue = true;
        }

        private void book_btn_search_Click(object sender, EventArgs e)
        {
            List<List<string>> query = new List<List<string>>();
            string title = all_book_input.Texts;
            if (!String.IsNullOrEmpty(title))
                query.Add(new List<string> { "title", "like", title });
            if ((int)all_book_author.SelectedIndex != 0)
            {
                Object select = all_book_author.SelectedValue;

                query.Add(new List<string> { "author", "=", select.ToString() });
            }
            if ((int)all_book_pub.SelectedIndex != 0)
            {
                Object pub = all_book_pub.SelectedValue;

                query.Add(new List<string> { "author", "=", pub.ToString() });
            }
            List<AllBook> allBooks = _allBookService.GetAllBooks(query);
            RenderRow(allBooks);

        }

        private void list_book_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (e.ColumnIndex == 6)
            {
                try
                {
                    int id = int.Parse(list_book.Rows[index].Cells[0].Value.ToString());

                    Book book = _bookService.GetById(id);
                    DialogResult dialogResult = MessageBox.Show("Do you want to delete " + book.title + " ?", "Notify Message", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        book.status = 1;
                        bool up =  _bookService.Update(book.id, book);
                        RenderRow(_allBookService.GetAllBooks(null));
                        
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
            }
            if (e.ColumnIndex == 7)
            {
                try
                {
                    int id = int.Parse(list_book.Rows[index].Cells[0].Value.ToString());
                    Book book = _bookService.GetById(id);
                    using (EditBook uu = new EditBook(book, _authorService.GetActive(), _genreService.GetActive(), _publisherSerivce.GetActive()))
                    {
                        //uu.UpdateEventHandler += F2_UpdateEventHandler1;
                        if (uu.ShowDialog() == DialogResult.Yes)
                        {
                            Book UpdateBook = uu.book;
                            bool up =  _bookService.Update(book.id, UpdateBook);
                            if (up)
                            {
                                RenderRow(_allBookService.GetAllBooks(null));

                                MessageBox.Show("Update Success !!", "Notify");
                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                   
                }

            }

        }

        private void list_book_VisibleChanged(object sender, EventArgs e)
        {
            RenderRow(_allBookService.GetAllBooks(null));
        }

        private void allbook_VisibleChanged(object sender, EventArgs e)
        {
            RenderRow(_allBookService.GetAllBooks(null));
        }
    }
}
