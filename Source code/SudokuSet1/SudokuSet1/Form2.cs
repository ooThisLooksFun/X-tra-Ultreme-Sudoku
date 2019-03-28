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
    public partial class Form2 : Form
    {
        private string num;
        string a = "";
        public string Num
        {
            get { return num; }
            set { num = value; }
            
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void pbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SudokuSet1.Form1 f1 = new SudokuSet1.Form1();
            f1.Show();

        }

        private void rbtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SudokuSet1.rulesForm f3 = new SudokuSet1.rulesForm();
            f3.Show();

        }

        private void tbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SudokuSet1.Form4 f4 = new SudokuSet1.Form4();
            f4.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            themeSelecter();
        }
        /*Function for hanging the background according to the selected theme*/
        private void themeSelecter()
        {
            //Checking the summer theme
            if(Form4.summerTheme == true)
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