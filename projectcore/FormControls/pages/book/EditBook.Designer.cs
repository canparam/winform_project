
namespace projectcore.FormControls.pages.book
{
    partial class EditBook
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
            this.btn_save_edit_book = new CustomControls.RJControls.RJButton();
            this.add_publisher = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.edit_book_status = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bookisbn_validate = new System.Windows.Forms.Label();
            this.bookquantity_validate = new System.Windows.Forms.Label();
            this.bookname_validate = new System.Windows.Forms.Label();
            this.add_Book_btn = new CustomControls.RJControls.RJButton();
            this.label8 = new System.Windows.Forms.Label();
            this.add_genre = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.add_author = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.add_Book_Quantity = new CustomControls.RJControls.RJTextBox();
            this.add_Book_Des = new CustomControls.RJControls.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.add_Book_Year = new CustomControls.RJControls.RJTextBox();
            this.add_Book_ISBN = new CustomControls.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.add_Book_Name = new CustomControls.RJControls.RJTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_save_edit_book
            // 
            this.btn_save_edit_book.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save_edit_book.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_save_edit_book.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_save_edit_book.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_save_edit_book.BorderRadius = 0;
            this.btn_save_edit_book.BorderSize = 0;
            this.btn_save_edit_book.FlatAppearance.BorderSize = 0;
            this.btn_save_edit_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_edit_book.ForeColor = System.Drawing.Color.White;
            this.btn_save_edit_book.Location = new System.Drawing.Point(543, 269);
            this.btn_save_edit_book.Name = "btn_save_edit_book";
            this.btn_save_edit_book.Size = new System.Drawing.Size(150, 40);
            this.btn_save_edit_book.TabIndex = 0;
            this.btn_save_edit_book.Text = "Save";
            this.btn_save_edit_book.TextColor = System.Drawing.Color.White;
            this.btn_save_edit_book.UseVisualStyleBackColor = false;
            this.btn_save_edit_book.Click += new System.EventHandler(this.btn_save_edit_book_Click);
            // 
            // add_publisher
            // 
            this.add_publisher.FormattingEnabled = true;
            this.add_publisher.Location = new System.Drawing.Point(261, 199);
            this.add_publisher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_publisher.Name = "add_publisher";
            this.add_publisher.Size = new System.Drawing.Size(210, 23);
            this.add_publisher.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.edit_book_status);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.bookisbn_validate);
            this.panel1.Controls.Add(this.bookquantity_validate);
            this.panel1.Controls.Add(this.bookname_validate);
            this.panel1.Controls.Add(this.add_Book_btn);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.add_publisher);
            this.panel1.Controls.Add(this.add_genre);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.add_author);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.add_Book_Quantity);
            this.panel1.Controls.Add(this.add_Book_Des);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.add_Book_Year);
            this.panel1.Controls.Add(this.add_Book_ISBN);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.add_Book_Name);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 252);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // edit_book_status
            // 
            this.edit_book_status.FormattingEnabled = true;
            this.edit_book_status.Location = new System.Drawing.Point(514, 111);
            this.edit_book_status.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edit_book_status.Name = "edit_book_status";
            this.edit_book_status.Size = new System.Drawing.Size(210, 23);
            this.edit_book_status.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(514, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 15);
            this.label12.TabIndex = 25;
            this.label12.Text = "Status";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(49, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "(*)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(543, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "(*)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(77, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "(*)";
            // 
            // bookisbn_validate
            // 
            this.bookisbn_validate.AutoSize = true;
            this.bookisbn_validate.ForeColor = System.Drawing.Color.Red;
            this.bookisbn_validate.Location = new System.Drawing.Point(13, 138);
            this.bookisbn_validate.Name = "bookisbn_validate";
            this.bookisbn_validate.Size = new System.Drawing.Size(0, 15);
            this.bookisbn_validate.TabIndex = 21;
            // 
            // bookquantity_validate
            // 
            this.bookquantity_validate.AutoSize = true;
            this.bookquantity_validate.ForeColor = System.Drawing.Color.Red;
            this.bookquantity_validate.Location = new System.Drawing.Point(484, 59);
            this.bookquantity_validate.Name = "bookquantity_validate";
            this.bookquantity_validate.Size = new System.Drawing.Size(0, 15);
            this.bookquantity_validate.TabIndex = 20;
            // 
            // bookname_validate
            // 
            this.bookname_validate.AutoSize = true;
            this.bookname_validate.ForeColor = System.Drawing.Color.Red;
            this.bookname_validate.Location = new System.Drawing.Point(11, 60);
            this.bookname_validate.Name = "bookname_validate";
            this.bookname_validate.Size = new System.Drawing.Size(0, 15);
            this.bookname_validate.TabIndex = 19;
            // 
            // add_Book_btn
            // 
            this.add_Book_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.add_Book_btn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.add_Book_btn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.add_Book_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.add_Book_btn.BorderRadius = 0;
            this.add_Book_btn.BorderSize = 0;
            this.add_Book_btn.FlatAppearance.BorderSize = 0;
            this.add_Book_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_Book_btn.ForeColor = System.Drawing.Color.White;
            this.add_Book_btn.Location = new System.Drawing.Point(1097, 326);
            this.add_Book_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_Book_btn.Name = "add_Book_btn";
            this.add_Book_btn.Size = new System.Drawing.Size(149, 32);
            this.add_Book_btn.TabIndex = 18;
            this.add_Book_btn.Text = "Add";
            this.add_Book_btn.TextColor = System.Drawing.Color.White;
            this.add_Book_btn.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Publisher";
            // 
            // add_genre
            // 
            this.add_genre.FormattingEnabled = true;
            this.add_genre.Location = new System.Drawing.Point(11, 199);
            this.add_genre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_genre.Name = "add_genre";
            this.add_genre.Size = new System.Drawing.Size(210, 23);
            this.add_genre.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Genre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(509, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Author";
            // 
            // add_author
            // 
            this.add_author.FormattingEnabled = true;
            this.add_author.Location = new System.Drawing.Point(514, 199);
            this.add_author.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_author.Name = "add_author";
            this.add_author.Size = new System.Drawing.Size(210, 23);
            this.add_author.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(514, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quantity";
            // 
            // add_Book_Quantity
            // 
            this.add_Book_Quantity.BackColor = System.Drawing.SystemColors.Window;
            this.add_Book_Quantity.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.add_Book_Quantity.BorderFocusColor = System.Drawing.Color.HotPink;
            this.add_Book_Quantity.BorderSize = 2;
            this.add_Book_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_Book_Quantity.ForeColor = System.Drawing.Color.DimGray;
            this.add_Book_Quantity.Location = new System.Drawing.Point(514, 25);
            this.add_Book_Quantity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.add_Book_Quantity.Multiline = false;
            this.add_Book_Quantity.Name = "add_Book_Quantity";
            this.add_Book_Quantity.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.add_Book_Quantity.PasswordChar = false;
            this.add_Book_Quantity.Size = new System.Drawing.Size(210, 27);
            this.add_Book_Quantity.TabIndex = 8;
            this.add_Book_Quantity.Texts = "";
            this.add_Book_Quantity.UnderlinedStyle = true;
            // 
            // add_Book_Des
            // 
            this.add_Book_Des.BackColor = System.Drawing.SystemColors.Window;
            this.add_Book_Des.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.add_Book_Des.BorderFocusColor = System.Drawing.Color.HotPink;
            this.add_Book_Des.BorderSize = 2;
            this.add_Book_Des.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_Book_Des.ForeColor = System.Drawing.Color.DimGray;
            this.add_Book_Des.Location = new System.Drawing.Point(261, 107);
            this.add_Book_Des.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.add_Book_Des.Multiline = false;
            this.add_Book_Des.Name = "add_Book_Des";
            this.add_Book_Des.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.add_Book_Des.PasswordChar = false;
            this.add_Book_Des.Size = new System.Drawing.Size(210, 27);
            this.add_Book_Des.TabIndex = 7;
            this.add_Book_Des.Texts = "";
            this.add_Book_Des.UnderlinedStyle = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Published Year ";
            // 
            // add_Book_Year
            // 
            this.add_Book_Year.BackColor = System.Drawing.SystemColors.Window;
            this.add_Book_Year.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.add_Book_Year.BorderFocusColor = System.Drawing.Color.HotPink;
            this.add_Book_Year.BorderSize = 2;
            this.add_Book_Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_Book_Year.ForeColor = System.Drawing.Color.DimGray;
            this.add_Book_Year.Location = new System.Drawing.Point(261, 25);
            this.add_Book_Year.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.add_Book_Year.Multiline = false;
            this.add_Book_Year.Name = "add_Book_Year";
            this.add_Book_Year.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.add_Book_Year.PasswordChar = false;
            this.add_Book_Year.Size = new System.Drawing.Size(210, 27);
            this.add_Book_Year.TabIndex = 4;
            this.add_Book_Year.Texts = "";
            this.add_Book_Year.UnderlinedStyle = true;
            // 
            // add_Book_ISBN
            // 
            this.add_Book_ISBN.BackColor = System.Drawing.SystemColors.Window;
            this.add_Book_ISBN.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.add_Book_ISBN.BorderFocusColor = System.Drawing.Color.HotPink;
            this.add_Book_ISBN.BorderSize = 2;
            this.add_Book_ISBN.Enabled = false;
            this.add_Book_ISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_Book_ISBN.ForeColor = System.Drawing.Color.DimGray;
            this.add_Book_ISBN.Location = new System.Drawing.Point(11, 107);
            this.add_Book_ISBN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.add_Book_ISBN.Multiline = false;
            this.add_Book_ISBN.Name = "add_Book_ISBN";
            this.add_Book_ISBN.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.add_Book_ISBN.PasswordChar = false;
            this.add_Book_ISBN.Size = new System.Drawing.Size(210, 27);
            this.add_Book_ISBN.TabIndex = 3;
            this.add_Book_ISBN.Texts = "";
            this.add_Book_ISBN.UnderlinedStyle = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "ISBN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Name";
            // 
            // add_Book_Name
            // 
            this.add_Book_Name.BackColor = System.Drawing.SystemColors.Window;
            this.add_Book_Name.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.add_Book_Name.BorderFocusColor = System.Drawing.Color.HotPink;
            this.add_Book_Name.BorderSize = 2;
            this.add_Book_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_Book_Name.ForeColor = System.Drawing.Color.DimGray;
            this.add_Book_Name.Location = new System.Drawing.Point(11, 25);
            this.add_Book_Name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.add_Book_Name.Multiline = false;
            this.add_Book_Name.Name = "add_Book_Name";
            this.add_Book_Name.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.add_Book_Name.PasswordChar = false;
            this.add_Book_Name.Size = new System.Drawing.Size(210, 27);
            this.add_Book_Name.TabIndex = 0;
            this.add_Book_Name.Texts = "";
            this.add_Book_Name.UnderlinedStyle = true;
            // 
            // EditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(752, 321);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_save_edit_book);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditBook";
            this.Text = "Edit Book";
            this.VisibleChanged += new System.EventHandler(this.EditBook_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJButton btn_save_edit_book;
        private System.Windows.Forms.ComboBox add_publisher;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox edit_book_status;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label bookisbn_validate;
        private System.Windows.Forms.Label bookquantity_validate;
        private System.Windows.Forms.Label bookname_validate;
        private CustomControls.RJControls.RJButton add_Book_btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox add_genre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox add_author;
        private System.Windows.Forms.Label label5;
        private CustomControls.RJControls.RJTextBox add_Book_Quantity;
        private CustomControls.RJControls.RJTextBox add_Book_Des;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJTextBox add_Book_Year;
        private CustomControls.RJControls.RJTextBox add_Book_ISBN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJTextBox add_Book_Name;
    }
}