using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ATM : Form
    {
        public ATM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Data Source=HAIDER\\QAZIHAIDER;Initial Catalog=\"Bank Management System\";Integrated Security=True");
            string query = "Select * from [Current Account] where [Card Number] = '" + this.Card_Number.Text.Trim() + "' and PIN ='" + this.PIN.Text.Trim() + "'";
            string query1 = "Select * from [Saving Account] where [Card Number] = '" + this.Card_Number.Text.Trim() + "' and PIN ='" + this.PIN.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            SqlDataAdapter sda1 = new SqlDataAdapter(query1, sqlcon);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            sda1.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                var newForm = new client_Functions();
                newForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Check Your Username And Password");
            }
        }
    }
}
