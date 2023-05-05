namespace WindowsFormsApp1
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.Enter_Id = new System.Windows.Forms.TextBox();
            this.Enter_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Forgot_Password_or_create_account = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Enter_Id
            // 
            this.Enter_Id.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Enter_Id.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter_Id.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Enter_Id.Location = new System.Drawing.Point(204, 106);
            this.Enter_Id.Multiline = true;
            this.Enter_Id.Name = "Enter_Id";
            this.Enter_Id.Size = new System.Drawing.Size(230, 32);
            this.Enter_Id.TabIndex = 0;
            this.Enter_Id.Text = "ID......";
            this.Enter_Id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Enter_Password
            // 
            this.Enter_Password.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Enter_Password.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter_Password.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Enter_Password.Location = new System.Drawing.Point(204, 181);
            this.Enter_Password.Multiline = true;
            this.Enter_Password.Name = "Enter_Password";
            this.Enter_Password.PasswordChar = '*';
            this.Enter_Password.Size = new System.Drawing.Size(230, 32);
            this.Enter_Password.TabIndex = 2;
            this.Enter_Password.Text = "Password";
            this.Enter_Password.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MistyRose;
            this.label1.Location = new System.Drawing.Point(29, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login ID ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MistyRose;
            this.label2.Location = new System.Drawing.Point(31, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Forgot_Password_or_create_account
            // 
            this.Forgot_Password_or_create_account.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Forgot_Password_or_create_account.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Forgot_Password_or_create_account.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forgot_Password_or_create_account.Location = new System.Drawing.Point(204, 286);
            this.Forgot_Password_or_create_account.Name = "Forgot_Password_or_create_account";
            this.Forgot_Password_or_create_account.Size = new System.Drawing.Size(230, 23);
            this.Forgot_Password_or_create_account.TabIndex = 5;
            this.Forgot_Password_or_create_account.Text = " Create New Account ";
            this.Forgot_Password_or_create_account.UseVisualStyleBackColor = false;
            this.Forgot_Password_or_create_account.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Login.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(243, 239);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(149, 23);
            this.Login.TabIndex = 6;
            this.Login.Text = "LOGIN";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.button2_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Forgot_Password_or_create_account);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Enter_Password);
            this.Controls.Add(this.Enter_Id);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Enter_Id;
        private System.Windows.Forms.TextBox Enter_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Forgot_Password_or_create_account;
        private System.Windows.Forms.Button Login;
    }
}