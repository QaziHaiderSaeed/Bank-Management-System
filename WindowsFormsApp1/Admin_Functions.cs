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
    public partial class Admin_Functions : Form
    {
        private SqlDataReader dr;

        public Admin_Functions()
        {
            InitializeComponent();
        }

        private void Admin_Functions_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new reg_manager();
                newForm.ShowDialog();
        }

        private void Manager_Details_Click(object sender, EventArgs e)
        {
            var newForm = new Manager_Detail();
            newForm.ShowDialog();
        }

        private void Client_Details_Click(object sender, EventArgs e)
        {
            var newform = new Client_Details();
            newform.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var newform = new Complaintss();
            newform.ShowDialog();
        }
    }
}
