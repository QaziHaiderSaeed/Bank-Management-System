namespace WindowsFormsApp1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.ADMIN = new System.Windows.Forms.Button();
            this.Manager = new System.Windows.Forms.Button();
            this.CLIENT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ADMIN
            // 
            this.ADMIN.BackColor = System.Drawing.Color.Transparent;
            this.ADMIN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ADMIN.BackgroundImage")));
            this.ADMIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ADMIN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ADMIN.Location = new System.Drawing.Point(12, 25);
            this.ADMIN.Name = "ADMIN";
            this.ADMIN.Size = new System.Drawing.Size(160, 139);
            this.ADMIN.TabIndex = 0;
            this.ADMIN.UseVisualStyleBackColor = false;
            this.ADMIN.Click += new System.EventHandler(this.ADMIN_Click);
            // 
            // Manager
            // 
            this.Manager.BackColor = System.Drawing.Color.Transparent;
            this.Manager.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Manager.BackgroundImage")));
            this.Manager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Manager.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Manager.ForeColor = System.Drawing.Color.Transparent;
            this.Manager.Location = new System.Drawing.Point(12, 174);
            this.Manager.Name = "Manager";
            this.Manager.Size = new System.Drawing.Size(159, 137);
            this.Manager.TabIndex = 1;
            this.Manager.UseVisualStyleBackColor = false;
            this.Manager.Click += new System.EventHandler(this.Manager_Click);
            // 
            // CLIENT
            // 
            this.CLIENT.BackColor = System.Drawing.Color.Transparent;
            this.CLIENT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CLIENT.BackgroundImage")));
            this.CLIENT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CLIENT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CLIENT.Location = new System.Drawing.Point(12, 329);
            this.CLIENT.Name = "CLIENT";
            this.CLIENT.Size = new System.Drawing.Size(164, 136);
            this.CLIENT.TabIndex = 2;
            this.CLIENT.UseVisualStyleBackColor = false;
            this.CLIENT.Click += new System.EventHandler(this.CLIENT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label1.Location = new System.Drawing.Point(217, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 183);
            this.label1.TabIndex = 3;
            this.label1.Text = "Banking is a branch \r\nof the information \r\n  Business.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(697, 477);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CLIENT);
            this.Controls.Add(this.Manager);
            this.Controls.Add(this.ADMIN);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ADMIN;
        private System.Windows.Forms.Button Manager;
        private System.Windows.Forms.Button CLIENT;
        private System.Windows.Forms.Label label1;
    }
}