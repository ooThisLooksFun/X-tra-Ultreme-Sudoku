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
    public partial class Form4 : Form
    {

        //Global variables for themes
        public static Boolean summerTheme = false;
        public static Boolean fallTheme = false;
        public static Boolean halloweenTheme = false;
        public static Boolean christmasTheme = false;
        public static Boolean classicTheme = false;
        public static Boolean beachTheme = false;

        public Form4()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

      

        private void fallbtn_Click(object sender, EventArgs e)
        {
            BackgroundImage = SudokuSet1.Properties.Resources.Fall;
            //Setting the appropriate theme to true
            fallTheme = true;
            summerTheme = false;
            halloweenTheme = false;
            christmasTheme = false;
            classicTheme = false;
            beachTheme = false;

        }

        private void hallobtn_Click(object sender, EventArgs e)
        {
            BackgroundImage = SudokuSet1.Properties.Resources.Halloween;
            //Setting the appropriate theme to true
            fallTheme = false;
            summerTheme = false;
            halloweenTheme = true;
            christmasTheme = false;
            classicTheme = false;
            beachTheme = false;

        }

        private void chrisbtn_Click(object sender, EventArgs e)
        {
            BackgroundImage = SudokuSet1.Properties.Resources.Christmas;
            //Setting the appropriate theme to true
            fallTheme = false;
            summerTheme = false;
            halloweenTheme = false;
            christmasTheme = true;
            classicTheme = false;
            beachTheme = false;
        }

        private void themeSelecter()
        {
            //Checking the summer theme
            if (Form4.summerTheme == true)
            {
                BackgroundImage = SudokuSet1.Properties.Resources.Summer;
            }
            else if (Form4.fallTheme == true)
            {
                BackgroundImage = SudokuSet1.Properties.Resources.Fall;
            }
            else if (Form4.halloweenTheme == true)
            {
                BackgroundImage = SudokuSet1.Properties.Resources.Halloween;
            }
            else if (Form4.christmasTheme == true)
            {
                BackgroundImage = SudokuSet1.Properties.Resources.Christmas;
            }
            else if (Form4.beachTheme == true)
            {
                BackgroundImage = SudokuSet1.Properties.Resources.Beach;
            }
            else if (Form4.classicTheme == true)
            {
                this.BackgroundImage = null;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            themeSelecter();
        }

        private void sumbtn_Click(object sender, EventArgs e)
        {
            BackgroundImage = SudokuSet1.Properties.Resources.Summer;
            //Setting the appropriate theme to true
            fallTheme = false;
            summerTheme = true;
            halloweenTheme = false;
            christmasTheme = false;
            classicTheme = false;
            beachTheme = false;
        }

        private void beabtn_Click(object sender, EventArgs e)
        {
            BackgroundImage = SudokuSet1.Properties.Resources.Beach;
            //Setting the appropriate theme to true
            fallTheme = false;
            summerTheme = false;
            halloweenTheme = false;
            christmasTheme = false;
            classicTheme = false;
            beachTheme = true;
        }

        private void classbtn_Click(object sender, EventArgs e)
        {
            //Setting the appropriate theme to true
            fallTheme = false;
            summerTheme = false;
            halloweenTheme = false;
            christmasTheme = false;
            classicTheme = true;
            beachTheme = false;
            themeSelecter();
        }
    }
}
