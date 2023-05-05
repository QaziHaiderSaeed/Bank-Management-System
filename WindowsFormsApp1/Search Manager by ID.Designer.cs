namespace WindowsFormsApp1
{
    partial class Search_Manager_by_ID
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
            this.Show = new System.Windows.Forms.Button();
            this.ID_NO = new System.Windows.Forms.TextBox();
            this.Data_By_ID = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Data_By_ID)).BeginInit();
            this.SuspendLayout();
            // 
            // Show
            // 
            this.Show.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Show.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show.Location = new System.Drawing.Point(441, 85);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(129, 33);
            this.Show.TabIndex = 0;
            this.Show.Text = "Show";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // ID_NO
            // 
            this.ID_NO.Location = new System.Drawing.Point(362, 59);
            this.ID_NO.Name = "ID_NO";
            this.ID_NO.Size = new System.Drawing.Size(278, 20);
            this.ID_NO.TabIndex = 1;
            // 
            // Data_By_ID
            // 
            this.Data_By_ID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_By_ID.Location = new System.Drawing.Point(-1, 124);
            this.Data_By_ID.Name = "Data_By_ID";
            this.Data_By_ID.Size = new System.Drawing.Size(989, 185);
            this.Data_By_ID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter ID";
            // 
            // Search_Manager_by_ID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 308);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Data_By_ID);
            this.Controls.Add(this.ID_NO);
            this.Controls.Add(this.Show);
            this.Name = "Search_Manager_by_ID";
            this.Text = "Search_Manager_by_ID";
            ((System.ComponentModel.ISupportInitialize)(this.Data_By_ID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.TextBox ID_NO;
        private System.Windows.Forms.DataGridView Data_By_ID;
        private System.Windows.Forms.Label label1;
    }
}