using projectcore.Database;
using projectcore.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using projectcore.FormControls.pages.user;
using projectcore.Services;

namespace projectcore.FormControls.pages.user
{
    public partial class edit : Form
    {
        public Users user { get; set; }
        public Users newUser { get; set; }

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;
        list formList;
        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }
        protected void raiseUpdate()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler?.Invoke(this, args);
        }
        public edit(Users user, list lis)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            var gender = new[] { new { Name = "Male", Value = 1 }, new { Name = "Female", Value = 2 } }.ToList();
            comboBoxGender_edit.DisplayMember = "Name";
            comboBoxGender_edit.ValueMember = "Value";
            comboBoxGender_edit.DataSource = gender;
            comboBoxGender_edit.DropDownStyle = ComboBoxStyle.DropDownList;
            this.user = user;
            this.formList = lis;
            initData();
        }
        public void initData()
        {
            var gender = new[] { new { Name = "Male", Value = 1 }, new { Name = "Female", Value = 2 } }.ToList();
            user_edit_name.Texts = this.user.fullname;
            user_edit_email.Texts = this.user.email;
            user_edit_phone.Texts = this.user.phone;
            user_edit_address.Texts = this.user.address;
            edit_user_id.Texts = this.user.id.ToString();

            foreach (var item in gender)
            {
                if (item.Value == this.user.gender)
                    comboBoxGender_edit.SelectedItem = item;
            }
        }

        private void user_edit_btn_Click(object sender, EventArgs e)
        {
            Users userUpdate = new Users();
            Object select = comboBoxGender_edit.SelectedValue;

            userUpdate.fullname = user_edit_name.Texts;
            userUpdate.email = user_edit_email.Texts;
            userUpdate.phone = user_edit_phone.Texts;
            userUpdate.address = user_edit_address.Texts;
            userUpdate.gender = (int)select;
            userUpdate.id = int.Parse(edit_user_id.Texts);
            DialogResult dialogResult = MessageBox.Show("Do you want to update " + user.fullname + " ?", "Notify Message", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                user = userUpdate;
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
            
        }
        private void disableForm()
        {

        }
        private bool validateForm()
        {

            return true;
        }
    }
}
