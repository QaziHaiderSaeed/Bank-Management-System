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
    public partial class Show_Complaint_Status : Form
    {
        public Show_Complaint_Status()
        {
            InitializeComponent();
        }
        string MyConnection2 = "Data Source=HAIDER\\QAZIHAIDER;Initial Catalog=\"Bank Management System\";Integrated Security=True";

        private void Show_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(MyConnection2))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Complaint where username = ('" + Client.SetValueForText1 + "')", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);

                            All_Complaints.DataSource = dt;

                        }
                    }
                }
            }
        }

        private void All_Complaints_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
