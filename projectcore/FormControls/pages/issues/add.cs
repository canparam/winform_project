using projectcore.models;
using projectcore.Services;
using projectcore.Services.AllBookService;
using projectcore.Services.AuthorService;
using projectcore.Services.BookService;
using projectcore.Services.IssueService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projectcore.FormControls.pages.issued
{
    public partial class add : Form
    {
        private readonly IAllBookService _allBookService;
        private readonly IAuthorService _authorService;
        private readonly IPublisher _publisherSerivce;
        private readonly IBookService _bookService;
        private readonly IGenreService _genreService;
        private readonly IUserService _userService;
        private readonly IissueService _issueService;
        private readonly DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
        private List<Book> _books;
        private Users Users;
        public add(IissueService iissueService, IUserService userService,IAllBookService allBookService, IAuthorService authorService, IPublisher publisher, IBookService bookService, IGenreService genreService)
        {
            _userService = userService;
            _allBookService = allBookService;
            _authorService = authorService;
            _publisherSerivce = publisher;
            _bookService = bookService;
            _genreService = genreService;
            _issueService = iissueService;
            InitializeComponent();
            table();
            
        }
    
        private void table()
        {
            add_gird_view.RowHeadersVisible = false;
            add_gird_view.ColumnCount = 2;
            add_gird_view.Columns[0].Name = "STT";
            add_gird_view.Columns[1].Name = "Book name";
            add_gird_view.AllowUserToAddRows = false;
            add_gird_view.Columns.Add(btnDelete);
            addButton();

        }
        private void addButton()
        {
            btnDelete.HeaderText = @"Delete";
            btnDelete.Name = "button";
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;

        }

        private void RenderRow(List<Book> books)
        {
            add_gird_view.Rows.Clear();
            int i = 0;
            foreach(Book book in books)
            {
                i++;
                add_gird_view.Rows.Add(
                    i,
                    book.title
                    );
            }
        }
        private void rjButton1_Click(object sender, EventArgs e)
        {
            using (ChooseBook uu = new ChooseBook(_allBookService, _authorService, _publisherSerivce, _bookService, _genreService))
            {
                //uu.UpdateEventHandler += F2_UpdateEventHandler1;
                if (uu.ShowDialog() == DialogResult.OK)
                {
                    _books = uu.books;
                    RenderRow(_books);
                }

            }
        }

        private void add_gird_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int column = e.ColumnIndex;
            int row = e.RowIndex;
            if (column == 2)
            {
                try
                {
                    string name = add_gird_view.Rows[row].Cells[1].Value.ToString();
                    DialogResult dialogResult = MessageBox.Show("Do you want to delete " + name + " ?", "Notify Message", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int index = _books.FindIndex(e => e.title == name);
                        _books.RemoveAt(index);
                        RenderRow(_books);
                    }

                }
                catch (Exception ex)
                {

                }
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            using (ChooseUser uu = new ChooseUser(_userService))
            {
                //uu.UpdateEventHandler += F2_UpdateEventHandler1;
                if (uu.ShowDialog() == DialogResult.OK)
                {
                    this.Users = uu.Users;
                    label_email.Text = this.Users.email;
                    label_fullname.Text = this.Users.fullname;
                }

            }
        }

        private void issua_add_btn_Click(object sender, EventArgs e)
        {
            string dt = this.datePick.Value.ToString("yyyy-MM-dd");
            if (_books == null)
            {
                MessageBox.Show("No selected books ", "Notify");
                return;
            }
            if (Users== null)
            {
                MessageBox.Show("No User", "Notify");
                return;
            }
            string now = DateTime.Now.ToString("yyyy-MM-dd");
            DateTime sq = DateTime.Parse(dt);
            if (sq < DateTime.Parse(now))
            {
                MessageBox.Show("Time error", "Notify");
                return;
            }
            // insert data 

            bool status = _issueService.InsertIssue(_books, Users, sq);
            _books.Clear();
            MessageBox.Show("Save success", "Notify");
            RenderRow(_books);
        }
    }
}
