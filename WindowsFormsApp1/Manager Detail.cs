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
    public partial class Manager_Detail : Form
    {
        public Manager_Detail()
        {
            InitializeComponent();
        }

        private void ALL_Managers_Click(object sender, EventArgs e)
        {
            var newForm = new Managers_List();
            newForm.ShowDialog();
        }

        private void Search_by_ID_Click(object sender, EventArgs e)
        {
            var newForm = new Search_Manager_by_ID();
            newForm.ShowDialog();
        }
    }
}
