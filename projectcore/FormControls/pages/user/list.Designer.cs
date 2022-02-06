namespace projectcore.FormControls.pages.user
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.user_list_btn = new CustomControls.RJControls.RJButton();
            this.user_list_name = new CustomControls.RJControls.RJTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.user_list_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_list_first = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_list_last = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_list_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_list_gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_list_adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_list_action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.user_list_btn);
            this.panel1.Controls.Add(this.user_list_name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 125);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(353, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 28);
            this.comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sort";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email";
            // 
            // user_list_btn
            // 
            this.user_list_btn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.user_list_btn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.user_list_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.user_list_btn.BorderRadius = 0;
            this.user_list_btn.BorderSize = 0;
            this.user_list_btn.FlatAppearance.BorderSize = 0;
            this.user_list_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user_list_btn.ForeColor = System.Drawing.Color.White;
            this.user_list_btn.Location = new System.Drawing.Point(573, 37);
            this.user_list_btn.Name = "user_list_btn";
            this.user_list_btn.Size = new System.Drawing.Size(188, 46);
            this.user_list_btn.TabIndex = 1;
            this.user_list_btn.Text = "Search";
            this.user_list_btn.TextColor = System.Drawing.Color.White;
            this.user_list_btn.UseVisualStyleBackColor = false;
            // 
            // user_list_name
            // 
            this.user_list_name.BackColor = System.Drawing.SystemColors.Window;
            this.user_list_name.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.user_list_name.BorderFocusColor = System.Drawing.Color.HotPink;
            this.user_list_name.BorderSize = 2;
            this.user_list_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.user_list_name.ForeColor = System.Drawing.Color.DimGray;
            this.user_list_name.Location = new System.Drawing.Point(22, 48);
            this.user_list_name.Margin = new System.Windows.Forms.Padding(4);
            this.user_list_name.Multiline = false;
            this.user_list_name.Name = "user_list_name";
            this.user_list_name.Padding = new System.Windows.Forms.Padding(7);
            this.user_list_name.PasswordChar = false;
            this.user_list_name.Size = new System.Drawing.Size(303, 35);
            this.user_list_name.TabIndex = 0;
            this.user_list_name.Texts = "";
            this.user_list_name.UnderlinedStyle = true;
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
            this.user_list_email,
            this.user_list_first,
            this.user_list_last,
            this.user_list_phone,
            this.user_list_gender,
            this.user_list_adress,
            this.user_list_action});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(800, 325);
            this.dataGridView1.TabIndex = 0;
            // 
            // user_list_email
            // 
            this.user_list_email.HeaderText = "Email";
            this.user_list_email.MinimumWidth = 6;
            this.user_list_email.Name = "user_list_email";
            // 
            // user_list_first
            // 
            this.user_list_first.HeaderText = "FirstName";
            this.user_list_first.MinimumWidth = 6;
            this.user_list_first.Name = "user_list_first";
            // 
            // user_list_last
            // 
            this.user_list_last.HeaderText = "LastName";
            this.user_list_last.MinimumWidth = 6;
            this.user_list_last.Name = "user_list_last";
            // 
            // user_list_phone
            // 
            this.user_list_phone.HeaderText = "Phone";
            this.user_list_phone.MinimumWidth = 6;
            this.user_list_phone.Name = "user_list_phone";
            // 
            // user_list_gender
            // 
            this.user_list_gender.HeaderText = "Gender";
            this.user_list_gender.MinimumWidth = 6;
            this.user_list_gender.Name = "user_list_gender";
            // 
            // user_list_adress
            // 
            this.user_list_adress.HeaderText = "Address";
            this.user_list_adress.MinimumWidth = 6;
            this.user_list_adress.Name = "user_list_adress";
            // 
            // user_list_action
            // 
            this.user_list_action.HeaderText = "Action";
            this.user_list_action.MinimumWidth = 6;
            this.user_list_action.Name = "user_list_action";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn user_list_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_list_first;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_list_last;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_list_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_list_gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_list_adress;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton user_list_btn;
        private CustomControls.RJControls.RJTextBox user_list_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_list_action;
    }
}