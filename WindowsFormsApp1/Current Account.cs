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
    public partial class Current_Account : Form
    {
        public Current_Account()
        {
            InitializeComponent();
        }

        private void Current_Account_Load(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = "Data Source=HAIDER\\QAZIHAIDER;Initial Catalog=\"Bank Management System\";Integrated Security=True";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "insert into [Current Account](id,[First Name],[Last Name],[Phone No],[Email],[CNIC No],[Address],[Source of Income],[Marital Status],[Age],[Next of Kin],[Father Name],[Mother Name],[username],[password],[Balance]) values('" + this.IDD.Text + "','" + this.F_Name.Text + "','" + this.L_Name.Text + "','" + this.Phone.Text + "','" + this.Emaill.Text + "','" + this.NIC.Text + "','" + this.Addres.Text + "','" + this.Source_Of_Income.Text + "','" + this.Marital_Statuss.Text + "','" + this.Agee.Text + "','" + this.Next_Of_Kin.Text + "','" + this.Father_Name.Text + "','" + this.Mother_Name.Text + "','" + this.Usernamee.Text + "','" + this.Pass.Text + "','" + this.Initial_Depositt.Text + "')";
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

        private void Initial_Depositt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
