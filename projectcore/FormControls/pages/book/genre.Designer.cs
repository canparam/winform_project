namespace projectcore.FormControls.pages.book
{
    partial class genre
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
            this.genre_gird = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.genre_validate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.genre_add = new CustomControls.RJControls.RJButton();
            this.genre_input = new CustomControls.RJControls.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.genre_gird)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // genre_gird
            // 
            this.genre_gird.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.genre_gird.BackgroundColor = System.Drawing.Color.White;
            this.genre_gird.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.genre_gird.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.genre_gird.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genre_gird.Location = new System.Drawing.Point(0, 0);
            this.genre_gird.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.genre_gird.Name = "genre_gird";
            this.genre_gird.RowHeadersWidth = 51;
            this.genre_gird.RowTemplate.Height = 29;
            this.genre_gird.Size = new System.Drawing.Size(713, 236);
            this.genre_gird.TabIndex = 0;
            this.genre_gird.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.genre_gird_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.genre_gird);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 102);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(713, 236);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.genre_validate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.genre_add);
            this.panel1.Controls.Add(this.genre_input);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 102);
            this.panel1.TabIndex = 2;
            // 
            // genre_validate
            // 
            this.genre_validate.AutoSize = true;
            this.genre_validate.Location = new System.Drawing.Point(13, 74);
            this.genre_validate.Name = "genre_validate";
            this.genre_validate.Size = new System.Drawing.Size(0, 15);
            this.genre_validate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // genre_add
            // 
            this.genre_add.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.genre_add.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.genre_add.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.genre_add.BorderRadius = 0;
            this.genre_add.BorderSize = 0;
            this.genre_add.FlatAppearance.BorderSize = 0;
            this.genre_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genre_add.ForeColor = System.Drawing.Color.White;
            this.genre_add.Location = new System.Drawing.Point(296, 26);
            this.genre_add.Name = "genre_add";
            this.genre_add.Size = new System.Drawing.Size(150, 40);
            this.genre_add.TabIndex = 1;
            this.genre_add.Text = "Add";
            this.genre_add.TextColor = System.Drawing.Color.White;
            this.genre_add.UseVisualStyleBackColor = false;
            this.genre_add.Click += new System.EventHandler(this.genre_add_Click);
            // 
            // genre_input
            // 
            this.genre_input.BackColor = System.Drawing.SystemColors.Window;
            this.genre_input.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.genre_input.BorderFocusColor = System.Drawing.Color.HotPink;
            this.genre_input.BorderSize = 2;
            this.genre_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genre_input.ForeColor = System.Drawing.Color.DimGray;
            this.genre_input.Location = new System.Drawing.Point(13, 35);
            this.genre_input.Margin = new System.Windows.Forms.Padding(4);
            this.genre_input.Multiline = false;
            this.genre_input.Name = "genre_input";
            this.genre_input.Padding = new System.Windows.Forms.Padding(7);
            this.genre_input.PasswordChar = false;
            this.genre_input.Size = new System.Drawing.Size(250, 31);
            this.genre_input.TabIndex = 0;
            this.genre_input.Texts = "";
            this.genre_input.UnderlinedStyle = true;
            // 
            // genre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 338);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "genre";
            this.Text = "genre";
            this.VisibleChanged += new System.EventHandler(this.genre_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.genre_gird)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView genre_gird;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJControls.RJTextBox genre_input;
        private System.Windows.Forms.Label genre_validate;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton genre_add;
    }
}