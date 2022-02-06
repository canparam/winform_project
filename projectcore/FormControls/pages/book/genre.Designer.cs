﻿namespace projectcore.FormControls.pages.book
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.authorAddbtn = new CustomControls.RJControls.RJButton();
            this.author_input_add = new CustomControls.RJControls.RJTextBox();
            this.genre_btn_search = new CustomControls.RJControls.RJButton();
            this.Sort = new System.Windows.Forms.Label();
            this.genre_sort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.genreSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre_created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreUpdated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.genre_search_input = new CustomControls.RJControls.RJTextBox();
            this.genre_add_btn = new CustomControls.RJControls.RJButton();
            this.genre_input = new CustomControls.RJControls.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.genreSTT,
            this.genreName,
            this.genre_created,
            this.genreUpdated,
            this.genreAction});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(815, 314);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(815, 314);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // authorAddbtn
            // 
            this.authorAddbtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.authorAddbtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.authorAddbtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.authorAddbtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.authorAddbtn.BorderRadius = 0;
            this.authorAddbtn.BorderSize = 0;
            this.authorAddbtn.FlatAppearance.BorderSize = 0;
            this.authorAddbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authorAddbtn.ForeColor = System.Drawing.Color.White;
            this.authorAddbtn.Location = new System.Drawing.Point(923, 120);
            this.authorAddbtn.Name = "authorAddbtn";
            this.authorAddbtn.Size = new System.Drawing.Size(178, 40);
            this.authorAddbtn.TabIndex = 1;
            this.authorAddbtn.Text = "Add";
            this.authorAddbtn.TextColor = System.Drawing.Color.White;
            this.authorAddbtn.UseVisualStyleBackColor = false;
            // 
            // author_input_add
            // 
            this.author_input_add.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.author_input_add.BackColor = System.Drawing.SystemColors.Window;
            this.author_input_add.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.author_input_add.BorderFocusColor = System.Drawing.Color.HotPink;
            this.author_input_add.BorderSize = 2;
            this.author_input_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.author_input_add.ForeColor = System.Drawing.Color.DimGray;
            this.author_input_add.Location = new System.Drawing.Point(779, 78);
            this.author_input_add.Margin = new System.Windows.Forms.Padding(4);
            this.author_input_add.Multiline = false;
            this.author_input_add.Name = "author_input_add";
            this.author_input_add.Padding = new System.Windows.Forms.Padding(7);
            this.author_input_add.PasswordChar = false;
            this.author_input_add.Size = new System.Drawing.Size(322, 35);
            this.author_input_add.TabIndex = 0;
            this.author_input_add.Texts = "";
            this.author_input_add.UnderlinedStyle = true;
            // 
            // genre_btn_search
            // 
            this.genre_btn_search.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.genre_btn_search.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.genre_btn_search.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.genre_btn_search.BorderRadius = 0;
            this.genre_btn_search.BorderSize = 0;
            this.genre_btn_search.FlatAppearance.BorderSize = 0;
            this.genre_btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genre_btn_search.ForeColor = System.Drawing.Color.White;
            this.genre_btn_search.Location = new System.Drawing.Point(252, 84);
            this.genre_btn_search.Name = "genre_btn_search";
            this.genre_btn_search.Size = new System.Drawing.Size(178, 40);
            this.genre_btn_search.TabIndex = 4;
            this.genre_btn_search.Text = "Search";
            this.genre_btn_search.TextColor = System.Drawing.Color.White;
            this.genre_btn_search.UseVisualStyleBackColor = false;
            // 
            // Sort
            // 
            this.Sort.AutoSize = true;
            this.Sort.Location = new System.Drawing.Point(252, 9);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(36, 20);
            this.Sort.TabIndex = 3;
            this.Sort.Text = "Sort";
            // 
            // genre_sort
            // 
            this.genre_sort.FormattingEnabled = true;
            this.genre_sort.Location = new System.Drawing.Point(252, 49);
            this.genre_sort.Name = "genre_sort";
            this.genre_sort.Size = new System.Drawing.Size(179, 28);
            this.genre_sort.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.genre_btn_search);
            this.panel4.Controls.Add(this.Sort);
            this.panel4.Controls.Add(this.genre_sort);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.genre_search_input);
            this.panel4.Location = new System.Drawing.Point(357, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1058, 172);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.genre_add_btn);
            this.panel3.Controls.Add(this.genre_input);
            this.panel3.Controls.Add(this.rjButton1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.authorAddbtn);
            this.panel3.Controls.Add(this.author_input_add);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(966, 172);
            this.panel3.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 136);
            this.panel1.TabIndex = 2;
            // 
            // genreSTT
            // 
            this.genreSTT.HeaderText = "STT";
            this.genreSTT.MinimumWidth = 6;
            this.genreSTT.Name = "genreSTT";
            // 
            // genreName
            // 
            this.genreName.HeaderText = "Name";
            this.genreName.MinimumWidth = 6;
            this.genreName.Name = "genreName";
            // 
            // genre_created
            // 
            this.genre_created.HeaderText = "Created_at";
            this.genre_created.MinimumWidth = 6;
            this.genre_created.Name = "genre_created";
            // 
            // genreUpdated
            // 
            this.genreUpdated.HeaderText = "Updated_at";
            this.genreUpdated.MinimumWidth = 6;
            this.genreUpdated.Name = "genreUpdated";
            // 
            // genreAction
            // 
            this.genreAction.HeaderText = "Action";
            this.genreAction.MinimumWidth = 6;
            this.genreAction.Name = "genreAction";
            // 
            // rjButton1
            // 
            this.rjButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(473, 87);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(178, 40);
            this.rjButton1.TabIndex = 4;
            this.rjButton1.Text = "Add";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // genre_search_input
            // 
            this.genre_search_input.BackColor = System.Drawing.SystemColors.Window;
            this.genre_search_input.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.genre_search_input.BorderFocusColor = System.Drawing.Color.HotPink;
            this.genre_search_input.BorderSize = 2;
            this.genre_search_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genre_search_input.ForeColor = System.Drawing.Color.DimGray;
            this.genre_search_input.Location = new System.Drawing.Point(16, 42);
            this.genre_search_input.Margin = new System.Windows.Forms.Padding(4);
            this.genre_search_input.Multiline = false;
            this.genre_search_input.Name = "genre_search_input";
            this.genre_search_input.Padding = new System.Windows.Forms.Padding(7);
            this.genre_search_input.PasswordChar = false;
            this.genre_search_input.Size = new System.Drawing.Size(217, 35);
            this.genre_search_input.TabIndex = 0;
            this.genre_search_input.Texts = "";
            this.genre_search_input.UnderlinedStyle = true;
            // 
            // genre_add_btn
            // 
            this.genre_add_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.genre_add_btn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.genre_add_btn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.genre_add_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.genre_add_btn.BorderRadius = 0;
            this.genre_add_btn.BorderSize = 0;
            this.genre_add_btn.FlatAppearance.BorderSize = 0;
            this.genre_add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genre_add_btn.ForeColor = System.Drawing.Color.White;
            this.genre_add_btn.Location = new System.Drawing.Point(157, 84);
            this.genre_add_btn.Name = "genre_add_btn";
            this.genre_add_btn.Size = new System.Drawing.Size(182, 40);
            this.genre_add_btn.TabIndex = 6;
            this.genre_add_btn.Text = "Add";
            this.genre_add_btn.TextColor = System.Drawing.Color.White;
            this.genre_add_btn.UseVisualStyleBackColor = false;
            // 
            // genre_input
            // 
            this.genre_input.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.genre_input.BackColor = System.Drawing.SystemColors.Window;
            this.genre_input.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.genre_input.BorderFocusColor = System.Drawing.Color.HotPink;
            this.genre_input.BorderSize = 2;
            this.genre_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genre_input.ForeColor = System.Drawing.Color.DimGray;
            this.genre_input.Location = new System.Drawing.Point(13, 42);
            this.genre_input.Margin = new System.Windows.Forms.Padding(4);
            this.genre_input.Multiline = false;
            this.genre_input.Name = "genre_input";
            this.genre_input.Padding = new System.Windows.Forms.Padding(7);
            this.genre_input.PasswordChar = false;
            this.genre_input.Size = new System.Drawing.Size(326, 35);
            this.genre_input.TabIndex = 5;
            this.genre_input.Texts = "";
            this.genre_input.UnderlinedStyle = true;
            // 
            // genre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "genre";
            this.Text = "genre";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre_created;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreUpdated;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreAction;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton authorAddbtn;
        private CustomControls.RJControls.RJTextBox author_input_add;
        private CustomControls.RJControls.RJButton genre_btn_search;
        private System.Windows.Forms.Label Sort;
        private System.Windows.Forms.ComboBox genre_sort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJControls.RJTextBox genre_search_input;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJButton genre_add_btn;
        private CustomControls.RJControls.RJTextBox genre_input;
    }
}