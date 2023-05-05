namespace WindowsFormsApp1
{
    partial class Register_Pinn
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
            this.Card_Number = new System.Windows.Forms.DataGridView();
            this.Show = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PIN = new System.Windows.Forms.TextBox();
            this.Enter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Card_Number)).BeginInit();
            this.SuspendLayout();
            // 
            // Card_Number
            // 
            this.Card_Number.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Card_Number.Location = new System.Drawing.Point(106, 182);
            this.Card_Number.Name = "Card_Number";
            this.Card_Number.Size = new System.Drawing.Size(589, 92);
            this.Card_Number.TabIndex = 25;
            // 
            // Show
            // 
            this.Show.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Show.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Show.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show.Location = new System.Drawing.Point(275, 134);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(280, 42);
            this.Show.TabIndex = 24;
            this.Show.Text = "Show Complaints";
            this.Show.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(390, 55);
            this.label3.TabIndex = 23;
            this.label3.Text = "REGISTER ATM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(361, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Enter Pin :";
            // 
            // PIN
            // 
            this.PIN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIN.Location = new System.Drawing.Point(275, 317);
            this.PIN.Name = "PIN";
            this.PIN.PasswordChar = '*';
            this.PIN.Size = new System.Drawing.Size(248, 26);
            this.PIN.TabIndex = 21;
            // 
            // Enter
            // 
            this.Enter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter.Location = new System.Drawing.Point(325, 363);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(152, 30);
            this.Enter.TabIndex = 20;
            this.Enter.Text = "REGISTER";
            this.Enter.UseVisualStyleBackColor = true;
            // 
            // Register_Pinn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Card_Number);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PIN);
            this.Controls.Add(this.Enter);
            this.Name = "Register_Pinn";
            this.Text = "Register_Pinn";
            ((System.ComponentModel.ISupportInitialize)(this.Card_Number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Card_Number;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PIN;
        private System.Windows.Forms.Button Enter;
    }
}