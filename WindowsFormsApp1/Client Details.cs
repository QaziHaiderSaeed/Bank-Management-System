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
    public partial class Client_Details : Form
    {
        public Client_Details()
        {
            InitializeComponent();
        }
        string MyConnection2 = "Data Source=HAIDER\\QAZIHAIDER;Initial Catalog=\"Bank Management System\";Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
             using (SqlConnection con = new SqlConnection(MyConnection2))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM [Current Account]", con))
                
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())

                        {
                            sda.Fill(dt);
                            All_Clients_Current.DataSource = dt;
                        }
                    }
                }
            }
            using (SqlConnection con = new SqlConnection(MyConnection2))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM [Saving Account]", con))

                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())

                        {
                            sda.Fill(dt);
                            All_Clients_Saving.DataSource = dt;
                        }
                    }
                }
            }
        }
    }
}
