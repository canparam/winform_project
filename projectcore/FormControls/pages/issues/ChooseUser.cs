using projectcore.models;
using projectcore.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projectcore.FormControls.pages.issued
{
    public partial class ChooseUser : Form
    {
        private readonly IUserService _userService;
        public Users Users { get; set; }
        public ChooseUser(IUserService userService)
        {
            _userService = userService;
            this.StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();
            Table();
        }
        private void Table()
        {
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Id";
            dataGridView1.Columns[1].Name = "Full Name";
            dataGridView1.Columns[2].Name = "Email";
            dataGridView1.Columns[3].Name = "Phone";
            dataGridView1.Columns[4].Name = "Gender";
            dataGridView1.Columns[5].Name = "Address";
            dataGridView1.AllowUserToAddRows = false;
            loadDataGird(_userService.GetActive());

        }
        private void loadDataGird(List<Users> users)
        {

            dataGridView1.Rows.Clear();
            foreach (Users user in users)
            {
                dataGridView1.Rows.Add(
                    user.id,
                    user.fullname,
                    user.email,
                    user.phone,
                    user.gender == 1 ? "Male" : "Female",
                    user.address
                    );
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int column = e.ColumnIndex;
            int row = e.RowIndex;
            try
            {
                int id = int.Parse(dataGridView1.Rows[row].Cells[0].Value.ToString());
                Users = _userService.GetById(id);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            
        }
    }
}
