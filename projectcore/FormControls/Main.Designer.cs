namespace projectcore.FormControls
{
    partial class Main
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
            this.leftPanel = new System.Windows.Forms.Panel();
            this.subMenu_Books = new System.Windows.Forms.Panel();
            this.genres_Book_btn = new System.Windows.Forms.Button();
            this.author_Book_btn = new System.Windows.Forms.Button();
            this.pub_Book_btn = new System.Windows.Forms.Button();
            this.add_Book_btn = new System.Windows.Forms.Button();
            this.all_Book_btn = new System.Windows.Forms.Button();
            this.btn_books = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.leftPanel.SuspendLayout();
            this.subMenu_Books.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.AutoScroll = true;
            this.leftPanel.BackColor = System.Drawing.Color.White;
            this.leftPanel.Controls.Add(this.subMenu_Books);
            this.leftPanel.Controls.Add(this.btn_books);
            this.leftPanel.Controls.Add(this.btn_dashboard);
            this.leftPanel.Controls.Add(this.panel1);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(188, 561);
            this.leftPanel.TabIndex = 0;
            // 
            // subMenu_Books
            // 
            this.subMenu_Books.Controls.Add(this.genres_Book_btn);
            this.subMenu_Books.Controls.Add(this.author_Book_btn);
            this.subMenu_Books.Controls.Add(this.pub_Book_btn);
            this.subMenu_Books.Controls.Add(this.add_Book_btn);
            this.subMenu_Books.Controls.Add(this.all_Book_btn);
            this.subMenu_Books.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenu_Books.Location = new System.Drawing.Point(0, 166);
            this.subMenu_Books.Name = "subMenu_Books";
            this.subMenu_Books.Size = new System.Drawing.Size(188, 178);
            this.subMenu_Books.TabIndex = 3;
            // 
            // genres_Book_btn
            // 
            this.genres_Book_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.genres_Book_btn.FlatAppearance.BorderSize = 0;
            this.genres_Book_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.genres_Book_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genres_Book_btn.Location = new System.Drawing.Point(0, 140);
            this.genres_Book_btn.Name = "genres_Book_btn";
            this.genres_Book_btn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.genres_Book_btn.Size = new System.Drawing.Size(188, 35);
            this.genres_Book_btn.TabIndex = 4;
            this.genres_Book_btn.Text = "Genres";
            this.genres_Book_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.genres_Book_btn.UseVisualStyleBackColor = true;
            this.genres_Book_btn.Click += new System.EventHandler(this.genres_Book_btn_Click);
            // 
            // author_Book_btn
            // 
            this.author_Book_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.author_Book_btn.FlatAppearance.BorderSize = 0;
            this.author_Book_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.author_Book_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.author_Book_btn.Location = new System.Drawing.Point(0, 105);
            this.author_Book_btn.Name = "author_Book_btn";
            this.author_Book_btn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.author_Book_btn.Size = new System.Drawing.Size(188, 35);
            this.author_Book_btn.TabIndex = 3;
            this.author_Book_btn.Text = "Authors";
            this.author_Book_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.author_Book_btn.UseVisualStyleBackColor = true;
            this.author_Book_btn.Click += new System.EventHandler(this.author_Book_btn_Click);
            // 
            // pub_Book_btn
            // 
            this.pub_Book_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pub_Book_btn.FlatAppearance.BorderSize = 0;
            this.pub_Book_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pub_Book_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pub_Book_btn.Location = new System.Drawing.Point(0, 70);
            this.pub_Book_btn.Name = "pub_Book_btn";
            this.pub_Book_btn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.pub_Book_btn.Size = new System.Drawing.Size(188, 35);
            this.pub_Book_btn.TabIndex = 2;
            this.pub_Book_btn.Text = "Publishers";
            this.pub_Book_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pub_Book_btn.UseVisualStyleBackColor = true;
            this.pub_Book_btn.Click += new System.EventHandler(this.pub_Book_btn_Click);
            // 
            // add_Book_btn
            // 
            this.add_Book_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.add_Book_btn.FlatAppearance.BorderSize = 0;
            this.add_Book_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.add_Book_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_Book_btn.Location = new System.Drawing.Point(0, 35);
            this.add_Book_btn.Name = "add_Book_btn";
            this.add_Book_btn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.add_Book_btn.Size = new System.Drawing.Size(188, 35);
            this.add_Book_btn.TabIndex = 1;
            this.add_Book_btn.Text = "Add Book";
            this.add_Book_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_Book_btn.UseVisualStyleBackColor = true;
            this.add_Book_btn.Click += new System.EventHandler(this.add_Book_btn_Click);
            // 
            // all_Book_btn
            // 
            this.all_Book_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.all_Book_btn.FlatAppearance.BorderSize = 0;
            this.all_Book_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.all_Book_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.all_Book_btn.Location = new System.Drawing.Point(0, 0);
            this.all_Book_btn.Name = "all_Book_btn";
            this.all_Book_btn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.all_Book_btn.Size = new System.Drawing.Size(188, 35);
            this.all_Book_btn.TabIndex = 0;
            this.all_Book_btn.Text = "All Books";
            this.all_Book_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.all_Book_btn.UseVisualStyleBackColor = true;
            this.all_Book_btn.Click += new System.EventHandler(this.all_Book_btn_Click);
            // 
            // btn_books
            // 
            this.btn_books.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_books.FlatAppearance.BorderSize = 0;
            this.btn_books.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.btn_books.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.btn_books.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_books.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_books.Location = new System.Drawing.Point(0, 131);
            this.btn_books.Name = "btn_books";
            this.btn_books.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_books.Size = new System.Drawing.Size(188, 35);
            this.btn_books.TabIndex = 2;
            this.btn_books.Text = "Books";
            this.btn_books.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_books.UseVisualStyleBackColor = true;
            this.btn_books.Click += new System.EventHandler(this.btn_books_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dashboard.FlatAppearance.BorderSize = 0;
            this.btn_dashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.btn_dashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashboard.Location = new System.Drawing.Point(0, 96);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_dashboard.Size = new System.Drawing.Size(188, 35);
            this.btn_dashboard.TabIndex = 1;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.UseVisualStyleBackColor = true;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 96);
            this.panel1.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.leftPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Main";
            this.Text = "Main";
            this.leftPanel.ResumeLayout(false);
            this.subMenu_Books.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel subMenu_Books;
        private System.Windows.Forms.Button all_Book_btn;
        private System.Windows.Forms.Button btn_books;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button genres_Book_btn;
        private System.Windows.Forms.Button author_Book_btn;
        private System.Windows.Forms.Button pub_Book_btn;
        private System.Windows.Forms.Button add_Book_btn;
    }
}