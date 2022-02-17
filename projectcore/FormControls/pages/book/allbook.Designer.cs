namespace projectcore.FormControls.pages
{
    partial class allbook
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
            this.label3 = new System.Windows.Forms.Label();
            this.all_book_pub = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.all_book_author = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.all_book_input = new CustomControls.RJControls.RJTextBox();
            this.book_btn_search = new CustomControls.RJControls.RJButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.list_book = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_book)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.all_book_pub);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.all_book_author);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.all_book_input);
            this.panel1.Controls.Add(this.book_btn_search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 105);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Publisher";
            // 
            // all_book_pub
            // 
            this.all_book_pub.FormattingEnabled = true;
            this.all_book_pub.Location = new System.Drawing.Point(426, 50);
            this.all_book_pub.Name = "all_book_pub";
            this.all_book_pub.Size = new System.Drawing.Size(165, 23);
            this.all_book_pub.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Author";
            // 
            // all_book_author
            // 
            this.all_book_author.FormattingEnabled = true;
            this.all_book_author.Location = new System.Drawing.Point(232, 50);
            this.all_book_author.Name = "all_book_author";
            this.all_book_author.Size = new System.Drawing.Size(167, 23);
            this.all_book_author.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Book name";
            // 
            // all_book_input
            // 
            this.all_book_input.BackColor = System.Drawing.SystemColors.Window;
            this.all_book_input.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.all_book_input.BorderFocusColor = System.Drawing.Color.HotPink;
            this.all_book_input.BorderSize = 2;
            this.all_book_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.all_book_input.ForeColor = System.Drawing.Color.DimGray;
            this.all_book_input.Location = new System.Drawing.Point(13, 42);
            this.all_book_input.Margin = new System.Windows.Forms.Padding(4);
            this.all_book_input.Multiline = false;
            this.all_book_input.Name = "all_book_input";
            this.all_book_input.Padding = new System.Windows.Forms.Padding(7);
            this.all_book_input.PasswordChar = false;
            this.all_book_input.Size = new System.Drawing.Size(200, 31);
            this.all_book_input.TabIndex = 1;
            this.all_book_input.Texts = "";
            this.all_book_input.UnderlinedStyle = true;
            // 
            // book_btn_search
            // 
            this.book_btn_search.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.book_btn_search.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.book_btn_search.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.book_btn_search.BorderRadius = 0;
            this.book_btn_search.BorderSize = 0;
            this.book_btn_search.FlatAppearance.BorderSize = 0;
            this.book_btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.book_btn_search.ForeColor = System.Drawing.Color.White;
            this.book_btn_search.Location = new System.Drawing.Point(634, 33);
            this.book_btn_search.Name = "book_btn_search";
            this.book_btn_search.Size = new System.Drawing.Size(150, 40);
            this.book_btn_search.TabIndex = 0;
            this.book_btn_search.Text = " Search";
            this.book_btn_search.TextColor = System.Drawing.Color.White;
            this.book_btn_search.UseVisualStyleBackColor = false;
            this.book_btn_search.Click += new System.EventHandler(this.book_btn_search_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.list_book);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(892, 304);
            this.panel2.TabIndex = 1;
            // 
            // list_book
            // 
            this.list_book.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.list_book.BackgroundColor = System.Drawing.Color.White;
            this.list_book.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_book.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_book.Location = new System.Drawing.Point(0, 0);
            this.list_book.Name = "list_book";
            this.list_book.RowTemplate.Height = 25;
            this.list_book.Size = new System.Drawing.Size(892, 304);
            this.list_book.TabIndex = 0;
            this.list_book.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.list_book_CellClick);
            this.list_book.VisibleChanged += new System.EventHandler(this.list_book_VisibleChanged);
            // 
            // allbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(892, 409);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "allbook";
            this.Text = "allbook";
            this.VisibleChanged += new System.EventHandler(this.allbook_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.list_book)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView list_book;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox all_book_pub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox all_book_author;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJTextBox all_book_input;
        private CustomControls.RJControls.RJButton book_btn_search;
    }
}