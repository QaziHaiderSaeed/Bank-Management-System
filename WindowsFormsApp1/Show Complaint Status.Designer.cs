namespace WindowsFormsApp1
{
    partial class Show_Complaint_Status
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
            this.All_Complaints = new System.Windows.Forms.DataGridView();
            this.Show = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.All_Complaints)).BeginInit();
            this.SuspendLayout();
            // 
            // All_Complaints
            // 
            this.All_Complaints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.All_Complaints.Location = new System.Drawing.Point(12, 71);
            this.All_Complaints.Name = "All_Complaints";
            this.All_Complaints.Size = new System.Drawing.Size(646, 197);
            this.All_Complaints.TabIndex = 3;
            this.All_Complaints.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.All_Complaints_CellContentClick);
            // 
            // Show
            // 
            this.Show.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Show.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Show.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show.Location = new System.Drawing.Point(216, 27);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(258, 38);
            this.Show.TabIndex = 2;
            this.Show.Text = "Show Complaints";
            this.Show.UseVisualStyleBackColor = false;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // Show_Complaint_Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(664, 276);
            this.Controls.Add(this.All_Complaints);
            this.Controls.Add(this.Show);
            this.Name = "Show_Complaint_Status";
            this.Text = "Show_Complaint_Status";
            ((System.ComponentModel.ISupportInitialize)(this.All_Complaints)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView All_Complaints;
        private System.Windows.Forms.Button Show;
    }
}