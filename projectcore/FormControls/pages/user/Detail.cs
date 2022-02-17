using projectcore.models;
using projectcore.models.views;
using projectcore.Services.AllIssuesService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projectcore.FormControls.pages.user
{
    public enum STATUS
    {
        RETURNED = 0,
        LOST = 1,
        NOT_RETURN = 2
    }
    public partial class Detail : Form
    {
        private readonly DataGridViewButtonColumn btnDetail = new DataGridViewButtonColumn();
        private Users _Users;
        private List<AllIssues> _issues;
        private  IAllIssuesService _allIssuesService;

        public Detail(Users users, List<AllIssues> issues, IAllIssuesService allIssuesService)
        {
            _Users = users;
            _issues = issues;
            _allIssuesService = allIssuesService;
            this.StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();
            InitData();
            Table();
        }
        private void InitData()
        {
            a_address.Text = _Users.address;
            a_email.Text = _Users.email;
            a_gender.Text = _Users.gender == 1 ? "Male" : "Female";
            a_name.Text = _Users.fullname;
            a_phone.Text = _Users.phone;

        }
        private void Table()
        {
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Issues ID";
            dataGridView1.Columns[1].Name = "ISSUE DATE";
            dataGridView1.Columns[2].Name = "RETURN DATE";
            dataGridView1.Columns[3].Name = "EXPIRY DATE";
            dataGridView1.Columns[4].Name = "QUANTITY BOOK";
            dataGridView1.Columns[5].Name = "STATUS";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns.Add(btnDetail);
            addButton();
            foreach(AllIssues iss in _issues)
            {
                string stt = "";
                switch (iss.status)
                {
                    case (int)STATUS.NOT_RETURN:
                        stt = "NOT RETURN";
                        break;
                    case (int)STATUS.RETURNED:
                        stt = "RETURNED";
                        break;
                    case (int)STATUS.LOST:
                        stt = "LOST";
                        break;
                }

                dataGridView1.Rows.Add(
                  iss.id.ToString(),
                  iss.issue_date?.ToString("dd-MM-yyyy"),
                  iss.return_date?.ToString("dd-MM-yyyy"),
                  iss.expiry_date?.ToString("dd-MM-yyyy"),
                  iss.count.ToString(),
                  stt
                );
            }

        }
        private void addButton()
        {
            btnDetail.HeaderText = @"View";
            btnDetail.Name = "detail";
            btnDetail.Text = "Detail";
            btnDetail.UseColumnTextForButtonValue = true;

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int column = e.ColumnIndex;
            int row = e.RowIndex;

            if (column == 6)
            {
                try
                {
                    int id = int.Parse(dataGridView1.Rows[row].Cells[0].Value.ToString());
                    
                    List<AllIssues> allIssues = _allIssuesService.GetIssuaesById(id);
                    using (BookDetail uu = new BookDetail(allIssues))
                    {
                        uu.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
