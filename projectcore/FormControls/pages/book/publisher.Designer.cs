namespace projectcore.FormControls.pages.book
{
    partial class publisher
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pub_gird = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.validate_pub = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pub_add_btn = new CustomControls.RJControls.RJButton();
            this.pub_input = new CustomControls.RJControls.RJTextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pub_gird)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pub_gird);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 102);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 236);
            this.panel2.TabIndex = 3;
            // 
            // pub_gird
            // 
            this.pub_gird.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pub_gird.BackgroundColor = System.Drawing.Color.White;
            this.pub_gird.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pub_gird.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pub_gird.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pub_gird.Location = new System.Drawing.Point(0, 0);
            this.pub_gird.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pub_gird.Name = "pub_gird";
            this.pub_gird.RowHeadersWidth = 51;
            this.pub_gird.RowTemplate.Height = 29;
            this.pub_gird.Size = new System.Drawing.Size(700, 236);
            this.pub_gird.TabIndex = 0;
            this.pub_gird.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pub_gird_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.validate_pub);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pub_add_btn);
            this.panel1.Controls.Add(this.pub_input);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 102);
            this.panel1.TabIndex = 2;
            // 
            // validate_pub
            // 
            this.validate_pub.AutoSize = true;
            this.validate_pub.Location = new System.Drawing.Point(12, 79);
            this.validate_pub.Name = "validate_pub";
            this.validate_pub.Size = new System.Drawing.Size(0, 15);
            this.validate_pub.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // pub_add_btn
            // 
            this.pub_add_btn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pub_add_btn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.pub_add_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pub_add_btn.BorderRadius = 0;
            this.pub_add_btn.BorderSize = 0;
            this.pub_add_btn.FlatAppearance.BorderSize = 0;
            this.pub_add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pub_add_btn.ForeColor = System.Drawing.Color.White;
            this.pub_add_btn.Location = new System.Drawing.Point(273, 33);
            this.pub_add_btn.Name = "pub_add_btn";
            this.pub_add_btn.Size = new System.Drawing.Size(150, 42);
            this.pub_add_btn.TabIndex = 1;
            this.pub_add_btn.Text = "Add";
            this.pub_add_btn.TextColor = System.Drawing.Color.White;
            this.pub_add_btn.UseVisualStyleBackColor = false;
            this.pub_add_btn.Click += new System.EventHandler(this.pub_add_btn_Click_1);
            // 
            // pub_input
            // 
            this.pub_input.BackColor = System.Drawing.SystemColors.Window;
            this.pub_input.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.pub_input.BorderFocusColor = System.Drawing.Color.HotPink;
            this.pub_input.BorderSize = 2;
            this.pub_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pub_input.ForeColor = System.Drawing.Color.DimGray;
            this.pub_input.Location = new System.Drawing.Point(13, 44);
            this.pub_input.Margin = new System.Windows.Forms.Padding(4);
            this.pub_input.Multiline = false;
            this.pub_input.Name = "pub_input";
            this.pub_input.Padding = new System.Windows.Forms.Padding(7);
            this.pub_input.PasswordChar = false;
            this.pub_input.Size = new System.Drawing.Size(233, 31);
            this.pub_input.TabIndex = 0;
            this.pub_input.Texts = "";
            this.pub_input.UnderlinedStyle = true;
            // 
            // publisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "publisher";
            this.Text = "publisher";
            this.VisibleChanged += new System.EventHandler(this.publisher_VisibleChanged);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pub_gird)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView pub_gird;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJControls.RJTextBox pub_input;
        private CustomControls.RJControls.RJButton pub_add_btn;
        private System.Windows.Forms.Label validate_pub;
        private System.Windows.Forms.Label label1;
    }
}