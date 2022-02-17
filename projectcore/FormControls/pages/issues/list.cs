using projectcore.FormControls.pages.issued.detail;
using projectcore.models.views;
using projectcore.Services.AllIssuesService;
using projectcore.Services.IssueService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace projectcore.FormControls.pages.issued
{
    public partial class list : Form
    {
        private readonly DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
        private readonly IAllIssuesService _issuesService;
        private readonly IissueService _iissueService;
        private List<AllIssues> _allIssues;
        public enum STATUS
        {
            RETURNED = 0,
            LOST = 1,
            NOT_RETURN = 2
        }
        public list(IAllIssuesService issuesService, IissueService iissueService)
        {
            _issuesService = issuesService;
            _iissueService = iissueService;
            InitializeComponent();
            _allIssues = _issuesService.GetAllIssues();
            Table();


            var gender = new[] { new { Name = "-- Select --", Value = -1 },new { Name = "RETURNED", Value = 0 }, new { Name = "NOT RETURN", Value = 2 }, new { Name = "LOST", Value = 1 } }.ToList();
            issua_list_status.DisplayMember = "Name";
            issua_list_status.ValueMember = "Value";
            issua_list_status.DataSource = gender;

        }
        private void Table()
        {
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "Issues ID";
            dataGridView1.Columns[1].Name = "ISSUE TO";
            dataGridView1.Columns[2].Name = "ISSUE DATE";
            dataGridView1.Columns[3].Name = "RETURN DATE";
            dataGridView1.Columns[4].Name = "EXPIRY DATE";
            dataGridView1.Columns[5].Name = "QUANTITY BOOK";
            dataGridView1.Columns[6].Name = "STATUS";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns.Add(btnEdit);
            addButton();
            RenderRow(_allIssues);

        }
        private void addButton()
        {
            btnEdit.HeaderText = @"Edit";
            btnEdit.Name = "button";
            btnEdit.Text = "Edit";
            btnEdit.UseColumnTextForButtonValue = true;

        }


        private void RenderRow(List<AllIssues> allIssues)
        {
            dataGridView1.Rows.Clear();
            foreach (AllIssues ais in allIssues)
            {
                string stt = "";
                switch (ais.status)
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
                  ais.id,
                  ais.fullname,
                  ais.issue_date?.ToString("dd-MM-yyyy"),
                  ais.return_date?.ToString("dd-MM-yyyy"),
                  ais.expiry_date?.ToString("dd-MM-yyyy") == "01-01-0001" ? "" : ais.expiry_date?.ToString("dd-MM-yyyy"),
                  ais.count,
                  stt
                );
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int column = e.ColumnIndex;
            int row = e.RowIndex;
            if (column == 7)
            {
                try
                {
                    int id = int.Parse(dataGridView1.Rows[row].Cells[0].Value.ToString());
                    List<AllIssues> allIssues = _issuesService.GetIssuaesById(id);

                    using (Edit uu = new Edit(allIssues, _iissueService))
                    {
                        if (uu.ShowDialog() == DialogResult.OK)
                        {
                            RenderRow(_issuesService.GetAllIssues());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void list_VisibleChanged(object sender, EventArgs e)
        {
            Table();
        }

        private void issua_list_btn_search_Click(object sender, EventArgs e)
        {
            Object select = issua_list_status.SelectedValue;
            if ((int)select == -1 && String.IsNullOrEmpty(issualist_name.Texts))
            {
                RenderRow(_allIssues);
                return;
            }
            var allIssues = new List<AllIssues>();
            if ((int)select != -1)
            {
                allIssues =  _allIssues.Where(e => e.status == (int)select).ToList();
            }
            if (!String.IsNullOrEmpty(issualist_name.Texts))
            {
                string name = issualist_name.Texts.ToLower();

                allIssues = _allIssues.ToList().Where(e => e.fullname.ToLower().Contains(name)).ToList();
            }
          
            RenderRow(allIssues);
        }

        
    }
}
