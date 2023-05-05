namespace WindowsFormsApp1
{
    partial class Register_Pin
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
            this.No = new System.Windows.Forms.DataGridView();
            this.Show = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PIN = new System.Windows.Forms.TextBox();
            this.Enter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.No)).BeginInit();
            this.SuspendLayout();
            // 
            // No
            // 
            this.No.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.No.Location = new System.Drawing.Point(12, 114);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(504, 166);
            this.No.TabIndex = 5;
            // 
            // Show
            // 
            this.Show.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Show.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Show.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show.Location = new System.Drawing.Point(132, 70);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(263, 38);
            this.Show.TabIndex = 4;
            this.Show.Text = "Show Card Number";
            this.Show.UseVisualStyleBackColor = false;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 55);
            this.label3.TabIndex = 17;
            this.label3.Text = "REGISTER PIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Register PIN";
            // 
            // PIN
            // 
            this.PIN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIN.Location = new System.Drawing.Point(147, 320);
            this.PIN.Name = "PIN";
            this.PIN.PasswordChar = '*';
            this.PIN.Size = new System.Drawing.Size(248, 26);
            this.PIN.TabIndex = 14;
            // 
            // Enter
            // 
            this.Enter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter.Location = new System.Drawing.Point(197, 366);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(152, 30);
            this.Enter.TabIndex = 12;
            this.Enter.Text = "REGISTER";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Register_Pin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 403);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PIN);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.No);
            this.Controls.Add(this.Show);
            this.Name = "Register_Pin";
            this.Text = "Register_Pin";
            this.Load += new System.EventHandler(this.Register_Pin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.No)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView No;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PIN;
        private System.Windows.Forms.Button Enter;
    }
}