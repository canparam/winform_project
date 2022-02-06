namespace projectcore.FormControls.pages.user
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.user_btn_save = new CustomControls.RJControls.RJButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.user_add_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_add_first = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_add_last = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_add_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_add_gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_add_adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_add_action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_add_mail = new CustomControls.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.user_add_fr = new CustomControls.RJControls.RJTextBox();
            this.user_add_p = new CustomControls.RJControls.RJTextBox();
            this.user_add_ad = new CustomControls.RJControls.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.user_add_add = new CustomControls.RJControls.RJButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.user_add_add);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.user_add_ad);
            this.panel1.Controls.Add(this.user_add_p);
            this.panel1.Controls.Add(this.user_add_fr);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.user_add_mail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 174);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.user_btn_save);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 370);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 80);
            this.panel2.TabIndex = 1;
            // 
            // user_btn_save
            // 
            this.user_btn_save.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.user_btn_save.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.user_btn_save.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.user_btn_save.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.user_btn_save.BorderRadius = 0;
            this.user_btn_save.BorderSize = 0;
            this.user_btn_save.FlatAppearance.BorderSize = 0;
            this.user_btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user_btn_save.ForeColor = System.Drawing.Color.White;
            this.user_btn_save.Location = new System.Drawing.Point(575, 15);
            this.user_btn_save.Name = "user_btn_save";
            this.user_btn_save.Size = new System.Drawing.Size(188, 50);
            this.user_btn_save.TabIndex = 0;
            this.user_btn_save.Text = "Save";
            this.user_btn_save.TextColor = System.Drawing.Color.White;
            this.user_btn_save.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 174);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 196);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_add_email,
            this.user_add_first,
            this.user_add_last,
            this.user_add_phone,
            this.user_add_gender,
            this.user_add_adress,
            this.user_add_action});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(800, 196);
            this.dataGridView1.TabIndex = 1;
            // 
            // user_add_email
            // 
            this.user_add_email.HeaderText = "Email";
            this.user_add_email.MinimumWidth = 6;
            this.user_add_email.Name = "user_add_email";
            // 
            // user_add_first
            // 
            this.user_add_first.HeaderText = "FirstName";
            this.user_add_first.MinimumWidth = 6;
            this.user_add_first.Name = "user_add_first";
            // 
            // user_add_last
            // 
            this.user_add_last.HeaderText = "LastName";
            this.user_add_last.MinimumWidth = 6;
            this.user_add_last.Name = "user_add_last";
            // 
            // user_add_phone
            // 
            this.user_add_phone.HeaderText = "Phone";
            this.user_add_phone.MinimumWidth = 6;
            this.user_add_phone.Name = "user_add_phone";
            // 
            // user_add_gender
            // 
            this.user_add_gender.HeaderText = "Gender";
            this.user_add_gender.MinimumWidth = 6;
            this.user_add_gender.Name = "user_add_gender";
            // 
            // user_add_adress
            // 
            this.user_add_adress.HeaderText = "Address";
            this.user_add_adress.MinimumWidth = 6;
            this.user_add_adress.Name = "user_add_adress";
            // 
            // user_add_action
            // 
            this.user_add_action.HeaderText = "Action";
            this.user_add_action.MinimumWidth = 6;
            this.user_add_action.Name = "user_add_action";
            // 
            // user_add_mail
            // 
            this.user_add_mail.BackColor = System.Drawing.SystemColors.Window;
            this.user_add_mail.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.user_add_mail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.user_add_mail.BorderSize = 2;
            this.user_add_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.user_add_mail.ForeColor = System.Drawing.Color.DimGray;
            this.user_add_mail.Location = new System.Drawing.Point(13, 33);
            this.user_add_mail.Margin = new System.Windows.Forms.Padding(4);
            this.user_add_mail.Multiline = false;
            this.user_add_mail.Name = "user_add_mail";
            this.user_add_mail.Padding = new System.Windows.Forms.Padding(7);
            this.user_add_mail.PasswordChar = false;
            this.user_add_mail.Size = new System.Drawing.Size(240, 35);
            this.user_add_mail.TabIndex = 0;
            this.user_add_mail.Texts = "";
            this.user_add_mail.UnderlinedStyle = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Full Name";
            // 
            // user_add_fr
            // 
            this.user_add_fr.BackColor = System.Drawing.SystemColors.Window;
            this.user_add_fr.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.user_add_fr.BorderFocusColor = System.Drawing.Color.HotPink;
            this.user_add_fr.BorderSize = 2;
            this.user_add_fr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.user_add_fr.ForeColor = System.Drawing.Color.DimGray;
            this.user_add_fr.Location = new System.Drawing.Point(13, 105);
            this.user_add_fr.Margin = new System.Windows.Forms.Padding(4);
            this.user_add_fr.Multiline = false;
            this.user_add_fr.Name = "user_add_fr";
            this.user_add_fr.Padding = new System.Windows.Forms.Padding(7);
            this.user_add_fr.PasswordChar = false;
            this.user_add_fr.Size = new System.Drawing.Size(240, 35);
            this.user_add_fr.TabIndex = 3;
            this.user_add_fr.Texts = "";
            this.user_add_fr.UnderlinedStyle = true;
            // 
            // user_add_p
            // 
            this.user_add_p.BackColor = System.Drawing.SystemColors.Window;
            this.user_add_p.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.user_add_p.BorderFocusColor = System.Drawing.Color.HotPink;
            this.user_add_p.BorderSize = 2;
            this.user_add_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.user_add_p.ForeColor = System.Drawing.Color.DimGray;
            this.user_add_p.Location = new System.Drawing.Point(301, 33);
            this.user_add_p.Margin = new System.Windows.Forms.Padding(4);
            this.user_add_p.Multiline = false;
            this.user_add_p.Name = "user_add_p";
            this.user_add_p.Padding = new System.Windows.Forms.Padding(7);
            this.user_add_p.PasswordChar = false;
            this.user_add_p.Size = new System.Drawing.Size(240, 35);
            this.user_add_p.TabIndex = 4;
            this.user_add_p.Texts = "";
            this.user_add_p.UnderlinedStyle = true;
            // 
            // user_add_ad
            // 
            this.user_add_ad.BackColor = System.Drawing.SystemColors.Window;
            this.user_add_ad.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.user_add_ad.BorderFocusColor = System.Drawing.Color.HotPink;
            this.user_add_ad.BorderSize = 2;
            this.user_add_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.user_add_ad.ForeColor = System.Drawing.Color.DimGray;
            this.user_add_ad.Location = new System.Drawing.Point(301, 105);
            this.user_add_ad.Margin = new System.Windows.Forms.Padding(4);
            this.user_add_ad.Multiline = false;
            this.user_add_ad.Name = "user_add_ad";
            this.user_add_ad.Padding = new System.Windows.Forms.Padding(7);
            this.user_add_ad.PasswordChar = false;
            this.user_add_ad.Size = new System.Drawing.Size(240, 35);
            this.user_add_ad.TabIndex = 5;
            this.user_add_ad.Texts = "";
            this.user_add_ad.UnderlinedStyle = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(575, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gender";
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(575, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 28);
            this.comboBox1.TabIndex = 9;
            // 
            // user_add_add
            // 
            this.user_add_add.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.user_add_add.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.user_add_add.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.user_add_add.BorderRadius = 0;
            this.user_add_add.BorderSize = 0;
            this.user_add_add.FlatAppearance.BorderSize = 0;
            this.user_add_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user_add_add.ForeColor = System.Drawing.Color.White;
            this.user_add_add.Location = new System.Drawing.Point(584, 95);
            this.user_add_add.Name = "user_add_add";
            this.user_add_add.Size = new System.Drawing.Size(188, 45);
            this.user_add_add.TabIndex = 10;
            this.user_add_add.Text = "Add";
            this.user_add_add.TextColor = System.Drawing.Color.White;
            this.user_add_add.UseVisualStyleBackColor = false;
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
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private CustomControls.RJControls.RJButton user_btn_save;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_add_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_add_first;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_add_last;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_add_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_add_gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_add_adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_add_action;
        private CustomControls.RJControls.RJButton user_add_add;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJTextBox user_add_ad;
        private CustomControls.RJControls.RJTextBox user_add_p;
        private CustomControls.RJControls.RJTextBox user_add_fr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJTextBox user_add_mail;
    }
}