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
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projectcore.FormControls.pages.issued
{
    public partial class ChooseBook : Form
    {
        private readonly IAllBookService _allBookService;
        private readonly IAuthorService _authorService;
        private readonly IPublisher _publisherSerivce;
        private readonly IBookService _bookService;
        private readonly IGenreService _genreService;

        public List<Book> books { get; set; }
        public ChooseBook(IAllBookService allBookService, IAuthorService authorService, IPublisher publisher, IBookService bookService, IGenreService genreService)
        {
            _allBookService = allBookService;
            _authorService = authorService;
            _publisherSerivce = publisher;
            _bookService = bookService;
            _genreService = genreService;
            this.StartPosition = FormStartPosition.CenterScreen;
            books = new List<Book>();
            InitializeComponent();
            initData();
            table();
            RenderRow(_allBookService.GetAllActive(null));
            
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
            list_book.ColumnCount = 5;
            list_book.Columns[0].Name = "Book id";
            list_book.Columns[1].Name = "Title";
            list_book.Columns[2].Name = "ISBN";
            list_book.Columns[3].Name = "Quantity";
            list_book.Columns[4].Name = "Issued";
            list_book.AllowUserToAddRows = false;

            DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
            dgvCmb.ValueType = typeof(bool);
            dgvCmb.Name = "Chk";
            dgvCmb.HeaderText = "Choose";
            list_book.Columns.Add(dgvCmb);


        }
        private void RenderRow(List<AllBook> allBooks)
        {
            list_book.Rows.Clear();

            foreach (AllBook book in allBooks)
            {
                int index = books.FindIndex(e=> e.id == book.id);
                list_book.Rows.Add(
                    book.id,
                    book.title,
                    book.isbn,
                    book.quantity,
                    book.count,
                    index == -1 ? false : true
                    );
            }
        }
        private void btn_isua_add_Click(object sender, EventArgs e)
        {
            if (books.Count <= 0)
            {
                MessageBox.Show("No data !!!");
                return;
            }
            this.DialogResult = DialogResult.OK;
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
            List<AllBook> allBooks = _allBookService.GetAllActive(query);
            RenderRow(allBooks);
        }

        private void list_book_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int column = e.ColumnIndex;
            int index = e.RowIndex;
            if (column == 5)
            {
                try
                {
                    int id = int.Parse(list_book.Rows[index].Cells[0].Value.ToString());
                    string name = list_book.Rows[index].Cells[1].Value.ToString();

                    int getIndex = books.FindIndex(e => e.id == id);
                    
                    if(getIndex >= 0)
                    {
                        books.RemoveAt(getIndex);
                    }
                    else
                    {
                        Book book = new Book() { id = id, title = name };
                        books.Add(book);
                    }
                    ShowCount();
                }
                catch( Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void ShowCount()
        {
            lable_selected.Text = books.Count.ToString();
        }
    }
}
