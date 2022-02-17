using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using projectcore.models;
using projectcore.Services;
using projectcore.Services.AuthorService;
using projectcore.Services.BookService;

namespace projectcore.FormControls.pages
{
    public partial class addbook : Form
    {
        private readonly IUserService _userService;
        private readonly IGenreService _genreService;
        private readonly IPublisher _publisherService;
        private readonly IBookService _bookService;
        private readonly IAuthorService _authorService;
        private readonly DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
        private List<Book> Books;
        public addbook(IUserService userService, IGenreService genreService, IPublisher publisher,
            IBookService bookService, IAuthorService authorService)
        {
            _userService = userService;
            _genreService = genreService;
            _publisherService = publisher;
            _bookService = bookService;
            _authorService = authorService;
            InitializeComponent();
            InitData();
            table();
            Books = new List<Book>();
        }
        private void InitData()
        {
            // author
            add_author.ValueMember = "id";
            add_author.DisplayMember = "name";
            add_author.DataSource = _authorService.GetActive();
            add_author.DropDownStyle = ComboBoxStyle.DropDownList;

            // Genre
            add_genre.ValueMember = "id";
            add_genre.DisplayMember = "name";
            add_genre.DataSource = _genreService.GetActive();
            add_genre.DropDownStyle = ComboBoxStyle.DropDownList;


            // Pub
            add_publisher.ValueMember = "id";
            add_publisher.DisplayMember = "name";
            add_publisher.DataSource = _publisherService.GetActive();
            add_publisher.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void table()
        {
            tableAddBook.RowHeadersVisible = false;
            tableAddBook.ColumnCount = 6;
            tableAddBook.Columns[0].Name = "Title";
            tableAddBook.Columns[1].Name = "Author";
            tableAddBook.Columns[2].Name = "ISBN";
            tableAddBook.Columns[3].Name = "Genre";
            tableAddBook.Columns[4].Name = "Publisher";
            tableAddBook.Columns[5].Name = "Quantity";

            tableAddBook.AllowUserToAddRows = false;
            tableAddBook.Columns.Add(btnDelete);
            addButton();
        }
        private void addButton()
        {
            btnDelete.HeaderText = @"Action";
            btnDelete.Name = "button";
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;
        }
        private void addbook_VisibleChanged(object sender, EventArgs e)
        {
            InitData();
        }

        private void add_Book_btn_Click(object sender, EventArgs e)
        {
            if (validateForm() == false)
                return;
            Object getAuthor = add_author.SelectedItem;
            Authors author = (Authors)getAuthor;

            Object getPublisher = add_publisher.SelectedItem;
            Publishers publisher = (Publishers)getPublisher;

            Object getGenre = add_genre.SelectedItem;
            Genres genre = (Genres)getGenre;
            string sn = add_Book_ISBN.Texts;
            bool b = _bookService.FindBySN(sn);
            if (b == true)
            {
                bookisbn_validate.Text = "Đã tồn tại";
                return;
            }

            var row = new string[] { add_Book_Name.Texts, author.name, add_Book_ISBN.Texts, genre.name, publisher.name, add_Book_Quantity.Texts };

            tableAddBook.Rows.Add(row);

            Book book = new Book();
            book.title = add_Book_Name.Texts;
            book.published_year =  !String.IsNullOrEmpty(add_Book_Year.Texts) ? int.Parse(add_Book_Year.Texts) : 0;
            book.isbn = add_Book_ISBN.Texts;
            book.description = !String.IsNullOrEmpty(add_Book_Des.Texts) ? add_Book_Des.Texts : "";
            book.author = author.id;
            book.publisher = publisher.id;
            book.genre = genre.id;
            book.quantity = int.Parse(add_Book_Quantity.Texts);
            book.status = 0;

            Books.Add(book);


            // clear form
            add_Book_Name.Texts = "";
            add_Book_Year.Texts = "";
            add_Book_Des.Texts = "";
            add_Book_Quantity.Texts = "";
            add_Book_ISBN.Texts = "";

        }
        private bool validateForm()
        {
            if (String.IsNullOrEmpty(add_Book_Name.Texts))
            {
                bookname_validate.Text = "Name required";
                return false;
            }
            else
                bookname_validate.Text = "";
            if (String.IsNullOrEmpty(add_Book_Quantity.Texts))
            {
                bookquantity_validate.Text = "Quantiy required";
                return false;
            }   
            else
                bookquantity_validate.Text = "";
            if (String.IsNullOrEmpty(add_Book_ISBN.Texts))
            {
                bookisbn_validate.Text = "ISBN required";
                return false;
            } 
            else
                bookisbn_validate.Text = "";



            return true;
        }
        private async void rjButton1_ClickAsync(object sender, EventArgs e)
        {
            if(Books.Count <= 0)
            {
                MessageBox.Show("No data !!", "Notify");
                return;
            }
            // insert data async 
            string param = " @title,@isbn,@publisher,@author,@genre,@published_year,@description,@quantity ";

            foreach(Book book in Books)
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                SqlParameter param1 = new SqlParameter("@title",book.title);
                SqlParameter param2 = new SqlParameter("@isbn", book.isbn);
                SqlParameter param3 = new SqlParameter("@publisher",book.publisher);
                SqlParameter param4 = new SqlParameter("@author", book.author);
                SqlParameter param5 = new SqlParameter("@genre", book.author);
                SqlParameter param6 = new SqlParameter("@published_year", book.published_year);
                SqlParameter param7 = new SqlParameter("@description", book.description);
                SqlParameter param8 = new SqlParameter("@quantity", book.quantity);
                parameters.Add(param1);
                parameters.Add(param2);
                parameters.Add(param3);
                parameters.Add(param4);
                parameters.Add(param5);
                parameters.Add(param6);
                parameters.Add(param7);
                parameters.Add(param8);
                bool insert = await _bookService.InsertProcedureAsync("insertBook",param,parameters);

            }

            MessageBox.Show("Save success !","Notify");

            // clear table
            tableAddBook.Rows.Clear();
        }

        private void tableAddBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (e.ColumnIndex == 6)
            {
                try
                {
                    string isbn = tableAddBook.Rows[index].Cells[2].Value.ToString();

                    DialogResult dialogResult = MessageBox.Show("Do you want to delete ?", "Notify Message", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // delete item by isbn
                        var item = Books.Find(e => e.isbn == isbn);
                        Books.Remove(item);

                        //remove row
                        tableAddBook.Rows.RemoveAt(index);

                    }

                }
                catch (Exception)
                {

                }
            }
        }
    }
}
