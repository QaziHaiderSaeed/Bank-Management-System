namespace WindowsFormsApp1
{
    partial class Manager_Detail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager_Detail));
            this.ALL_Managers = new System.Windows.Forms.Button();
            this.Search_by_ID = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ALL_Managers
            // 
            this.ALL_Managers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ALL_Managers.BackgroundImage")));
            this.ALL_Managers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ALL_Managers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ALL_Managers.Location = new System.Drawing.Point(113, 73);
            this.ALL_Managers.Name = "ALL_Managers";
            this.ALL_Managers.Size = new System.Drawing.Size(267, 105);
            this.ALL_Managers.TabIndex = 0;
            this.ALL_Managers.UseVisualStyleBackColor = true;
            this.ALL_Managers.Click += new System.EventHandler(this.ALL_Managers_Click);
            // 
            // Search_by_ID
            // 
            this.Search_by_ID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Search_by_ID.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Search_by_ID.BackgroundImage")));
            this.Search_by_ID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Search_by_ID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Search_by_ID.Location = new System.Drawing.Point(113, 217);
            this.Search_by_ID.Name = "Search_by_ID";
            this.Search_by_ID.Size = new System.Drawing.Size(270, 104);
            this.Search_by_ID.TabIndex = 1;
            this.Search_by_ID.UseVisualStyleBackColor = false;
            this.Search_by_ID.Click += new System.EventHandler(this.Search_by_ID_Click);
            // 
            // Manager_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(501, 389);
            this.Controls.Add(this.Search_by_ID);
            this.Controls.Add(this.ALL_Managers);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "Manager_Detail";
            this.Text = "Manager_Detail";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ALL_Managers;
        private System.Windows.Forms.Button Search_by_ID;
    }
}