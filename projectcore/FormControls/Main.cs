using Microsoft.Extensions.DependencyInjection;
using projectcore.FormControls.pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projectcore.FormControls
{

    public partial class Main : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public Main(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
            Form1.ActiveForm.Hide();
            Custom();
            this.StartPosition = FormStartPosition.CenterScreen;


        }
        private void Custom()
        {
            subMenu_Books.Visible = false;
            submenu_Issua.Visible = false;
            subMenu_user.Visible = false;


        }
        private void hideSubMenu()
        {
            if (subMenu_Books.Visible == true)
            {
                subMenu_Books.Visible = false;
            }
            if (submenu_Issua.Visible == true)
            {
                submenu_Issua.Visible = false;
            }
            if (subMenu_user.Visible == true)
            {
                subMenu_user.Visible = false;
            }

        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
            
        }
        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            Button[] listDeActive = { btn_add_user, btn_list_user, btn_user, btn_books, all_Book_btn, add_Book_btn, pub_Book_btn, author_Book_btn, genres_Book_btn, btn_isssue_Book, add_issua };
            Helper.DeActiveButton(listDeActive);
            btn_dashboard.SwtichToBoldRegular();
            btn_dashboard.SwtichColor();
            btn_dashboard.SwichBG();
            hideSubMenu();
            var form = _serviceProvider.GetRequiredService<dashboard>();

            openChildFormInPanel(form);

        }
        private void btn_books_Click(object sender, EventArgs e)
        {
            Button[] listDeActive = { btn_add_user, btn_list_user, btn_user, btn_dashboard, all_Book_btn, add_Book_btn, pub_Book_btn, author_Book_btn, genres_Book_btn, btn_isssue_Book, add_issua };

            Helper.DeActiveButton(listDeActive);
            showSubMenu(subMenu_Books);
            btn_books.SwtichToBoldRegular();
            btn_books.SwtichColor();
            btn_books.SwichBG();
            
        }

        private void all_Book_btn_Click(object sender, EventArgs e)
        {
            Button[] listDeActive = { btn_add_user, btn_list_user, btn_user, btn_dashboard, add_Book_btn, pub_Book_btn, author_Book_btn, genres_Book_btn, btn_isssue_Book, add_issua };
            Helper.DeActiveButton(listDeActive);
            if(all_Book_btn.Font.Style != FontStyle.Bold)
            {
                all_Book_btn.Font = new Font(all_Book_btn.Font, FontStyle.Bold);
                all_Book_btn.SwichBG();
            }
            var form = _serviceProvider.GetRequiredService<allbook>();

            openChildFormInPanel(form);


        }

        private void add_Book_btn_Click(object sender, EventArgs e)
        {
            Button[] listDeActive = { btn_add_user, btn_list_user, btn_user, btn_dashboard, all_Book_btn, pub_Book_btn, author_Book_btn, genres_Book_btn, btn_isssue_Book, add_issua };
            Helper.DeActiveButton(listDeActive);
            if (add_Book_btn.Font.Style != FontStyle.Bold)
            {
                add_Book_btn.Font = new Font(all_Book_btn.Font, FontStyle.Bold);
                add_Book_btn.SwichBG();
            }
            var form = _serviceProvider.GetRequiredService<pages.addbook>();

            openChildFormInPanel(form);
        }

        private void pub_Book_btn_Click(object sender, EventArgs e)
        {
            Button[] listDeActive = { btn_add_user, btn_list_user, btn_user, btn_dashboard, add_Book_btn, all_Book_btn, author_Book_btn, genres_Book_btn, btn_isssue_Book, add_issua };
            Helper.DeActiveButton(listDeActive);
            if (pub_Book_btn.Font.Style != FontStyle.Bold)
            {
                pub_Book_btn.Font = new Font(pub_Book_btn.Font, FontStyle.Bold);
                pub_Book_btn.SwichBG();
            }
            var form = _serviceProvider.GetRequiredService<pages.book.publisher>();

            openChildFormInPanel(form);
        }

        private void author_Book_btn_Click(object sender, EventArgs e)
        {
            Button[] listDeActive = { btn_add_user, btn_list_user, btn_user, btn_dashboard, add_Book_btn, all_Book_btn, genres_Book_btn, pub_Book_btn, btn_isssue_Book, add_issua };
            Helper.DeActiveButton(listDeActive);
            if (author_Book_btn.Font.Style != FontStyle.Bold)
            {
                author_Book_btn.Font = new Font(author_Book_btn.Font, FontStyle.Bold);
                author_Book_btn.SwichBG();
            }
            var form = _serviceProvider.GetRequiredService<pages.book.author>();

            openChildFormInPanel(form);
        }

        private void genres_Book_btn_Click(object sender, EventArgs e)
        {
            Button[] listDeActive = { btn_add_user, btn_list_user, btn_user, btn_dashboard, add_Book_btn, all_Book_btn, author_Book_btn, pub_Book_btn, btn_isssue_Book, add_issua };
            Helper.DeActiveButton(listDeActive);
            if (genres_Book_btn.Font.Style != FontStyle.Bold)
            {
                genres_Book_btn.Font = new Font(genres_Book_btn.Font, FontStyle.Bold);
                genres_Book_btn.SwichBG();
            }
            var forms = _serviceProvider.GetRequiredService<pages.book.genre>();
            openChildFormInPanel(forms);

        }

        private void btn_isssue_Book_Click(object sender, EventArgs e)
        {
            Button[] listDeActive = { btn_add_user, btn_list_user, btn_user, btn_dashboard, btn_books, all_Book_btn, add_Book_btn, pub_Book_btn, author_Book_btn, genres_Book_btn, add_issua };
            Helper.DeActiveButton(listDeActive);
            showSubMenu(submenu_Issua);
            btn_isssue_Book.SwtichToBoldRegular();
            btn_isssue_Book.SwtichColor();
            btn_isssue_Book.SwichBG();

        }

        private void list_issua_Click(object sender, EventArgs e)
        {
            Button[] listDeActive = { btn_add_user, btn_list_user, btn_user, btn_dashboard, btn_books, all_Book_btn, add_Book_btn, pub_Book_btn, author_Book_btn, genres_Book_btn, add_issua };
            Helper.DeActiveButton(listDeActive);
            if (list_issua.Font.Style != FontStyle.Bold)
            {
                list_issua.Font = new Font(list_issua.Font, FontStyle.Bold);
                list_issua.SwichBG();
            }
            var form = _serviceProvider.GetRequiredService<pages.issued.list>();
            openChildFormInPanel(form);
        }

        private void add_issua_Click(object sender, EventArgs e)
        {
            Button[] listDeActive = { btn_add_user, btn_list_user,btn_user, btn_dashboard, btn_books, all_Book_btn, add_Book_btn, pub_Book_btn, author_Book_btn, genres_Book_btn, list_issua };
            Helper.DeActiveButton(listDeActive);
            if (add_issua.Font.Style != FontStyle.Bold)
            {
                add_issua.Font = new Font(add_issua.Font, FontStyle.Bold);
                add_issua.SwichBG();
            }
            var form = _serviceProvider.GetRequiredService<pages.issued.add>();
            openChildFormInPanel(form);
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            Button[] listDeActive = { btn_dashboard, btn_books, all_Book_btn, add_Book_btn, pub_Book_btn, author_Book_btn, genres_Book_btn, btn_isssue_Book, list_issua, add_issua };

            Helper.DeActiveButton(listDeActive);
            btn_user.SwtichToBoldRegular();
            btn_user.SwtichColor();
            btn_user.SwichBG();
            showSubMenu(subMenu_user);
        }


        private void btn_list_user_Click(object sender, EventArgs e)
        {
            Button[] listDeActive = { btn_add_user, btn_dashboard, btn_books, all_Book_btn, add_Book_btn, pub_Book_btn, author_Book_btn, genres_Book_btn, btn_isssue_Book, list_issua, add_issua };

            Helper.DeActiveButton(listDeActive);
            if (btn_list_user.Font.Style != FontStyle.Bold)
            {
                btn_list_user.Font = new Font(btn_list_user.Font, FontStyle.Bold);
                btn_list_user.SwichBG();
            }
            var forms = _serviceProvider.GetRequiredService<pages.user.list>();
            openChildFormInPanel(forms);
        }

        private void btn_add_user_Click(object sender, EventArgs e)
        {
            Button[] listDeActive = { btn_list_user,btn_dashboard, btn_books, all_Book_btn, add_Book_btn, pub_Book_btn, author_Book_btn, genres_Book_btn, btn_isssue_Book, list_issua, add_issua };

            Helper.DeActiveButton(listDeActive);
            if (btn_add_user.Font.Style != FontStyle.Bold)
            {
                btn_add_user.Font = new Font(btn_add_user.Font, FontStyle.Bold);
                btn_add_user.SwichBG();
            }
            var form = _serviceProvider.GetRequiredService<pages.user.add>();
            openChildFormInPanel(form);
        }
        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Hide();

            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            
            childForm.Show();
        }

    }
}
