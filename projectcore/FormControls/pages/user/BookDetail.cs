using projectcore.models.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projectcore.FormControls.pages.user
{
    public partial class BookDetail : Form
    {
        private List<AllIssues> _allIssues;

        public BookDetail(List<AllIssues> allIssues)
        {
            _allIssues = allIssues;
            this.StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();
            Table();
            InitData();
        }
        private void Table()
        {
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "STT";
            dataGridView1.Columns[1].Name = "Book name";
            dataGridView1.AllowUserToAddRows = false;
            int i = 0;
            foreach (AllIssues iss in _allIssues)
            {
                i++;
                dataGridView1.Rows.Add(
                  i.ToString(),
                  iss.title
                );
            }
        }

        private void InitData()
        {
            user_fullname.Text = _allIssues[0].username;
            user_email.Text = _allIssues[0].email;
            ad_username.Text = _allIssues[0].username;
            issues_date.Text = _allIssues[0].issue_date?.ToString("dd-MM-yyyy");
            expiry_date.Text = _allIssues[0].expiry_date?.ToString("dd-MM-yyyy");
            return_Date.Text = _allIssues[0].return_date?.ToString("dd-MM-yyyy");
            quantity.Text = _allIssues.Count.ToString();

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
