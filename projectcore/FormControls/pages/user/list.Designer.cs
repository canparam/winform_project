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
            this.list_user_name = new CustomControls.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.user_list_btn = new CustomControls.RJControls.RJButton();
            this.user_list_name = new CustomControls.RJControls.RJTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.user_gird_list = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_gird_list)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.list_user_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.user_list_btn);
            this.panel1.Controls.Add(this.user_list_name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 94);
            this.panel1.TabIndex = 0;
            // 
            // list_user_name
            // 
            this.list_user_name.BackColor = System.Drawing.SystemColors.Window;
            this.list_user_name.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.list_user_name.BorderFocusColor = System.Drawing.Color.HotPink;
            this.list_user_name.BorderSize = 2;
            this.list_user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.list_user_name.ForeColor = System.Drawing.Color.DimGray;
            this.list_user_name.Location = new System.Drawing.Point(293, 32);
            this.list_user_name.Margin = new System.Windows.Forms.Padding(4);
            this.list_user_name.Multiline = false;
            this.list_user_name.Name = "list_user_name";
            this.list_user_name.Padding = new System.Windows.Forms.Padding(7);
            this.list_user_name.PasswordChar = false;
            this.list_user_name.Size = new System.Drawing.Size(185, 31);
            this.list_user_name.TabIndex = 4;
            this.list_user_name.Texts = "";
            this.list_user_name.UnderlinedStyle = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
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
            this.user_list_btn.Location = new System.Drawing.Point(512, 29);
            this.user_list_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user_list_btn.Name = "user_list_btn";
            this.user_list_btn.Size = new System.Drawing.Size(164, 34);
            this.user_list_btn.TabIndex = 1;
            this.user_list_btn.Text = "Search";
            this.user_list_btn.TextColor = System.Drawing.Color.White;
            this.user_list_btn.UseVisualStyleBackColor = false;
            this.user_list_btn.Click += new System.EventHandler(this.user_list_btn_Click);
            // 
            // user_list_name
            // 
            this.user_list_name.BackColor = System.Drawing.SystemColors.Window;
            this.user_list_name.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.user_list_name.BorderFocusColor = System.Drawing.Color.HotPink;
            this.user_list_name.BorderSize = 2;
            this.user_list_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.user_list_name.ForeColor = System.Drawing.Color.DimGray;
            this.user_list_name.Location = new System.Drawing.Point(19, 36);
            this.user_list_name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.user_list_name.Multiline = false;
            this.user_list_name.Name = "user_list_name";
            this.user_list_name.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.user_list_name.PasswordChar = false;
            this.user_list_name.Size = new System.Drawing.Size(245, 27);
            this.user_list_name.TabIndex = 0;
            this.user_list_name.Texts = "";
            this.user_list_name.UnderlinedStyle = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.user_gird_list);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 244);
            this.panel2.TabIndex = 1;
            // 
            // user_gird_list
            // 
            this.user_gird_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.user_gird_list.BackgroundColor = System.Drawing.Color.White;
            this.user_gird_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user_gird_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.user_gird_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user_gird_list.Location = new System.Drawing.Point(0, 0);
            this.user_gird_list.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user_gird_list.Name = "user_gird_list";
            this.user_gird_list.RowHeadersWidth = 51;
            this.user_gird_list.RowTemplate.Height = 29;
            this.user_gird_list.Size = new System.Drawing.Size(700, 244);
            this.user_gird_list.TabIndex = 0;
            this.user_gird_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.user_gird_list_CellClick);
            this.user_gird_list.VisibleChanged += new System.EventHandler(this.user_gird_list_VisibleChanged);
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
            ((System.ComponentModel.ISupportInitialize)(this.user_gird_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView user_gird_list;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton user_list_btn;
        private CustomControls.RJControls.RJTextBox user_list_name;
        private CustomControls.RJControls.RJTextBox list_user_name;
    }
}