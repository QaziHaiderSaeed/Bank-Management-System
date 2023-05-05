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
    public partial class Client_regisatration : Form
    {
        public Client_regisatration()
        {
            InitializeComponent();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new Current_Account();
            newForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newForm = new Saving_Account();
            newForm.ShowDialog();
        }
    }
}
