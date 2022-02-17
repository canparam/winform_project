using projectcore.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace projectcore.FormControls.pages.book
{
    public enum Status
    {
        ACTIVE = 0,
        DELETE = 1,
        DEACTIVE = 2,
    };
    public partial class EditBook : Form
    {
        public Book book { get; set; }
        private List<Authors> _authors;
        private List<Genres> _genres;
        private List<Publishers> _publishers;
        public EditBook(Book b, List<Authors> authors, List<Genres> genres, List<Publishers> publishers)
        {
            book = b;
            _authors = authors;
            _genres = genres;
            _publishers = publishers;

            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            BindingData();
            InitData();



        }
        public void BindingData()
        {
            // binding data
            // author
            add_author.ValueMember = "id";
            add_author.DisplayMember = "name";
            add_author.DataSource = _authors;
            add_author.DropDownStyle = ComboBoxStyle.DropDownList;

            // Genre
            add_genre.ValueMember = "id";
            add_genre.DisplayMember = "name";
            add_genre.DataSource = _genres;
            add_genre.DropDownStyle = ComboBoxStyle.DropDownList;


            // Pub
            add_publisher.ValueMember = "id";
            add_publisher.DisplayMember = "name";
            add_publisher.DataSource = _publishers;
            add_publisher.DropDownStyle = ComboBoxStyle.DropDownList;

            // status
            var status = new[] {
                new { Name = "DeActive", Value = (int)Status.DEACTIVE },
                new { Name = "Active", Value = (int)Status.ACTIVE }
            }.ToList();

            edit_book_status.ValueMember = "Value";
            edit_book_status.DisplayMember = "Name";
            edit_book_status.DataSource = status;
            edit_book_status.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (Authors aB in add_author.Items)
            {
                if (aB.id == book.author)
                {
                    add_author.SelectedItem = aB;
                    break;
                }
            }
            foreach (Genres aB in add_genre.Items)
            {
                if (aB.id == book.genre)
                {
                    add_genre.SelectedItem = aB;
                    break;
                }
            }
            foreach (Publishers aB in add_publisher.Items)
            {
                if (aB.id == book.publisher)
                {
                    add_publisher.SelectedItem = aB;
                    break;
                }
            }
            foreach (var aB in status)
            {
                if (aB.Value.Equals(book.status))
                {
                    edit_book_status.SelectedItem = aB;
                    break;
                }
            }

        }
        public void InitData()
        {

            //
            add_Book_Name.Texts = book.title;
            add_Book_Des.Texts = book.description;
            add_Book_Quantity.Texts = book.quantity.ToString();
            add_Book_Year.Texts = book.published_year.ToString();
            add_Book_ISBN.Texts = book.isbn;




        }

        private void btn_save_edit_book_Click(object sender, EventArgs e)
        {
            bool valde = ValidateForm();
            if (valde)
            {
                Object getAuthor = add_author.SelectedItem;
                Authors author = (Authors)getAuthor;

                Object getPublisher = add_publisher.SelectedItem;
                Publishers publisher = (Publishers)getPublisher;

                Object getGenre = add_genre.SelectedItem;
                Genres genre = (Genres)getGenre;

                Object getStatus = edit_book_status.SelectedValue.ToString();

                int status = int.Parse((string)getStatus);

                book.title = add_Book_Name.Texts;
                book.published_year = !String.IsNullOrEmpty(add_Book_Year.Texts) ? int.Parse(add_Book_Year.Texts) : 0;
                book.isbn = add_Book_ISBN.Texts;
                book.description = !String.IsNullOrEmpty(add_Book_Des.Texts) ? add_Book_Des.Texts : "";
                book.author = author.id;
                book.publisher = publisher.id;
                book.genre = genre.id;
                book.quantity = int.Parse(add_Book_Quantity.Texts);
                book.status = status;
                DialogResult dialogResult = MessageBox.Show("Do you want to update  ?", "Notify Message", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.Yes;
                    this.Close();
                }
            }

        }

        private bool ValidateForm()
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EditBook_VisibleChanged(object sender, EventArgs e)
        {

        }
    }
}
