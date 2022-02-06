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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.author_btn_search = new CustomControls.RJControls.RJButton();
            this.Sort = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.author_search_input = new CustomControls.RJControls.RJTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.authorAddbtn = new CustomControls.RJControls.RJButton();
            this.author_input_add = new CustomControls.RJControls.RJTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorUpdated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 136);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.author_btn_search);
            this.panel4.Controls.Add(this.Sort);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.author_search_input);
            this.panel4.Location = new System.Drawing.Point(357, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(443, 136);
            this.panel4.TabIndex = 1;
            // 
            // author_btn_search
            // 
            this.author_btn_search.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.author_btn_search.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.author_btn_search.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.author_btn_search.BorderRadius = 0;
            this.author_btn_search.BorderSize = 0;
            this.author_btn_search.FlatAppearance.BorderSize = 0;
            this.author_btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.author_btn_search.ForeColor = System.Drawing.Color.White;
            this.author_btn_search.Location = new System.Drawing.Point(252, 84);
            this.author_btn_search.Name = "author_btn_search";
            this.author_btn_search.Size = new System.Drawing.Size(178, 40);
            this.author_btn_search.TabIndex = 4;
            this.author_btn_search.Text = "Search";
            this.author_btn_search.TextColor = System.Drawing.Color.White;
            this.author_btn_search.UseVisualStyleBackColor = false;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(252, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 28);
            this.comboBox1.TabIndex = 2;
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
            // author_search_input
            // 
            this.author_search_input.BackColor = System.Drawing.SystemColors.Window;
            this.author_search_input.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.author_search_input.BorderFocusColor = System.Drawing.Color.HotPink;
            this.author_search_input.BorderSize = 2;
            this.author_search_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.author_search_input.ForeColor = System.Drawing.Color.DimGray;
            this.author_search_input.Location = new System.Drawing.Point(16, 42);
            this.author_search_input.Margin = new System.Windows.Forms.Padding(4);
            this.author_search_input.Multiline = false;
            this.author_search_input.Name = "author_search_input";
            this.author_search_input.Padding = new System.Windows.Forms.Padding(7);
            this.author_search_input.PasswordChar = false;
            this.author_search_input.Size = new System.Drawing.Size(217, 35);
            this.author_search_input.TabIndex = 0;
            this.author_search_input.Texts = "";
            this.author_search_input.UnderlinedStyle = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.authorAddbtn);
            this.panel3.Controls.Add(this.author_input_add);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(351, 136);
            this.panel3.TabIndex = 0;
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
            this.authorAddbtn.Location = new System.Drawing.Point(157, 84);
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
            this.author_input_add.Location = new System.Drawing.Point(13, 42);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 314);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.authorName,
            this.dataGridViewTextBoxColumn2,
            this.authorUpdated,
            this.authorAction});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(800, 314);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // authorName
            // 
            this.authorName.HeaderText = "Name";
            this.authorName.MinimumWidth = 6;
            this.authorName.Name = "authorName";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Created_at";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // authorUpdated
            // 
            this.authorUpdated.HeaderText = "Updated_at";
            this.authorUpdated.MinimumWidth = 6;
            this.authorUpdated.Name = "authorUpdated";
            // 
            // authorAction
            // 
            this.authorAction.HeaderText = "Action";
            this.authorAction.MinimumWidth = 6;
            this.authorAction.Name = "authorAction";
            // 
            // author
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "author";
            this.Text = "author";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton authorAddbtn;
        private CustomControls.RJControls.RJTextBox author_input_add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorUpdated;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorAction;
        private CustomControls.RJControls.RJButton author_btn_search;
        private System.Windows.Forms.Label Sort;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJTextBox author_search_input;
    }
}