namespace projectcore.FormControls.pages.issued
{
    partial class add
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
            this.issua_btn_add = new CustomControls.RJControls.RJButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_user = new System.Windows.Forms.ComboBox();
            this.combo_book = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuaBookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuaUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuaRetun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.issua_add_btn = new CustomControls.RJControls.RJButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.issua_btn_add);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.combo_user);
            this.panel1.Controls.Add(this.combo_book);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 125);
            this.panel1.TabIndex = 0;
            // 
            // issua_btn_add
            // 
            this.issua_btn_add.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.issua_btn_add.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.issua_btn_add.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.issua_btn_add.BorderRadius = 0;
            this.issua_btn_add.BorderSize = 0;
            this.issua_btn_add.FlatAppearance.BorderSize = 0;
            this.issua_btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issua_btn_add.ForeColor = System.Drawing.Color.White;
            this.issua_btn_add.Location = new System.Drawing.Point(470, 79);
            this.issua_btn_add.Name = "issua_btn_add";
            this.issua_btn_add.Size = new System.Drawing.Size(208, 40);
            this.issua_btn_add.TabIndex = 6;
            this.issua_btn_add.Text = "Add";
            this.issua_btn_add.TextColor = System.Drawing.Color.White;
            this.issua_btn_add.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(470, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(208, 27);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "RETURN DATE";
            // 
            // combo_user
            // 
            this.combo_user.FormattingEnabled = true;
            this.combo_user.Location = new System.Drawing.Point(248, 34);
            this.combo_user.Name = "combo_user";
            this.combo_user.Size = new System.Drawing.Size(178, 28);
            this.combo_user.TabIndex = 3;
            // 
            // combo_book
            // 
            this.combo_book.FormattingEnabled = true;
            this.combo_book.Location = new System.Drawing.Point(23, 34);
            this.combo_book.Name = "combo_book";
            this.combo_book.Size = new System.Drawing.Size(186, 28);
            this.combo_book.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 196);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.issuaBookName,
            this.issuaUser,
            this.issuaRetun});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(800, 196);
            this.dataGridView1.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.HeaderText = "issuaSTT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            // 
            // issuaBookName
            // 
            this.issuaBookName.HeaderText = "Book name";
            this.issuaBookName.MinimumWidth = 6;
            this.issuaBookName.Name = "issuaBookName";
            // 
            // issuaUser
            // 
            this.issuaUser.HeaderText = "User";
            this.issuaUser.MinimumWidth = 6;
            this.issuaUser.Name = "issuaUser";
            // 
            // issuaRetun
            // 
            this.issuaRetun.HeaderText = "Return Date";
            this.issuaRetun.MinimumWidth = 6;
            this.issuaRetun.Name = "issuaRetun";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.issua_add_btn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 321);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 129);
            this.panel3.TabIndex = 2;
            // 
            // issua_add_btn
            // 
            this.issua_add_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.issua_add_btn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.issua_add_btn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.issua_add_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.issua_add_btn.BorderRadius = 0;
            this.issua_add_btn.BorderSize = 0;
            this.issua_add_btn.FlatAppearance.BorderSize = 0;
            this.issua_add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issua_add_btn.ForeColor = System.Drawing.Color.White;
            this.issua_add_btn.Location = new System.Drawing.Point(600, 42);
            this.issua_add_btn.Name = "issua_add_btn";
            this.issua_add_btn.Size = new System.Drawing.Size(188, 50);
            this.issua_add_btn.TabIndex = 0;
            this.issua_add_btn.Text = "Save";
            this.issua_add_btn.TextColor = System.Drawing.Color.White;
            this.issua_add_btn.UseVisualStyleBackColor = false;
            // 
            // add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "add";
            this.Text = "add";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private CustomControls.RJControls.RJButton issua_add_btn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private CustomControls.RJControls.RJButton issua_btn_add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_user;
        private System.Windows.Forms.ComboBox combo_book;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuaBookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuaUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuaRetun;
    }
}