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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.subMenu_user = new System.Windows.Forms.Panel();
            this.btn_add_user = new System.Windows.Forms.Button();
            this.btn_list_user = new System.Windows.Forms.Button();
            this.btn_user = new System.Windows.Forms.Button();
            this.submenu_Issua = new System.Windows.Forms.Panel();
            this.add_issua = new System.Windows.Forms.Button();
            this.list_issua = new System.Windows.Forms.Button();
            this.btn_isssue_Book = new System.Windows.Forms.Button();
            this.subMenu_Books = new System.Windows.Forms.Panel();
            this.genres_Book_btn = new System.Windows.Forms.Button();
            this.author_Book_btn = new System.Windows.Forms.Button();
            this.pub_Book_btn = new System.Windows.Forms.Button();
            this.add_Book_btn = new System.Windows.Forms.Button();
            this.all_Book_btn = new System.Windows.Forms.Button();
            this.btn_books = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.leftPanel.SuspendLayout();
            this.subMenu_user.SuspendLayout();
            this.submenu_Issua.SuspendLayout();
            this.subMenu_Books.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.AutoScroll = true;
            this.leftPanel.BackColor = System.Drawing.Color.White;
            this.leftPanel.Controls.Add(this.subMenu_user);
            this.leftPanel.Controls.Add(this.btn_user);
            this.leftPanel.Controls.Add(this.submenu_Issua);
            this.leftPanel.Controls.Add(this.btn_isssue_Book);
            this.leftPanel.Controls.Add(this.subMenu_Books);
            this.leftPanel.Controls.Add(this.btn_books);
            this.leftPanel.Controls.Add(this.btn_dashboard);
            this.leftPanel.Controls.Add(this.panel1);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(188, 666);
            this.leftPanel.TabIndex = 0;
            // 
            // subMenu_user
            // 
            this.subMenu_user.Controls.Add(this.btn_add_user);
            this.subMenu_user.Controls.Add(this.btn_list_user);
            this.subMenu_user.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenu_user.Location = new System.Drawing.Point(0, 659);
            this.subMenu_user.Name = "subMenu_user";
            this.subMenu_user.Size = new System.Drawing.Size(167, 103);
            this.subMenu_user.TabIndex = 7;
            // 
            // btn_add_user
            // 
            this.btn_add_user.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_add_user.FlatAppearance.BorderSize = 0;
            this.btn_add_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_user.Location = new System.Drawing.Point(0, 50);
            this.btn_add_user.Name = "btn_add_user";
            this.btn_add_user.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_add_user.Size = new System.Drawing.Size(167, 50);
            this.btn_add_user.TabIndex = 1;
            this.btn_add_user.Text = "Add User";
            this.btn_add_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_user.UseVisualStyleBackColor = true;
            this.btn_add_user.Click += new System.EventHandler(this.btn_add_user_Click);
            // 
            // btn_list_user
            // 
            this.btn_list_user.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_list_user.FlatAppearance.BorderSize = 0;
            this.btn_list_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_list_user.Location = new System.Drawing.Point(0, 0);
            this.btn_list_user.Name = "btn_list_user";
            this.btn_list_user.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_list_user.Size = new System.Drawing.Size(167, 50);
            this.btn_list_user.TabIndex = 0;
            this.btn_list_user.Text = "List Users";
            this.btn_list_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_list_user.UseVisualStyleBackColor = true;
            this.btn_list_user.Click += new System.EventHandler(this.btn_list_user_Click);
            // 
            // btn_user
            // 
            this.btn_user.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_user.FlatAppearance.BorderSize = 0;
            this.btn_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_user.Location = new System.Drawing.Point(0, 609);
            this.btn_user.Name = "btn_user";
            this.btn_user.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_user.Size = new System.Drawing.Size(167, 50);
            this.btn_user.TabIndex = 6;
            this.btn_user.Text = "Users";
            this.btn_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_user.UseVisualStyleBackColor = true;
            this.btn_user.Click += new System.EventHandler(this.btn_user_Click);
            // 
            // submenu_Issua
            // 
            this.submenu_Issua.Controls.Add(this.add_issua);
            this.submenu_Issua.Controls.Add(this.list_issua);
            this.submenu_Issua.Dock = System.Windows.Forms.DockStyle.Top;
            this.submenu_Issua.Location = new System.Drawing.Point(0, 508);
            this.submenu_Issua.Name = "submenu_Issua";
            this.submenu_Issua.Size = new System.Drawing.Size(167, 101);
            this.submenu_Issua.TabIndex = 5;
            // 
            // add_issua
            // 
            this.add_issua.Dock = System.Windows.Forms.DockStyle.Top;
            this.add_issua.FlatAppearance.BorderSize = 0;
            this.add_issua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_issua.Location = new System.Drawing.Point(0, 50);
            this.add_issua.Name = "add_issua";
            this.add_issua.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.add_issua.Size = new System.Drawing.Size(167, 50);
            this.add_issua.TabIndex = 1;
            this.add_issua.Text = "Add new";
            this.add_issua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_issua.UseVisualStyleBackColor = true;
            this.add_issua.Click += new System.EventHandler(this.add_issua_Click);
            // 
            // list_issua
            // 
            this.list_issua.Dock = System.Windows.Forms.DockStyle.Top;
            this.list_issua.FlatAppearance.BorderSize = 0;
            this.list_issua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.list_issua.Location = new System.Drawing.Point(0, 0);
            this.list_issua.Name = "list_issua";
            this.list_issua.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.list_issua.Size = new System.Drawing.Size(167, 50);
            this.list_issua.TabIndex = 0;
            this.list_issua.Text = "List";
            this.list_issua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.list_issua.UseVisualStyleBackColor = true;
            this.list_issua.Click += new System.EventHandler(this.list_issua_Click);
            // 
            // btn_isssue_Book
            // 
            this.btn_isssue_Book.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_isssue_Book.FlatAppearance.BorderSize = 0;
            this.btn_isssue_Book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_isssue_Book.Location = new System.Drawing.Point(0, 458);
            this.btn_isssue_Book.Name = "btn_isssue_Book";
            this.btn_isssue_Book.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_isssue_Book.Size = new System.Drawing.Size(167, 50);
            this.btn_isssue_Book.TabIndex = 4;
            this.btn_isssue_Book.Text = "Issued Books";
            this.btn_isssue_Book.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_isssue_Book.UseVisualStyleBackColor = true;
            this.btn_isssue_Book.Click += new System.EventHandler(this.btn_isssue_Book_Click);
            // 
            // subMenu_Books
            // 
            this.subMenu_Books.Controls.Add(this.genres_Book_btn);
            this.subMenu_Books.Controls.Add(this.author_Book_btn);
            this.subMenu_Books.Controls.Add(this.pub_Book_btn);
            this.subMenu_Books.Controls.Add(this.add_Book_btn);
            this.subMenu_Books.Controls.Add(this.all_Book_btn);
            this.subMenu_Books.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenu_Books.Location = new System.Drawing.Point(0, 203);
            this.subMenu_Books.Name = "subMenu_Books";
            this.subMenu_Books.Size = new System.Drawing.Size(167, 255);
            this.subMenu_Books.TabIndex = 3;
            // 
            // genres_Book_btn
            // 
            this.genres_Book_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.genres_Book_btn.FlatAppearance.BorderSize = 0;
            this.genres_Book_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.genres_Book_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genres_Book_btn.Location = new System.Drawing.Point(0, 200);
            this.genres_Book_btn.Name = "genres_Book_btn";
            this.genres_Book_btn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.genres_Book_btn.Size = new System.Drawing.Size(167, 50);
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
            this.author_Book_btn.Location = new System.Drawing.Point(0, 150);
            this.author_Book_btn.Name = "author_Book_btn";
            this.author_Book_btn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.author_Book_btn.Size = new System.Drawing.Size(167, 50);
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
            this.pub_Book_btn.Location = new System.Drawing.Point(0, 100);
            this.pub_Book_btn.Name = "pub_Book_btn";
            this.pub_Book_btn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.pub_Book_btn.Size = new System.Drawing.Size(167, 50);
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
            this.add_Book_btn.Location = new System.Drawing.Point(0, 50);
            this.add_Book_btn.Name = "add_Book_btn";
            this.add_Book_btn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.add_Book_btn.Size = new System.Drawing.Size(167, 50);
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
            this.all_Book_btn.Size = new System.Drawing.Size(167, 50);
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
            this.btn_books.Location = new System.Drawing.Point(0, 153);
            this.btn_books.Name = "btn_books";
            this.btn_books.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_books.Size = new System.Drawing.Size(167, 50);
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
            this.btn_dashboard.Location = new System.Drawing.Point(0, 103);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_dashboard.Size = new System.Drawing.Size(167, 50);
            this.btn_dashboard.TabIndex = 1;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.UseVisualStyleBackColor = true;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 103);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 90);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.pictureBox2);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(188, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(5);
            this.panelMain.Size = new System.Drawing.Size(746, 666);
            this.panelMain.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(5, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(736, 656);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 666);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.leftPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Main";
            this.Text = "Main";
            this.leftPanel.ResumeLayout(false);
            this.subMenu_user.ResumeLayout(false);
            this.submenu_Issua.ResumeLayout(false);
            this.subMenu_Books.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Button btn_isssue_Book;
        private System.Windows.Forms.Panel submenu_Issua;
        private System.Windows.Forms.Button add_issua;
        private System.Windows.Forms.Button list_issua;
        private System.Windows.Forms.Button btn_user;
        private System.Windows.Forms.Panel subMenu_user;
        private System.Windows.Forms.Button btn_add_user;
        private System.Windows.Forms.Button btn_list_user;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}