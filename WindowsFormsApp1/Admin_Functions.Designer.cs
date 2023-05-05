namespace WindowsFormsApp1
{
    partial class Admin_Functions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Functions));
            this.Register_manager = new System.Windows.Forms.Button();
            this.Manager_Details = new System.Windows.Forms.Button();
            this.Client_Details = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Register_manager
            // 
            this.Register_manager.BackColor = System.Drawing.Color.MidnightBlue;
            this.Register_manager.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Register_manager.BackgroundImage")));
            this.Register_manager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Register_manager.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Register_manager.Location = new System.Drawing.Point(12, 12);
            this.Register_manager.Name = "Register_manager";
            this.Register_manager.Size = new System.Drawing.Size(238, 78);
            this.Register_manager.TabIndex = 0;
            this.Register_manager.UseVisualStyleBackColor = false;
            this.Register_manager.Click += new System.EventHandler(this.button1_Click);
            // 
            // Manager_Details
            // 
            this.Manager_Details.BackColor = System.Drawing.Color.MidnightBlue;
            this.Manager_Details.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Manager_Details.BackgroundImage")));
            this.Manager_Details.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Manager_Details.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Manager_Details.Location = new System.Drawing.Point(12, 131);
            this.Manager_Details.Name = "Manager_Details";
            this.Manager_Details.Size = new System.Drawing.Size(238, 78);
            this.Manager_Details.TabIndex = 1;
            this.Manager_Details.UseVisualStyleBackColor = false;
            this.Manager_Details.Click += new System.EventHandler(this.Manager_Details_Click);
            // 
            // Client_Details
            // 
            this.Client_Details.BackColor = System.Drawing.Color.MidnightBlue;
            this.Client_Details.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Client_Details.BackgroundImage")));
            this.Client_Details.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Client_Details.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Client_Details.Location = new System.Drawing.Point(12, 255);
            this.Client_Details.Name = "Client_Details";
            this.Client_Details.Size = new System.Drawing.Size(238, 78);
            this.Client_Details.TabIndex = 2;
            this.Client_Details.UseVisualStyleBackColor = false;
            this.Client_Details.Click += new System.EventHandler(this.Client_Details_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(12, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 78);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Admin_Functions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(846, 471);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Client_Details);
            this.Controls.Add(this.Manager_Details);
            this.Controls.Add(this.Register_manager);
            this.Name = "Admin_Functions";
            this.Text = "Admin_Functions";
            this.Load += new System.EventHandler(this.Admin_Functions_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Register_manager;
        private System.Windows.Forms.Button Manager_Details;
        private System.Windows.Forms.Button Client_Details;
        private System.Windows.Forms.Button button1;
    }
}