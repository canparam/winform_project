using projectcore.models;
using projectcore.Services.AuthorService;
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
    public partial class author : Form
    {
        private readonly DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
        private readonly IAuthorService _authorService;
        public author(IAuthorService authorService)
        {
            _authorService = authorService;
            InitializeComponent();
            table();
        }
        private void table()
        {
            author_grid.RowHeadersVisible = false;
            author_grid.ColumnCount = 2;
            author_grid.Columns[0].Name = "Id";
            author_grid.Columns[1].Name = "Name";
            author_grid.AllowUserToAddRows = false;
            author_grid.Columns.Add(btnDelete);
            addButton();

            // add row


            author_grid.Rows.Clear();
            List<Authors> authors = _authorService.GetActive();
            foreach (Authors gen in authors)
            {
                author_grid.Rows.Add(
                    gen.id,
                    gen.name
                    );
            }

        }
        private void addButton()
        {
            btnDelete.HeaderText = @"Action";
            btnDelete.Name = "button";
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;
        }

        private bool validateForm()
        {
            author_validate.Font = new Font("Calibri", 10);
            author_validate.ForeColor = Color.Red;
            if (String.IsNullOrEmpty(author_input.Texts))
            {
                author_validate.Text = "Name Requried";
                return false;
            }

            return true;
        }

        private void author_btn_Click(object sender, EventArgs e)
        {
            bool valid = validateForm();
            if (valid)
            {
                author_validate.Text = "";
                string name = author_input.Texts;
                Authors author = _authorService.GetFirstByName(name);
                if (author != null)
                {
                    author_validate.Text = "User already exists";
                    return;
                }
                _authorService.Insert(new Authors() { name = name });
                MessageBox.Show("Add success", "Notify");
                table();
            }
        }

        private void author_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            int id = int.Parse(author_grid.Rows[index].Cells[0].Value.ToString());

            if (e.ColumnIndex == 2)
            {
                Authors genre = _authorService.GetById(id);
                DialogResult dialogResult = MessageBox.Show("Do you want to delete " + genre.name + " ?", "Notify Message", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    genre.status = 1;
                    _authorService.Update(genre.id, genre);
                    table();
                }
            }
        }

        private void author_VisibleChanged(object sender, EventArgs e)
        {
            table();
        }
    }
}
