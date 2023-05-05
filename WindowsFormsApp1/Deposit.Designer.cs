namespace WindowsFormsApp1
{
    partial class Deposit_Method
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
            this.ID = new System.Windows.Forms.TextBox();
            this.Deposit_amount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(123, 84);
            this.ID.Multiline = true;
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(216, 25);
            this.ID.TabIndex = 0;
            // 
            // Deposit_amount
            // 
            this.Deposit_amount.Location = new System.Drawing.Point(200, 170);
            this.Deposit_amount.Name = "Deposit_amount";
            this.Deposit_amount.Size = new System.Drawing.Size(75, 23);
            this.Deposit_amount.TabIndex = 1;
            this.Deposit_amount.Text = "Deposit";
            this.Deposit_amount.UseVisualStyleBackColor = true;
            this.Deposit_amount.Click += new System.EventHandler(this.Deposit_amount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Username ID";
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(123, 139);
            this.Amount.Multiline = true;
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(216, 25);
            this.Amount.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Amount to Deposit";
            // 
            // Deposit_Method
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(467, 238);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Deposit_amount);
            this.Controls.Add(this.ID);
            this.Name = "Deposit_Method";
            this.Text = "Deposit Method";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Button Deposit_amount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.Label label2;
    }
}