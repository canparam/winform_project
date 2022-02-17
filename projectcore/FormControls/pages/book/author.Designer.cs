namespace projectcore.FormControls.pages.book
{
    partial class author
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
            this.author_grid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.author_validate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.author_btn = new CustomControls.RJControls.RJButton();
            this.author_input = new CustomControls.RJControls.RJTextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.author_grid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.author_grid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 102);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 236);
            this.panel2.TabIndex = 1;
            // 
            // author_grid
            // 
            this.author_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.author_grid.BackgroundColor = System.Drawing.Color.White;
            this.author_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.author_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.author_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.author_grid.Location = new System.Drawing.Point(0, 0);
            this.author_grid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.author_grid.Name = "author_grid";
            this.author_grid.RowHeadersWidth = 51;
            this.author_grid.RowTemplate.Height = 29;
            this.author_grid.Size = new System.Drawing.Size(700, 236);
            this.author_grid.TabIndex = 0;
            this.author_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.author_grid_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.author_validate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.author_btn);
            this.panel1.Controls.Add(this.author_input);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 102);
            this.panel1.TabIndex = 0;
            // 
            // author_validate
            // 
            this.author_validate.AutoSize = true;
            this.author_validate.Location = new System.Drawing.Point(23, 79);
            this.author_validate.Name = "author_validate";
            this.author_validate.Size = new System.Drawing.Size(0, 15);
            this.author_validate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // author_btn
            // 
            this.author_btn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.author_btn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.author_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.author_btn.BorderRadius = 0;
            this.author_btn.BorderSize = 0;
            this.author_btn.FlatAppearance.BorderSize = 0;
            this.author_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.author_btn.ForeColor = System.Drawing.Color.White;
            this.author_btn.Location = new System.Drawing.Point(305, 31);
            this.author_btn.Name = "author_btn";
            this.author_btn.Size = new System.Drawing.Size(150, 40);
            this.author_btn.TabIndex = 1;
            this.author_btn.Text = "Add";
            this.author_btn.TextColor = System.Drawing.Color.White;
            this.author_btn.UseVisualStyleBackColor = false;
            this.author_btn.Click += new System.EventHandler(this.author_btn_Click);
            // 
            // author_input
            // 
            this.author_input.BackColor = System.Drawing.SystemColors.Window;
            this.author_input.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.author_input.BorderFocusColor = System.Drawing.Color.HotPink;
            this.author_input.BorderSize = 2;
            this.author_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.author_input.ForeColor = System.Drawing.Color.DimGray;
            this.author_input.Location = new System.Drawing.Point(23, 40);
            this.author_input.Margin = new System.Windows.Forms.Padding(4);
            this.author_input.Multiline = false;
            this.author_input.Name = "author_input";
            this.author_input.Padding = new System.Windows.Forms.Padding(7);
            this.author_input.PasswordChar = false;
            this.author_input.Size = new System.Drawing.Size(250, 31);
            this.author_input.TabIndex = 0;
            this.author_input.Texts = "";
            this.author_input.UnderlinedStyle = true;
            // 
            // author
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "author";
            this.Text = "author";
            this.VisibleChanged += new System.EventHandler(this.author_VisibleChanged);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.author_grid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView author_grid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label author_validate;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton author_btn;
        private CustomControls.RJControls.RJTextBox author_input;
    }
}