using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Manager_Functions : Form
    {
        public Manager_Functions()
        {
            InitializeComponent();
        }

        private void Manager_Functions_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new Client_regisatration();
            newForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newForm = new Deposit_Method();
            newForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newform = new Register_ATM();
            newform.ShowDialog();

        }
    }
}