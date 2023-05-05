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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void ADMIN_Click(object sender, EventArgs e)
        {
            var newForm = new Admin();
            newForm.ShowDialog();
        }

        private void Manager_Click(object sender, EventArgs e)
        {
            var newForm = new Manager();
            newForm.ShowDialog();
        }

        private void CLIENT_Click(object sender, EventArgs e)
        {
            var newForm = new Client();
            newForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
