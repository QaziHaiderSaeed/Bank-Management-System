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
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public partial class client_Functions : Form
    {
        
        public client_Functions()
        {
            InitializeComponent();
            
        }
        string a = Client.SetValueForText1;
        string b = Client.SetValueForText2;

        private void button5_Click(object sender, EventArgs e)
        {
            var newForm = new Check_Balance();
            newForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new Withdraw();
            newForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newForm = new Deposit_Method();
            newForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var newForm = new Complaintssss();
            newForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newForm = new Update_Info();
            newForm.ShowDialog();
        }

        private void client_Functions_Load(object sender, EventArgs e)
        {
            Welcome.Text = ("Welcome " + a + " !");
        }

        private void Register_PIN_Click(object sender, EventArgs e)
        {
            var newform=new Register_Pin();
            newform.ShowDialog();
        }
    }
}
