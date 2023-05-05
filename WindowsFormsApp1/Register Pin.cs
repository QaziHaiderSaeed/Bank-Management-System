﻿using System;
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
    public partial class Register_Pin : Form
    {
        public Register_Pin()
        {
            InitializeComponent();
        }
        string MyConnection2 = "Data Source=HAIDER\\QAZIHAIDER;Initial Catalog=\"Bank Management System\";Integrated Security=True";


        private void Show_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(MyConnection2))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT [Card Number] FROM [Current Account] where username = ('" + Client.SetValueForText1 + "')", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);

                            No.DataSource = dt;

                        }
                    }
                }
            }
            using (SqlConnection con = new SqlConnection(MyConnection2))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT [Card Number] FROM [Saving Account] where username = ('" + Client.SetValueForText1 + "')", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);

                            No.DataSource = dt;

                        }
                    }
                }
            }


        }

        private void Register_Pin_Load(object sender, EventArgs e)
        {

        }

        private void Enter_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = "Data Source=HAIDER\\QAZIHAIDER;Initial Catalog=\"Bank Management System\";Integrated Security=True";
                //This is my insert query in which i am taking input from the user through windows form
                string Query = " update[Current Account] set [Pin] = ('" + this.PIN.Text + "') where username = ('" + Client.SetValueForText1+ "')";//This is  MySqlConnection here i have created the object and pass my connection string.
                SqlConnection MyConn2 = new SqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.
                SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);


                SqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                MessageBox.Show(" Your Information Is Updated! ");
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
            try
            {
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = "Data Source=HAIDER\\QAZIHAIDER;Initial Catalog=\"Bank Management System\";Integrated Security=True";
                //This is my insert query in which i am taking input from the user through windows form
                string Query = " update[Saving Account] set [Pin] = ('" + this.PIN.Text + "') where username = ('" + Client.SetValueForText1 + "')";//This is  MySqlConnection here i have created the object and pass my connection string.
                SqlConnection MyConn2 = new SqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.
                SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);


                SqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                MessageBox.Show(" Your Information Is Updated! ");
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
