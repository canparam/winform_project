using projectcore.models;
using projectcore.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace projectcore.FormControls.pages.book
{
    public partial class publisher : Form
    {
        private readonly IPublisher _publisher;
        private readonly DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();

        public publisher(IPublisher publisher)
        {
            _publisher = publisher;
            InitializeComponent();
            table();
        }

        private void table()
        {
            pub_gird.RowHeadersVisible = false;
            pub_gird.ColumnCount = 2;
            pub_gird.Columns[0].Name = "Id";
            pub_gird.Columns[1].Name = "Name";
            pub_gird.AllowUserToAddRows = false;
            pub_gird.Columns.Add(btnDelete);
            addButton();

            // add row


            pub_gird.Rows.Clear();
            List<Publishers> publishers = _publisher.GetActive();
            foreach (Publishers pub in publishers)
            {
                pub_gird.Rows.Add(
                    pub.id,
                    pub.name
                    );
            }

        }
        private void addButton()
        {
            btnDelete.HeaderText = @"Action";
            btnDelete.Name = "button";
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;
        }

        private bool validateForm()
        {
            validate_pub.Font = new Font("Calibri", 10);
            validate_pub.ForeColor = Color.Red;
            if (String.IsNullOrEmpty(pub_input.Texts))
            {
                validate_pub.Text = "Name Requried";
                return false;
            }
           
            return true;
        }

        private void pub_add_btn_Click_1(object sender, EventArgs e)
        {
            bool vald = validateForm();
            if (vald)
            {
                validate_pub.Text = "";
                string nameInput = pub_input.Texts;
                Publishers pub = _publisher.GetFirstByName(nameInput);
                if(pub != null)
                {
                    validate_pub.Text = "User already exists";
                    return;
                }
                //pub.name = name;

                _publisher.Insert(new Publishers() { name = nameInput });
                MessageBox.Show("Add success","Notify");
                table();

            }
        }

        private void pub_gird_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            int id = int.Parse(pub_gird.Rows[index].Cells[0].Value.ToString());

            if(e.ColumnIndex == 2)
            {
                Publishers pub = _publisher.GetById(id);
                DialogResult dialogResult = MessageBox.Show("Do you want to delete " + pub.name + " ?", "Notify Message", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    pub.status = 1;
                    _publisher.Update(pub.id,pub);
                    table();
                }
            }
        }

        private void publisher_VisibleChanged(object sender, EventArgs e)
        {
            table();
        }
    }
}
