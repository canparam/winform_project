namespace projectcore
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.userName = new CustomControls.RJControls.RJTextBox();
            this.Password = new CustomControls.RJControls.RJTextBox();
            this.btn_login = new CustomControls.RJControls.RJButton();
            this.messValidate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveAccount = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.BackColor = System.Drawing.SystemColors.Window;
            this.userName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(128)))), ((int)(((byte)(136)))));
            this.userName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(155)))), ((int)(((byte)(243)))));
            this.userName.BorderSize = 2;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userName.ForeColor = System.Drawing.Color.DimGray;
            this.userName.Location = new System.Drawing.Point(41, 245);
            this.userName.Margin = new System.Windows.Forms.Padding(5);
            this.userName.Multiline = false;
            this.userName.Name = "userName";
            this.userName.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.userName.PasswordChar = false;
            this.userName.Size = new System.Drawing.Size(305, 39);
            this.userName.TabIndex = 0;
            this.userName.Texts = "Username";
            this.userName.UnderlinedStyle = true;
            this.userName.Enter += new System.EventHandler(this.Username_enter);
            this.userName.Leave += new System.EventHandler(this.Username_leva);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.SystemColors.Window;
            this.Password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(128)))), ((int)(((byte)(136)))));
            this.Password.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(155)))), ((int)(((byte)(243)))));
            this.Password.BorderSize = 2;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password.ForeColor = System.Drawing.Color.DimGray;
            this.Password.Location = new System.Drawing.Point(41, 325);
            this.Password.Margin = new System.Windows.Forms.Padding(5);
            this.Password.Multiline = false;
            this.Password.Name = "Password";
            this.Password.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Password.PasswordChar = false;
            this.Password.Size = new System.Drawing.Size(305, 39);
            this.Password.TabIndex = 1;
            this.Password.Texts = "Password";
            this.Password.UnderlinedStyle = true;
            this.Password.Enter += new System.EventHandler(this.Password_enter);
            this.Password.Leave += new System.EventHandler(this.Password_leva);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(155)))), ((int)(((byte)(243)))));
            this.btn_login.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(155)))), ((int)(((byte)(243)))));
            this.btn_login.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_login.BorderRadius = 0;
            this.btn_login.BorderSize = 0;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(190, 432);
            this.btn_login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(157, 53);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Login";
            this.btn_login.TextColor = System.Drawing.Color.White;
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // messValidate
            // 
            this.messValidate.AutoSize = true;
            this.messValidate.Location = new System.Drawing.Point(41, 372);
            this.messValidate.Name = "messValidate";
            this.messValidate.Size = new System.Drawing.Size(0, 20);
            this.messValidate.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(123, 67);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(153, 157);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // saveAccount
            // 
            this.saveAccount.AutoSize = true;
            this.saveAccount.Location = new System.Drawing.Point(41, 432);
            this.saveAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveAccount.Name = "saveAccount";
            this.saveAccount.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveAccount.Size = new System.Drawing.Size(114, 32);
            this.saveAccount.TabIndex = 5;
            this.saveAccount.Text = "Remember ";
            this.saveAccount.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 600);
            this.Controls.Add(this.saveAccount);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.messValidate);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.userName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJTextBox userName;
        private CustomControls.RJControls.RJTextBox Password;
        private CustomControls.RJControls.RJButton btn_login;
        private System.Windows.Forms.Label messValidate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox saveAccount;
    }
}
