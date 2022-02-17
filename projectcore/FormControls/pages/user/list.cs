using projectcore.Database;
using projectcore.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Diagnostics;
using Binbin.Linq;
using System.Linq.Expressions;
using projectcore.Services;
using projectcore.Services.AllIssuesService;

namespace projectcore.FormControls.pages.user
{
    public partial class list : Form
    {
        private readonly DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
        private readonly DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
        private readonly DataGridViewButtonColumn btnDetail = new DataGridViewButtonColumn();
        private IUserService _userService;
        private readonly IServiceProvider _serviceProvider;
        private readonly IAllIssuesService _allIssuesService;
        public list(IUserService userService, IServiceProvider serviceProvider, IAllIssuesService allIssuesService)
        {
            _userService = userService;
            _serviceProvider = serviceProvider;
            _allIssuesService = allIssuesService;
            InitializeComponent();

            table();

        }
        private List<Users> allUsers()
        {
            return _userService.GetActive();
        }
        private void table()
        {
            user_gird_list.RowHeadersVisible = false;
            user_gird_list.ColumnCount = 6;
            user_gird_list.Columns[0].Name = "Id";
            user_gird_list.Columns[1].Name = "Full Name";
            user_gird_list.Columns[2].Name = "Email";
            user_gird_list.Columns[3].Name = "Phone";
            user_gird_list.Columns[4].Name = "Gender";
            user_gird_list.Columns[5].Name = "Address";
            user_gird_list.AllowUserToAddRows = false;
            user_gird_list.Columns.Add(btnDelete);
            user_gird_list.Columns.Add(btnEdit);
            user_gird_list.Columns.Add(btnDetail);
            addButton();

            loadDataGird(allUsers());
        }
        private void addButton()
        {
            btnDelete.HeaderText = @"Delete";
            btnDelete.Name = "button";
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;

            // edit
            btnEdit.HeaderText = @"Edit";
            btnEdit.Name = "edit";
            btnEdit.Text = "Edit";
            btnEdit.UseColumnTextForButtonValue = true;
            // edit
            btnDetail.HeaderText = @"View";
            btnDetail.Name = "detail";
            btnDetail.Text = "Detail";
            btnDetail.UseColumnTextForButtonValue = true;

        }
        private void loadDataGird(List<Users> users)
        {

            user_gird_list.Rows.Clear();
            foreach (Users user in users)
            {
                user_gird_list.Rows.Add(
                    user.id,
                    user.fullname,
                    user.email,
                    user.phone,
                    user.gender == 1 ? "Male" : "Female",
                    user.address
                    );
            }

        }

        private void user_gird_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (e.ColumnIndex == 6)
            {
                try
                {
                    int id = int.Parse(user_gird_list.Rows[index].Cells[0].Value.ToString());

                    Users user = _userService.GetById(id);
                    DialogResult dialogResult = MessageBox.Show("Do you want to delete " + user.fullname + " ?", "Notify Message", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        user.status = 1;
                        _userService.Update(user.id,user);
                    }
                    loadDataGird(allUsers());
                }
                catch (Exception)
                {

                }
            }

            if (e.ColumnIndex == 7)
            {
                try
                {
                    int id = int.Parse(user_gird_list.Rows[index].Cells[0].Value.ToString());

                    Users user = _userService.GetById(id);
                    using (edit uu = new FormControls.pages.user.edit(user, this))
                    {
                        //uu.UpdateEventHandler += F2_UpdateEventHandler1;
                        if (uu.ShowDialog() == DialogResult.Yes) {
                            Users userUpdate = uu.user;
                            bool update = _userService.Update(userUpdate.id,userUpdate);
                            if (update)
                            {
                                MessageBox.Show("Update success", "Notify");
                                loadDataGird(allUsers());
                            }    
                            else
                                MessageBox.Show("Update Failed", "Notify");

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

            if (e.ColumnIndex == 8)
            {
                try
                {
                    int id = int.Parse(user_gird_list.Rows[index].Cells[0].Value.ToString());

                    var users = _userService.GetById(id);
                    var ListB = _allIssuesService.GetIssuaesByUserID(users.id);
                    using (Detail uu = new Detail(users, ListB,_allIssuesService))
                    {
                        uu.ShowDialog();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }



        private void user_list_btn_Click(object sender, EventArgs e)
        {
            string email = user_list_name.Texts;
            string name = list_user_name.Texts.ToLower();

            if (String.IsNullOrEmpty(email) && String.IsNullOrEmpty(name))
            {
                loadDataGird(allUsers());
                return;
            }
            var users = new List<Users>();
            if (!String.IsNullOrEmpty(email))
            {
                users = allUsers().ToList().Where(e=> e.email.Contains(email)).ToList();
            }
            if (!String.IsNullOrEmpty(name))
            {
                users = allUsers().ToList().Where(e => e.fullname.ToLower().Contains(name)).ToList();
            }
            loadDataGird(users);
        }

        private void user_gird_list_VisibleChanged(object sender, EventArgs e)
        {
            loadDataGird(allUsers());

        }

        private void list_VisibleChanged(object sender, EventArgs e)
        {
            loadDataGird(allUsers());
        }
    }
}
