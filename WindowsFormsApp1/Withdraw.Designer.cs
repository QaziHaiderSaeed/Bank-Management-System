namespace WindowsFormsApp1
{
    partial class Withdraw
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
            this.Withdraw_Amount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Withdraw_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Withdraw_Amount
            // 
            this.Withdraw_Amount.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Withdraw_Amount.Location = new System.Drawing.Point(35, 118);
            this.Withdraw_Amount.Multiline = true;
            this.Withdraw_Amount.Name = "Withdraw_Amount";
            this.Withdraw_Amount.Size = new System.Drawing.Size(352, 35);
            this.Withdraw_Amount.TabIndex = 0;
            this.Withdraw_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter The Amount";
            // 
            // Withdraw_Button
            // 
            this.Withdraw_Button.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Withdraw_Button.Location = new System.Drawing.Point(124, 186);
            this.Withdraw_Button.Name = "Withdraw_Button";
            this.Withdraw_Button.Size = new System.Drawing.Size(168, 34);
            this.Withdraw_Button.TabIndex = 3;
            this.Withdraw_Button.Text = "Withdraw";
            this.Withdraw_Button.UseVisualStyleBackColor = true;
            this.Withdraw_Button.Click += new System.EventHandler(this.Withdraw_Button_Click);
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(414, 311);
            this.Controls.Add(this.Withdraw_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Withdraw_Amount);
            this.Name = "Withdraw";
            this.Text = "Withdraw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Withdraw_Amount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Withdraw_Button;
    }
}