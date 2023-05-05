namespace WindowsFormsApp1
{
    partial class Client_Details
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.All_Clients_Saving = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.All_Clients_Current = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.All_Clients_Saving)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.All_Clients_Current)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(972, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Saving Account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Current Account";
            // 
            // All_Clients_Saving
            // 
            this.All_Clients_Saving.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.All_Clients_Saving.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.All_Clients_Saving.Location = new System.Drawing.Point(690, 83);
            this.All_Clients_Saving.Name = "All_Clients_Saving";
            this.All_Clients_Saving.Size = new System.Drawing.Size(672, 432);
            this.All_Clients_Saving.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(575, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Show Client List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // All_Clients_Current
            // 
            this.All_Clients_Current.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.All_Clients_Current.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.All_Clients_Current.Location = new System.Drawing.Point(12, 83);
            this.All_Clients_Current.Name = "All_Clients_Current";
            this.All_Clients_Current.Size = new System.Drawing.Size(672, 432);
            this.All_Clients_Current.TabIndex = 5;
            // 
            // Client_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 524);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.All_Clients_Saving);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.All_Clients_Current);
            this.Name = "Client_Details";
            this.Text = "Client_Details";
            ((System.ComponentModel.ISupportInitialize)(this.All_Clients_Saving)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.All_Clients_Current)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView All_Clients_Saving;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView All_Clients_Current;
    }
}