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
        public Form1()
        {
            InitializeComponent();
        }
        private void Username_enter(object sender, EventArgs e)
        {
           if(userName.Texts == "Tên đăng nhập")
            {
                userName.Texts = "";
            }
        }
        private void Username_leva(object sender, EventArgs e)
        {
            if (userName.Texts == "")
            {
                userName.Texts = "Tên đăng nhập";
            }
        }
        private void Password_enter(object sender, EventArgs e)
        {
            if (Password.Texts == "Mật khẩu")
            {
                Password.Texts = "";
                Password.PasswordChar = true;
            }
        }
        private void Password_leva(object sender, EventArgs e)
        {
            if (Password.Texts == "")
            {
                Password.Texts = "Mật khẩu";
                Password.PasswordChar = false;
            }
        }

        private string Validate_Login()
        {
            string mess = "";
            if(String.IsNullOrEmpty(userName.Texts) || userName.Texts == "Tên đăng nhập")
            {
                mess += "Vui lòng nhập tên\n";
            }
            if(String.IsNullOrEmpty(Password.Texts) || Password.Texts == "Mật khẩu")
            {
                mess += "Vui lòng nhập mật khẩu \n";
            }
            return mess;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string validate = Validate_Login();
            if(!String.IsNullOrEmpty(validate))
            {
                messValidate.Text = validate;
                messValidate.Font = new Font("Calibri", 10);
                messValidate.ForeColor = Color.Red;
                return;
            }
            else
            {
                messValidate.Text = "";
                MessageBox.Show("Đăng nhập thành công","Thông báo");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
    
}
