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
    public partial class Managers_List : Form
    {
        public Managers_List()
        {
            InitializeComponent();
        }
        string MyConnection2 = "Data Source=HAIDER\\QAZIHAIDER;Initial Catalog=\"Bank Management System\";Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(MyConnection2))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Managers", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);

                            All_Manager.DataSource = dt;
 
                        }
                    }
                }
            }
        }
    }
}
