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
        public Main()
        {
            InitializeComponent();
            Custom();
        }
        private void Custom()
        {
            subMenu_Books.Visible = false;

        }
        private void hideSubMenu()
        {
            if (subMenu_Books.Visible == true)
            {
                subMenu_Books.Visible = false;
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
            Button[] listDeActive = { btn_books, all_Book_btn, add_Book_btn, pub_Book_btn, author_Book_btn, genres_Book_btn };

            Helper.DeActiveButton(listDeActive);
            btn_dashboard.SwtichToBoldRegular();
            btn_dashboard.SwtichColor();
            btn_dashboard.SwichBG();
            hideSubMenu();

        }
        private void btn_books_Click(object sender, EventArgs e)
        {
            Button[] listDeActive = { btn_dashboard, all_Book_btn, add_Book_btn, pub_Book_btn, author_Book_btn, genres_Book_btn };

            Helper.DeActiveButton(listDeActive);
            showSubMenu(subMenu_Books);
            btn_books.SwtichToBoldRegular();
            btn_books.SwtichColor();
            btn_books.SwichBG();
            
        }

        private void all_Book_btn_Click(object sender, EventArgs e)
        {
            Button[] listDeActive = { btn_dashboard, add_Book_btn, pub_Book_btn, author_Book_btn, genres_Book_btn };
            Helper.DeActiveButton(listDeActive);
            if(all_Book_btn.Font.Style != FontStyle.Bold)
            {
                all_Book_btn.Font = new Font(all_Book_btn.Font, FontStyle.Bold);
                all_Book_btn.SwichBG();
            }
            

        }

        private void add_Book_btn_Click(object sender, EventArgs e)
        {
            Button[] listDeActive = { btn_dashboard, all_Book_btn, pub_Book_btn, author_Book_btn, genres_Book_btn };
            Helper.DeActiveButton(listDeActive);
            if (add_Book_btn.Font.Style != FontStyle.Bold)
            {
                add_Book_btn.Font = new Font(all_Book_btn.Font, FontStyle.Bold);
                add_Book_btn.SwichBG();
            }
        }

        private void pub_Book_btn_Click(object sender, EventArgs e)
        {
            Button[] listDeActive = { btn_dashboard, add_Book_btn, all_Book_btn, author_Book_btn, genres_Book_btn };
            Helper.DeActiveButton(listDeActive);
            if (pub_Book_btn.Font.Style != FontStyle.Bold)
            {
                pub_Book_btn.Font = new Font(pub_Book_btn.Font, FontStyle.Bold);
                pub_Book_btn.SwichBG();
            }
        }

        private void author_Book_btn_Click(object sender, EventArgs e)
        {
            Button[] listDeActive = { btn_dashboard, add_Book_btn, all_Book_btn, genres_Book_btn, pub_Book_btn};
            Helper.DeActiveButton(listDeActive);
            if (author_Book_btn.Font.Style != FontStyle.Bold)
            {
                author_Book_btn.Font = new Font(author_Book_btn.Font, FontStyle.Bold);
                author_Book_btn.SwichBG();
            }
        }

        private void genres_Book_btn_Click(object sender, EventArgs e)
        {
            Button[] listDeActive = { btn_dashboard, add_Book_btn, all_Book_btn, author_Book_btn, pub_Book_btn };
            Helper.DeActiveButton(listDeActive);
            if (genres_Book_btn.Font.Style != FontStyle.Bold)
            {
                genres_Book_btn.Font = new Font(genres_Book_btn.Font, FontStyle.Bold);
                genres_Book_btn.SwichBG();
            }
        }
    }
}
