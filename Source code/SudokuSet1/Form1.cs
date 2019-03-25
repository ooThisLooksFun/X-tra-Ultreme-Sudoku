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
    public partial class Form1 : Form
    {
        //Random number generator
        public Random rand = new Random();
        

        // Integer Time
        int time = 0;
        int n = 0;
        int[] array = new int[9];
        int x = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public void Start()
        {



            textBox1.Text = 5.ToString();
            textBox2.Text = 3.ToString();
            textBox5.Text = 7.ToString();
            textBox10.Text = 6.ToString();
            textBox13.Text = 1.ToString();
            textBox14.Text = 9.ToString();
            textBox15.Text = 5.ToString();
            textBox20.Text = 9.ToString();
            textBox21.Text = 8.ToString();
            textBox26.Text = 6.ToString();
            textBox28.Text = 8.ToString();
            textBox32.Text = 6.ToString();
            textBox36.Text = 3.ToString();
            textBox37.Text = 4.ToString();
            textBox40.Text = 8.ToString();
            textBox42.Text = 3.ToString();
            textBox45.Text = 1.ToString();
            textBox46.Text = 7.ToString();
            textBox50.Text = 2.ToString();
            textBox54.Text = 6.ToString();
            textBox56.Text = 6.ToString();
            textBox61.Text = 2.ToString();
            textBox62.Text = 8.ToString();
            textBox67.Text = 4.ToString();
            textBox68.Text = 1.ToString();
            textBox69.Text = 9.ToString();
            textBox72.Text = 5.ToString();
            textBox77.Text = 8.ToString();
            textBox80.Text = 7.ToString();
            textBox81.Text = 9.ToString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time >= 0)
            {
                time = time + 1;


                if (time == 60)
                {
                    n = n + 1;
                    time = 0;
                }

                if (time <= 9)
                {
                    TimeLabel.Text = n + ":0" + time;
                }
                else
                {
                    TimeLabel.Text = n + ":" + time;
                }
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Start();
            startButton.Enabled = false;
            pauseButton.Enabled = true;

            
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            pauseButton.Enabled = false;
            timer1.Stop();
            startButton.Enabled = true;
        }
    }
}
