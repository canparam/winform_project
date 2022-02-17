using projectcore.models;
using projectcore.Services;
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
    public partial class genre : Form
    {
        private readonly DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
        private readonly IGenreService _genreService;
        public genre(IGenreService genreService)
        {
            _genreService = genreService;
            InitializeComponent();
            table();
        }
        private void table()
        {
            genre_gird.RowHeadersVisible = false;
            genre_gird.ColumnCount = 2;
            genre_gird.Columns[0].Name = "Id";
            genre_gird.Columns[1].Name = "Name";
            genre_gird.AllowUserToAddRows = false;
            genre_gird.Columns.Add(btnDelete);
            addButton();

            // add row


            genre_gird.Rows.Clear();
            List<Genres> genres = _genreService.GetActive();
            foreach (Genres gen in genres)
            {
                genre_gird.Rows.Add(
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
            genre_validate.Font = new Font("Calibri", 10);
            genre_validate.ForeColor = Color.Red;
            if (String.IsNullOrEmpty(genre_input.Texts))
            {
                genre_validate.Text = "Name Requried";
                return false;
            }

            return true;
        }

        private void genre_add_Click(object sender, EventArgs e)
        {
            bool valid = validateForm();
            if (valid)
            {
                genre_validate.Text = "";
                string name = genre_input.Texts;
                Genres genre = _genreService.GetFirstByName(name);
                if (genre != null)
                {
                    genre_validate.Text = "User already exists";
                    return;
                }
                _genreService.Insert(new Genres() { name = name });
                MessageBox.Show("Add success", "Notify");
                table();
            }
        }

        private void genre_gird_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            int id = int.Parse(genre_gird.Rows[index].Cells[0].Value.ToString());

            if (e.ColumnIndex == 2)
            {
                Genres genre = _genreService.GetById(id);
                DialogResult dialogResult = MessageBox.Show("Do you want to delete " + genre.name + " ?", "Notify Message", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    genre.status = 1;
                    _genreService.Update(genre.id, genre);
                    table();
                }
            }
        }

        private void genre_VisibleChanged(object sender, EventArgs e)
        {
            table();
        }
    }
}
