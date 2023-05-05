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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newform = new Forgot_Password_manager();
            newform.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Data Source=HAIDER\\QAZIHAIDER;Initial Catalog=\"Bank Management System\";Integrated Security=True");
            string query = "Select * from Managers where username = '" + this.Login_ID.Text.Trim() + "' and password ='" + this.Password.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                var newForm = new Manager_Functions();
                newForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Check Your Username And Password");
            }
        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }
    }
}
