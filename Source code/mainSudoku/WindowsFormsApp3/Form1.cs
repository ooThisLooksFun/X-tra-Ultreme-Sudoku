using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class menuForm : Form
    {
        public menuForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            rulesForm f2 = new rulesForm();
            f2.Show();
        }

        private void pbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
           // form1 f1 = new form1();
           // f1.Show();
        }
    }
}
