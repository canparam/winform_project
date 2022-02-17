using projectcore.models.views;
using projectcore.Services.IssueService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace projectcore.FormControls.pages.issued.detail
{
    public enum STATUS
    {
        RETURNED = 0,
        LOST = 1,
        NOT_RETURN = 2
    }
    public partial class Edit : Form
    {
        private List<AllIssues> _allIssues;
        private IissueService _iissueService;
        public Edit(List<AllIssues> allIssues, IissueService iissueService)
        {
            InitializeComponent();
            _allIssues = allIssues;
            _iissueService = iissueService;
            this.StartPosition = FormStartPosition.CenterScreen;

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

            var gender = new[] { new { Name = "RETURNED", Value = 0 }, new { Name = "NOT RETURN", Value = 2 }, new { Name = "LOST", Value = 1 } }.ToList();

            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Value";
            comboBox1.DataSource = gender;

            foreach (var item in gender)
            {
                if (item.Value == _allIssues[0].status)
                    comboBox1.SelectedItem = item;
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Object select = comboBox1.SelectedValue;
            switch ((int)select)
            {
                case (int)STATUS.RETURNED:
                    _iissueService.ReturnBook(_allIssues[0].id);
                    break;
                case (int)STATUS.LOST:
                    _iissueService.Lost(_allIssues[0].id);
                    break;
                case (int)STATUS.NOT_RETURN:
                    _iissueService.NotReturn(_allIssues[0].id);
                    break;
            }
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Save success !", "Notify");
            this.Close();
        }
    }
}
