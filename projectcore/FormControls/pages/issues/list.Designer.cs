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
            this.issua_list_status = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.issua_list_btn_search = new CustomControls.RJControls.RJButton();
            this.issualist_name = new CustomControls.RJControls.RJTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.issua_list_status);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.issua_list_btn_search);
            this.panel1.Controls.Add(this.issualist_name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 94);
            this.panel1.TabIndex = 0;
            // 
            // issua_list_status
            // 
            this.issua_list_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.issua_list_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issua_list_status.FormattingEnabled = true;
            this.issua_list_status.Location = new System.Drawing.Point(300, 42);
            this.issua_list_status.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.issua_list_status.Name = "issua_list_status";
            this.issua_list_status.Size = new System.Drawing.Size(167, 23);
            this.issua_list_status.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Full name";
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
            this.issua_list_btn_search.Location = new System.Drawing.Point(505, 29);
            this.issua_list_btn_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.issua_list_btn_search.Name = "issua_list_btn_search";
            this.issua_list_btn_search.Size = new System.Drawing.Size(164, 34);
            this.issua_list_btn_search.TabIndex = 1;
            this.issua_list_btn_search.Text = "Search";
            this.issua_list_btn_search.TextColor = System.Drawing.Color.White;
            this.issua_list_btn_search.UseVisualStyleBackColor = false;
            this.issua_list_btn_search.Click += new System.EventHandler(this.issua_list_btn_search_Click);
            // 
            // issualist_name
            // 
            this.issualist_name.BackColor = System.Drawing.SystemColors.Window;
            this.issualist_name.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.issualist_name.BorderFocusColor = System.Drawing.Color.HotPink;
            this.issualist_name.BorderSize = 2;
            this.issualist_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.issualist_name.ForeColor = System.Drawing.Color.DimGray;
            this.issualist_name.Location = new System.Drawing.Point(11, 37);
            this.issualist_name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.issualist_name.Multiline = false;
            this.issualist_name.Name = "issualist_name";
            this.issualist_name.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.issualist_name.PasswordChar = false;
            this.issualist_name.Size = new System.Drawing.Size(273, 27);
            this.issualist_name.TabIndex = 0;
            this.issualist_name.Texts = "";
            this.issualist_name.UnderlinedStyle = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 244);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(700, 244);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "list";
            this.Text = "list";
            this.VisibleChanged += new System.EventHandler(this.list_VisibleChanged);
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
        private System.Windows.Forms.ComboBox issua_list_status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton issua_list_btn_search;
        private CustomControls.RJControls.RJTextBox issualist_name;
    }
}