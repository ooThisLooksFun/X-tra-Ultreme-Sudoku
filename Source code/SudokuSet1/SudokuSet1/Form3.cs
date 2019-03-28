using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuSet1
{
    public partial class rulesForm : Form
    {
        public rulesForm()
        {
            InitializeComponent();
        }

        private void rulesForm_Load(object sender, EventArgs e)
        {
            themeSelecter();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            SudokuSet1.Form2 f2 = new SudokuSet1.Form2();
            f2.Show();
        }

        private void themeSelecter()
        {
            //Checking the summer theme
            if (Form4.summerTheme == true)
            {
                BackgroundImage = SudokuSet1.Properties.Resources.Summer;
            }
            if (Form4.fallTheme == true)
            {
                BackgroundImage = SudokuSet1.Properties.Resources.Fall;
            }
            if (Form4.halloweenTheme == true)
            {
                BackgroundImage = SudokuSet1.Properties.Resources.Halloween;
            }
            if (Form4.christmasTheme == true)
            {
                BackgroundImage = SudokuSet1.Properties.Resources.Christmas;
            }
            if (Form4.beachTheme == true)
            {
                BackgroundImage = SudokuSet1.Properties.Resources.Beach;
            }
            else if (Form4.classicTheme == true)
            {
                this.BackgroundImage = null;
            }
        }
    }
}
