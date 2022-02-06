namespace projectcore.FormControls.pages.issued
{
    partial class list
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.issua_list_sort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.issua_list_btn_search = new CustomControls.RJControls.RJButton();
            this.issualist_name = new CustomControls.RJControls.RJTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.issualistName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issualistTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issualistDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issualistExpiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issualistReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issualistStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issualistAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.issua_list_sort);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.issua_list_btn_search);
            this.panel1.Controls.Add(this.issualist_name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 125);
            this.panel1.TabIndex = 0;
            // 
            // issua_list_sort
            // 
            this.issua_list_sort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issua_list_sort.FormattingEnabled = true;
            this.issua_list_sort.Location = new System.Drawing.Point(343, 56);
            this.issua_list_sort.Name = "issua_list_sort";
            this.issua_list_sort.Size = new System.Drawing.Size(190, 28);
            this.issua_list_sort.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sort";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Book name";
            // 
            // issua_list_btn_search
            // 
            this.issua_list_btn_search.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.issua_list_btn_search.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.issua_list_btn_search.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.issua_list_btn_search.BorderRadius = 0;
            this.issua_list_btn_search.BorderSize = 0;
            this.issua_list_btn_search.FlatAppearance.BorderSize = 0;
            this.issua_list_btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issua_list_btn_search.ForeColor = System.Drawing.Color.White;
            this.issua_list_btn_search.Location = new System.Drawing.Point(577, 39);
            this.issua_list_btn_search.Name = "issua_list_btn_search";
            this.issua_list_btn_search.Size = new System.Drawing.Size(188, 45);
            this.issua_list_btn_search.TabIndex = 1;
            this.issua_list_btn_search.Text = "Search";
            this.issua_list_btn_search.TextColor = System.Drawing.Color.White;
            this.issua_list_btn_search.UseVisualStyleBackColor = false;
            // 
            // issualist_name
            // 
            this.issualist_name.BackColor = System.Drawing.SystemColors.Window;
            this.issualist_name.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.issualist_name.BorderFocusColor = System.Drawing.Color.HotPink;
            this.issualist_name.BorderSize = 2;
            this.issualist_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.issualist_name.ForeColor = System.Drawing.Color.DimGray;
            this.issualist_name.Location = new System.Drawing.Point(13, 49);
            this.issualist_name.Margin = new System.Windows.Forms.Padding(4);
            this.issualist_name.Multiline = false;
            this.issualist_name.Name = "issualist_name";
            this.issualist_name.Padding = new System.Windows.Forms.Padding(7);
            this.issualist_name.PasswordChar = false;
            this.issualist_name.Size = new System.Drawing.Size(312, 35);
            this.issualist_name.TabIndex = 0;
            this.issualist_name.Texts = "";
            this.issualist_name.UnderlinedStyle = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 325);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.issualistName,
            this.issualistTo,
            this.issualistDate,
            this.issualistExpiry,
            this.issualistReturn,
            this.issualistStatus,
            this.issualistAction});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(800, 325);
            this.dataGridView1.TabIndex = 0;
            // 
            // issualistName
            // 
            this.issualistName.HeaderText = "BOOK";
            this.issualistName.MinimumWidth = 6;
            this.issualistName.Name = "issualistName";
            // 
            // issualistTo
            // 
            this.issualistTo.HeaderText = "ISSUE TO\t";
            this.issualistTo.MinimumWidth = 6;
            this.issualistTo.Name = "issualistTo";
            // 
            // issualistDate
            // 
            this.issualistDate.HeaderText = "ISSUE DATE";
            this.issualistDate.MinimumWidth = 6;
            this.issualistDate.Name = "issualistDate";
            // 
            // issualistExpiry
            // 
            this.issualistExpiry.HeaderText = "EXPIRY DATE";
            this.issualistExpiry.MinimumWidth = 6;
            this.issualistExpiry.Name = "issualistExpiry";
            // 
            // issualistReturn
            // 
            this.issualistReturn.HeaderText = "RETURN DATE";
            this.issualistReturn.MinimumWidth = 6;
            this.issualistReturn.Name = "issualistReturn";
            // 
            // issualistStatus
            // 
            this.issualistStatus.HeaderText = "Status";
            this.issualistStatus.MinimumWidth = 6;
            this.issualistStatus.Name = "issualistStatus";
            // 
            // issualistAction
            // 
            this.issualistAction.HeaderText = "ACTIONS";
            this.issualistAction.MinimumWidth = 6;
            this.issualistAction.Name = "issualistAction";
            // 
            // list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "list";
            this.Text = "list";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn issualistName;
        private System.Windows.Forms.DataGridViewTextBoxColumn issualistTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn issualistDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn issualistExpiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn issualistReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issualistStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn issualistAction;
        private System.Windows.Forms.ComboBox issua_list_sort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton issua_list_btn_search;
        private CustomControls.RJControls.RJTextBox issualist_name;
    }
}