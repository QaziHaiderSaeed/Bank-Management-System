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
    public partial class Forgot_Password_Client : Form
    {
        public Forgot_Password_Client()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = "Data Source=HAIDER\\QAZIHAIDER;Initial Catalog=\"Bank Management System\";Integrated Security=True";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = " update[Current Account] set [password]=('" + this.Password.Text + "') where username = ('" + this.username.Text + "')";
                if (this.code.Text == "00000")
                {

                    //This is  MySqlConnection here i have created the object and pass my connection string.
                    SqlConnection MyConn2 = new SqlConnection(MyConnection2);
                    //This is command class which will handle the query and connection object.
                    SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                    SqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                    MessageBox.Show("Password is successfully Changed");
                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();

                }
                else
                {
                    MessageBox.Show("Check Your System Code is Correct!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = "Data Source=HAIDER\\QAZIHAIDER;Initial Catalog=\"Bank Management System\";Integrated Security=True";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = " update[Saving Account] set [password]=('" + this.Password.Text + "') where username = ('" + this.username.Text + "')";
                if (this.code.Text == "00000")
                {

                    //This is  MySqlConnection here i have created the object and pass my connection string.
                    SqlConnection MyConn2 = new SqlConnection(MyConnection2);
                    //This is command class which will handle the query and connection object.
                    SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                    SqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                    MessageBox.Show("Password is successfully Changed");
                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();

                }
                else
                {
                    MessageBox.Show("Check Your System Code is Correct!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
