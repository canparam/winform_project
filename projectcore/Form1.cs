using projectcore.Database;
using projectcore.FormControls;
using projectcore.models;
using projectcore.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectcore
{
    public partial class Form1 : Form
    {
        private readonly IAdminService _adminService;
        private readonly IServiceProvider _serviceProvider;

        public Form1(IAdminService adminService, IServiceProvider serviceProvider)
        {
            _adminService = adminService;
            _serviceProvider = serviceProvider;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        private void Username_enter(object sender, EventArgs e)
        {
           if(userName.Texts == "Username")
            {
                userName.Texts = "";
            }
        }
        private void Username_leva(object sender, EventArgs e)
        {
            if (userName.Texts == "")
            {
                userName.Texts = "Username";
            }
        }
        private void Password_enter(object sender, EventArgs e)
        {
            if (Password.Texts == "Password")
            {
                Password.Texts = "";
                Password.PasswordChar = true;
            }
        }
        private void Password_leva(object sender, EventArgs e)
        {
            if (Password.Texts == "")
            {
                Password.Texts = "Password";
                Password.PasswordChar = false;
            }
        }

        private string Validate_Login()
        {
            string mess = "";
            if(String.IsNullOrEmpty(userName.Texts) || userName.Texts == "Username")
            {
                mess += "Input username\n";
            }
            if(String.IsNullOrEmpty(Password.Texts) || Password.Texts == "Password")
            {
                mess += "Input password \n";
            }
            return mess;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            string validate = Validate_Login();
            messValidate.Font = new Font("Calibri", 10);
            messValidate.ForeColor = Color.Red;
            if (!String.IsNullOrEmpty(validate))
            {
                messValidate.Text = validate;
                
                return;
            }
            
            string Tpassword = Password.Texts;
            string username = userName.Texts;

            btn_login.Enabled = false;
            Admin ad = _adminService.CheckLogin(username,Tpassword);
            Cursor.Current = Cursors.WaitCursor;
            if (ad == null)
            {
                messValidate.Text = "Login fail!";
                btn_login.Enabled = true;
                return;
            }
            messValidate.Text = "";
            Helper.admin = ad;
            Form m = new Main(_serviceProvider);
            m.Show();
            

        }

    }
    
}
