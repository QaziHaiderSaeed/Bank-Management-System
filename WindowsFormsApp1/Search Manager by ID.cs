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
    public partial class Search_Manager_by_ID : Form
    {
        public Search_Manager_by_ID()
        {
            InitializeComponent();
        }
        string MyConnection2 = "Data Source=HAIDER\\QAZIHAIDER;Initial Catalog=\"Bank Management System\";Integrated Security=True";

        private void Show_Click(object sender, EventArgs e)
        {
            try {
                using (SqlConnection con = new SqlConnection(MyConnection2))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Managers where ID = '" + this.ID_NO.Text + "';", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                Data_By_ID.DataSource = dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
