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
            this.rjButton2 = new CustomControls.RJControls.RJButton();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.datePick = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.add_gird_view = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_email = new System.Windows.Forms.Label();
            this.label_fullname = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.issua_add_btn = new CustomControls.RJControls.RJButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.add_gird_view)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rjButton2);
            this.panel1.Controls.Add(this.rjButton1);
            this.panel1.Controls.Add(this.datePick);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 94);
            this.panel1.TabIndex = 0;
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 0;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(217, 25);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(150, 40);
            this.rjButton2.TabIndex = 8;
            this.rjButton2.Text = "Choose user";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(20, 26);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(150, 40);
            this.rjButton1.TabIndex = 7;
            this.rjButton1.Text = "Choose book";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // datePick
            // 
            this.datePick.Location = new System.Drawing.Point(411, 33);
            this.datePick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datePick.Name = "datePick";
            this.datePick.Size = new System.Drawing.Size(182, 23);
            this.datePick.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "RETURN DATE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.add_gird_view);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 147);
            this.panel2.TabIndex = 1;
            // 
            // add_gird_view
            // 
            this.add_gird_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.add_gird_view.BackgroundColor = System.Drawing.Color.White;
            this.add_gird_view.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.add_gird_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.add_gird_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_gird_view.Location = new System.Drawing.Point(0, 0);
            this.add_gird_view.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_gird_view.Name = "add_gird_view";
            this.add_gird_view.RowHeadersWidth = 51;
            this.add_gird_view.RowTemplate.Height = 29;
            this.add_gird_view.Size = new System.Drawing.Size(700, 147);
            this.add_gird_view.TabIndex = 0;
            this.add_gird_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.add_gird_view_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label_email);
            this.panel3.Controls.Add(this.label_fullname);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.issua_add_btn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 241);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(700, 97);
            this.panel3.TabIndex = 2;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_email.Location = new System.Drawing.Point(181, 70);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(0, 21);
            this.label_email.TabIndex = 5;
            // 
            // label_fullname
            // 
            this.label_fullname.AutoSize = true;
            this.label_fullname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_fullname.Location = new System.Drawing.Point(181, 38);
            this.label_fullname.Name = "label_fullname";
            this.label_fullname.Size = new System.Drawing.Size(0, 21);
            this.label_fullname.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(81, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(81, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Full Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(20, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "User:";
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
            this.issua_add_btn.Location = new System.Drawing.Point(525, 32);
            this.issua_add_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.issua_add_btn.Name = "issua_add_btn";
            this.issua_add_btn.Size = new System.Drawing.Size(164, 38);
            this.issua_add_btn.TabIndex = 0;
            this.issua_add_btn.Text = "Save";
            this.issua_add_btn.TextColor = System.Drawing.Color.White;
            this.issua_add_btn.UseVisualStyleBackColor = false;
            this.issua_add_btn.Click += new System.EventHandler(this.issua_add_btn_Click);
            // 
            // add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "add";
            this.Text = "add";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.add_gird_view)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView add_gird_view;
        private System.Windows.Forms.Panel panel3;
        private CustomControls.RJControls.RJButton issua_add_btn;
        private System.Windows.Forms.DateTimePicker datePick;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJButton rjButton2;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_fullname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}