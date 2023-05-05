namespace WindowsFormsApp1
{
    partial class Check_Balance
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
            this.button1 = new System.Windows.Forms.Button();
            this.Balance = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Balance)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(76, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Show Available Balance";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Balance
            // 
            this.Balance.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.Balance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Balance.Location = new System.Drawing.Point(41, 102);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(327, 83);
            this.Balance.TabIndex = 2;
            // 
            // Check_Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(414, 237);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Balance);
            this.Name = "Check_Balance";
            this.Text = "Check_Balance";
            ((System.ComponentModel.ISupportInitialize)(this.Balance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Balance;
    }
}