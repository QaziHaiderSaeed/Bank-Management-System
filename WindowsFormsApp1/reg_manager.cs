using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class reg_manager : Form
    {
        public reg_manager()
        {
            InitializeComponent();
        }

        private void reg_manager_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = "Data Source=HAIDER\\QAZIHAIDER;Initial Catalog=\"Bank Management System\";Integrated Security=True";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "insert into Managers([First Name],[Last Name],[Phone No],[Email],[CNIC No],[Address],[Qualification],[Marital Status],[Age],[username],[password]) values('"  + this.f_name.Text + "','" + this.L_name.Text + "','"+this.Phone_Noo.Text + "','"+this.Emaill.Text + "','"+ this.NIC_No.Text + "','"+this.Addresss.Text + "','"+this.Qualificationn.Text + "','"+this.Maritall_Status.Text + "','"+this.Agee.Text + "','"+ this.Usernamee.Text + "','"+ this.Passwordd.Text + "') Select DISTINCT([username]) from [Managers]";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                SqlConnection MyConn2 = new SqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.
                SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                SqlDataReader MyReader2;
                
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                MessageBox.Show("Record Is registered!");
                this.Hide();
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
