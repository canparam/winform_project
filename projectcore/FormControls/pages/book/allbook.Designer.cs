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
            this.allBookSearch = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bookBtnSearch = new CustomControls.RJControls.RJButton();
            this.rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            this.tableAllBook = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BOOK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AUTHOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUBLISHER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISSUED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allBookSearch.SuspendLayout();
            this.tableAllBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // allBookSearch
            // 
            this.allBookSearch.Controls.Add(this.comboBox2);
            this.allBookSearch.Controls.Add(this.comboBox1);
            this.allBookSearch.Controls.Add(this.label1);
            this.allBookSearch.Controls.Add(this.bookBtnSearch);
            this.allBookSearch.Controls.Add(this.rjTextBox1);
            this.allBookSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.allBookSearch.Location = new System.Drawing.Point(0, 0);
            this.allBookSearch.Name = "allBookSearch";
            this.allBookSearch.Size = new System.Drawing.Size(981, 133);
            this.allBookSearch.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(534, 71);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 28);
            this.comboBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(353, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Book Name";
            // 
            // bookBtnSearch
            // 
            this.bookBtnSearch.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.bookBtnSearch.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.bookBtnSearch.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bookBtnSearch.BorderRadius = 0;
            this.bookBtnSearch.BorderSize = 0;
            this.bookBtnSearch.FlatAppearance.BorderSize = 0;
            this.bookBtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookBtnSearch.ForeColor = System.Drawing.Color.White;
            this.bookBtnSearch.Location = new System.Drawing.Point(781, 64);
            this.bookBtnSearch.Name = "bookBtnSearch";
            this.bookBtnSearch.Size = new System.Drawing.Size(188, 35);
            this.bookBtnSearch.TabIndex = 1;
            this.bookBtnSearch.Text = "Search";
            this.bookBtnSearch.TextColor = System.Drawing.Color.White;
            this.bookBtnSearch.UseVisualStyleBackColor = false;
            this.bookBtnSearch.Click += new System.EventHandler(this.bookBtnSearch_Click);
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.rjTextBox1.Location = new System.Drawing.Point(13, 64);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.Size = new System.Drawing.Size(323, 35);
            this.rjTextBox1.TabIndex = 0;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = true;
            // 
            // tableAllBook
            // 
            this.tableAllBook.Controls.Add(this.dataGridView1);
            this.tableAllBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableAllBook.Location = new System.Drawing.Point(0, 133);
            this.tableAllBook.Name = "tableAllBook";
            this.tableAllBook.Size = new System.Drawing.Size(981, 412);
            this.tableAllBook.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BOOK,
            this.AUTHOR,
            this.PUBLISHER,
            this.QUANTITY,
            this.ISSUED,
            this.ACTION});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(981, 412);
            this.dataGridView1.TabIndex = 0;
            // 
            // BOOK
            // 
            this.BOOK.HeaderText = "BOOK";
            this.BOOK.MinimumWidth = 6;
            this.BOOK.Name = "BOOK";
            // 
            // AUTHOR
            // 
            this.AUTHOR.HeaderText = "AUTHOR";
            this.AUTHOR.MinimumWidth = 6;
            this.AUTHOR.Name = "AUTHOR";
            // 
            // PUBLISHER
            // 
            this.PUBLISHER.HeaderText = "PUBLISHER";
            this.PUBLISHER.MinimumWidth = 6;
            this.PUBLISHER.Name = "PUBLISHER";
            // 
            // QUANTITY
            // 
            this.QUANTITY.HeaderText = "QUANTITY";
            this.QUANTITY.MinimumWidth = 6;
            this.QUANTITY.Name = "QUANTITY";
            // 
            // ISSUED
            // 
            this.ISSUED.HeaderText = "ISSUED";
            this.ISSUED.MinimumWidth = 6;
            this.ISSUED.Name = "ISSUED";
            // 
            // ACTION
            // 
            this.ACTION.HeaderText = "ACTION";
            this.ACTION.MinimumWidth = 6;
            this.ACTION.Name = "ACTION";
            // 
            // allbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(981, 545);
            this.Controls.Add(this.tableAllBook);
            this.Controls.Add(this.allBookSearch);
            this.Name = "allbook";
            this.Text = "allbook";
            this.allBookSearch.ResumeLayout(false);
            this.allBookSearch.PerformLayout();
            this.tableAllBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel allBookSearch;
        private System.Windows.Forms.Panel tableAllBook;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn AUTHOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUBLISHER;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISSUED;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACTION;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton bookBtnSearch;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}