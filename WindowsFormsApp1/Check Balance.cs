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
    public partial class Check_Balance : Form
    {
        public Check_Balance()
        {
            InitializeComponent();
        }
        string a = Client.SetValueForText1;
        string b = Client.SetValueForText2;
        string MyConnection2 = "Data Source=HAIDER\\QAZIHAIDER;Initial Catalog=\"Bank Management System\";Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(MyConnection2))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Balance FROM [Current Account] where username =('"+ Client.SetValueForText1+"')", con))
                using (SqlCommand cmd1 = new SqlCommand("SELECT Balance FROM [Saving Account] where username =('" + Client.SetValueForText1 + "')", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    using (SqlDataAdapter sda1 = new SqlDataAdapter(cmd1))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            sda1.Fill(dt);
                            Balance.DataSource = dt;
                        }
                    }
                }
            }

        }
    }
}
