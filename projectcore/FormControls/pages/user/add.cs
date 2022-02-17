using projectcore.Database;
using projectcore.models;
using projectcore.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace projectcore.FormControls.pages.user
{
    public partial class add : Form
    {
        private List<Users> users;
        private readonly DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
        private IUserService _userService;
     
        public add(IUserService userService)
        {
            _userService = userService;
            InitializeComponent();
            var gender = new[] { new { Name = "Male", Value = 1 }, new { Name = "Female", Value = 2 } }.ToList();
            comboBoxGender.DisplayMember = "Name";
            comboBoxGender.ValueMember = "Value";
            comboBoxGender.DataSource = gender;
            comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            this.users = new List<Users>();
            table();
            
        }
        
        private void table()
        {
            add_user_data_gird.RowHeadersVisible = false;
            add_user_data_gird.ColumnCount = 6;
            add_user_data_gird.Columns[0].Name = "STT";
            add_user_data_gird.Columns[1].Name = "Full Name";
            add_user_data_gird.Columns[2].Name = "Email";
            add_user_data_gird.Columns[3].Name = "Phone";
            add_user_data_gird.Columns[4].Name = "Gender";
            add_user_data_gird.Columns[5].Name = "Address";
            add_user_data_gird.AllowUserToAddRows = false;
            add_user_data_gird.Columns.Add(btnDelete);
            addButton();
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

            return true;
        }

        private void user_add_add_Click(object sender, EventArgs e)
        {
            Object select = comboBoxGender.SelectedValue;

            Users user = new Users();
            user.fullname = user_add_fr.Texts;
            user.email = user_add_mail.Texts;
            user.phone = user_add_p.Texts.Trim();
            user.address = user_add_ad.Texts;
            user.gender = (int)select;
            this.users.Add(user);

            // reset input
            user_add_mail.Texts = "";
            user_add_fr.Texts = "";
            user_add_p.Texts = "";
            user_add_ad.Texts = "";


            //load data
            loadDataGird();
        }
        private void loadDataGird()
        {

            add_user_data_gird.Rows.Clear();
            var i = 1;
            foreach (Users use in this.users)
            {

                add_user_data_gird.Rows.Add(
                    i++,
                    use.fullname,
                    use.email,
                    use.phone,
                    use.gender == 1 ? "Male" : "Female",
                    use.address
                    );
            }
        }

        private void add_user_data_gird_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                try
                {
                    int index = e.RowIndex;
                    this.users.RemoveAt(index);
                    loadDataGird();
                }
                catch (Exception)
                {

                }
            }
        }

        private void user_btn_save_Click(object sender, EventArgs e)
        {
            if (this.users.Count <= 0)
                MessageBox.Show("No data", "Notify");
            else
            {
                // insert data
                int row = _userService.InsertMany(this.users);
                MessageBox.Show(row + " Add success!", "Notify");
                this.users.Clear();
                loadDataGird();
               
            }

        }
    }
}
