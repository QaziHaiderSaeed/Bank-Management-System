namespace WindowsFormsApp1
{
    partial class Managers_List
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
            this.All_Manager = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.All_Manager)).BeginInit();
            this.SuspendLayout();
            // 
            // All_Manager
            // 
            this.All_Manager.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.All_Manager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.All_Manager.Location = new System.Drawing.Point(5, 89);
            this.All_Manager.Name = "All_Manager";
            this.All_Manager.Size = new System.Drawing.Size(783, 331);
            this.All_Manager.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(298, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 44);
            this.button1.TabIndex = 7;
            this.button1.Text = "Show Client List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Managers_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 426);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.All_Manager);
            this.Name = "Managers_List";
            this.Text = "Managers_List";
            ((System.ComponentModel.ISupportInitialize)(this.All_Manager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView All_Manager;
        private System.Windows.Forms.Button button1;
    }
}