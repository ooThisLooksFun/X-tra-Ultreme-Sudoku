﻿using System;
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

        int[,] gridboard = new int[9, 9];

        // Integer Time
        int time = 0;
        int n = 0;
      
        int x = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public void Start()
        {

            textBox1.Text = 5.ToString();
            textBox1.Enabled = false;

            textBox2.Text = 3.ToString();
            textBox2.Enabled = false;

            textBox5.Text = 7.ToString();
            textBox5.Enabled = false;

            textBox10.Text = 6.ToString();
            textBox10.Enabled = false;

            textBox13.Text = 1.ToString();
            textBox13.Enabled = false;

            textBox14.Text = 9.ToString();
            textBox14.Enabled = false;

            textBox15.Text = 5.ToString();
            textBox15.Enabled = false;

            textBox20.Text = 9.ToString();
            textBox20.Enabled = false;

            textBox21.Text = 8.ToString();
            textBox21.Enabled = false;

            textBox26.Text = 6.ToString();
            textBox26.Enabled = false;

            textBox28.Text = 8.ToString();
            textBox28.Enabled = false;

            textBox32.Text = 6.ToString();
            textBox32.Enabled = false;

            textBox36.Text = 3.ToString();
            textBox36.Enabled = false;

            textBox37.Text = 4.ToString();
            textBox37.Enabled = false;

            textBox40.Text = 8.ToString();
            textBox40.Enabled = false;

            textBox42.Text = 3.ToString();
            textBox42.Enabled = false;

            textBox45.Text = 1.ToString();
            textBox45.Enabled = false;

            textBox46.Text = 7.ToString();
            textBox46.Enabled = false;

            textBox50.Text = 2.ToString();
            textBox50.Enabled = false;

            textBox54.Text = 6.ToString();
            textBox54.Enabled = false;

            textBox56.Text = 6.ToString();
            textBox56.Enabled = false;

            textBox61.Text = 2.ToString();
            textBox61.Enabled = false;

            textBox62.Text = 8.ToString();
            textBox62.Enabled = false;

            textBox67.Text = 4.ToString();
            textBox67.Enabled = false;

            textBox68.Text = 1.ToString();
            textBox68.Enabled = false;

            textBox69.Text = 9.ToString();
            textBox69.Enabled = false;

            textBox72.Text = 5.ToString();
            textBox72.Enabled = false;

            textBox77.Text = 8.ToString();
            textBox77.Enabled = false;

            textBox80.Text = 7.ToString();
            textBox80.Enabled = false;

            textBox81.Text = 9.ToString();
            textBox81.Enabled = false;

        }

        public void disable()
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox11.Enabled = false;
            textBox12.Enabled = false;
            textBox13.Enabled = false;
            textBox14.Enabled = false;
            textBox15.Enabled = false;
            textBox16.Enabled = false;
            textBox17.Enabled = false;
            textBox18.Enabled = false;
            textBox19.Enabled = false;
            textBox20.Enabled = false;
            textBox21.Enabled = false;
            textBox22.Enabled = false;
            textBox23.Enabled = false;
            textBox24.Enabled = false;
            textBox25.Enabled = false;
            textBox27.Enabled = false;
            textBox28.Enabled = false;
            textBox29.Enabled = false;
            textBox30.Enabled = false;
            textBox31.Enabled = false;
            textBox32.Enabled = false;
            textBox33.Enabled = false;
            textBox34.Enabled = false;
            textBox35.Enabled = false;
            textBox36.Enabled = false;
            textBox37.Enabled = false;
            textBox38.Enabled = false;
            textBox39.Enabled = false;
            textBox40.Enabled = false;
            textBox41.Enabled = false;
            textBox42.Enabled = false;
            textBox43.Enabled = false;
            textBox44.Enabled = false;
            textBox45.Enabled = false;
            textBox46.Enabled = false;
            textBox47.Enabled = false;
            textBox48.Enabled = false;
            textBox49.Enabled = false;
            textBox51.Enabled = false;
            textBox52.Enabled = false;
            textBox53.Enabled = false;
            textBox55.Enabled = false;
            textBox57.Enabled = false;
            textBox58.Enabled = false;
            textBox59.Enabled = false;
            textBox60.Enabled = false;
            textBox63.Enabled = false;
            textBox64.Enabled = false;
            textBox65.Enabled = false;
            textBox66.Enabled = false;
            textBox70.Enabled = false;
            textBox71.Enabled = false;
            textBox73.Enabled = false;
            textBox74.Enabled = false;
            textBox75.Enabled = false;
            textBox76.Enabled = false;
            textBox78.Enabled = false;
            textBox79.Enabled = false;
        }

        public void invisible()
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            textBox15.Visible = false;
            textBox16.Visible = false;
            textBox17.Visible = false;
            textBox18.Visible = false;
            textBox19.Visible = false;
            textBox20.Visible = false;
            textBox21.Visible = false;
            textBox22.Visible = false;
            textBox23.Visible = false;
            textBox24.Visible = false;
            textBox25.Visible = false;
            textBox26.Visible = false;
            textBox27.Visible = false;
            textBox28.Visible = false;
            textBox29.Visible = false;
            textBox30.Visible = false;
            textBox31.Visible = false;
            textBox32.Visible = false;
            textBox33.Visible = false;
            textBox34.Visible = false;
            textBox35.Visible = false;
            textBox36.Visible = false;
            textBox37.Visible = false;
            textBox38.Visible = false;
            textBox39.Visible = false;
            textBox40.Visible = false;
            textBox41.Visible = false;
            textBox42.Visible = false;
            textBox43.Visible = false;
            textBox44.Visible = false;
            textBox45.Visible = false;
            textBox46.Visible = false;
            textBox47.Visible = false;
            textBox48.Visible = false;
            textBox49.Visible = false;
            textBox50.Visible = false;
            textBox51.Visible = false;
            textBox52.Visible = false;
            textBox53.Visible = false;
            textBox54.Visible = false;
            textBox55.Visible = false;
            textBox56.Visible = false;
            textBox57.Visible = false;
            textBox58.Visible = false;
            textBox59.Visible = false;
            textBox60.Visible = false;
            textBox61.Visible = false;
            textBox62.Visible = false;
            textBox63.Visible = false;
            textBox64.Visible = false;
            textBox65.Visible = false;
            textBox66.Visible = false;
            textBox67.Visible = false;
            textBox68.Visible = false;
            textBox69.Visible = false;
            textBox70.Visible = false;
            textBox71.Visible = false;
            textBox72.Visible = false;
            textBox73.Visible = false;
            textBox74.Visible = false;
            textBox75.Visible = false;
            textBox76.Visible = false;
            textBox77.Visible = false;
            textBox78.Visible = false;
            textBox79.Visible = false;
            textBox80.Visible = false;
            textBox81.Visible = false;
        }

        public void visible()
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            textBox10.Visible = true;
            textBox11.Visible = true;
            textBox12.Visible = true;
            textBox13.Visible = true;
            textBox14.Visible = true;
            textBox15.Visible = true;
            textBox16.Visible = true;
            textBox17.Visible = true;
            textBox18.Visible = true;
            textBox19.Visible = true;
            textBox20.Visible = true;
            textBox21.Visible = true;
            textBox22.Visible = true;
            textBox23.Visible = true;
            textBox24.Visible = true;
            textBox25.Visible = true;
            textBox26.Visible = true;
            textBox27.Visible = true;
            textBox28.Visible = true;
            textBox29.Visible = true;
            textBox30.Visible = true;
            textBox31.Visible = true;
            textBox32.Visible = true;
            textBox33.Visible = true;
            textBox34.Visible = true;
            textBox35.Visible = true;
            textBox36.Visible = true;
            textBox37.Visible = true;
            textBox38.Visible = true;
            textBox39.Visible = true;
            textBox40.Visible = true;
            textBox41.Visible = true;
            textBox42.Visible = true;
            textBox43.Visible = true;
            textBox44.Visible = true;
            textBox45.Visible = true;
            textBox46.Visible = true;
            textBox47.Visible = true;
            textBox48.Visible = true;
            textBox49.Visible = true;
            textBox50.Visible = true;
            textBox51.Visible = true;
            textBox52.Visible = true;
            textBox53.Visible = true;
            textBox54.Visible = true;
            textBox55.Visible = true;
            textBox56.Visible = true;
            textBox57.Visible = true;
            textBox58.Visible = true;
            textBox59.Visible = true;
            textBox60.Visible = true;
            textBox61.Visible = true;
            textBox62.Visible = true;
            textBox63.Visible = true;
            textBox64.Visible = true;
            textBox65.Visible = true;
            textBox66.Visible = true;
            textBox67.Visible = true;
            textBox68.Visible = true;
            textBox69.Visible = true;
            textBox70.Visible = true;
            textBox71.Visible = true;
            textBox72.Visible = true;
            textBox73.Visible = true;
            textBox74.Visible = true;
            textBox75.Visible = true;
            textBox76.Visible = true;
            textBox77.Visible = true;
            textBox78.Visible = true;
            textBox79.Visible = true;
            textBox80.Visible = true;
            textBox81.Visible = true;
        }

        public void enable()
        {
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            textBox9.Enabled = true;
            textBox11.Enabled = true;
            textBox12.Enabled = true;
            textBox16.Enabled = true;
            textBox17.Enabled = true;
            textBox18.Enabled = true;
            textBox19.Enabled = true;
            textBox22.Enabled = true;
            textBox23.Enabled = true;
            textBox24.Enabled = true;
            textBox25.Enabled = true;
            textBox27.Enabled = true;
            textBox29.Enabled = true;
            textBox30.Enabled = true;
            textBox31.Enabled = true;
            textBox33.Enabled = true;
            textBox34.Enabled = true;
            textBox35.Enabled = true;
            textBox38.Enabled = true;
            textBox39.Enabled = true;
            textBox41.Enabled = true;
            textBox43.Enabled = true;
            textBox44.Enabled = true;
            textBox47.Enabled = true;
            textBox48.Enabled = true;
            textBox49.Enabled = true;
            textBox51.Enabled = true;
            textBox52.Enabled = true;
            textBox53.Enabled = true;
            textBox55.Enabled = true;
            textBox57.Enabled = true;
            textBox58.Enabled = true;
            textBox59.Enabled = true;
            textBox60.Enabled = true;
            textBox63.Enabled = true;
            textBox64.Enabled = true;
            textBox65.Enabled = true;
            textBox66.Enabled = true;
            textBox70.Enabled = true;
            textBox71.Enabled = true;
            textBox73.Enabled = true;
            textBox74.Enabled = true;
            textBox75.Enabled = true;
            textBox76.Enabled = true;
            textBox78.Enabled = true;
            textBox79.Enabled = true;
        }

        public void Check()
        {
            Boolean er = true; 
            int[,] solution = new int[,]
            {
                {5, 3, 4, 6, 7, 8, 9, 1, 2 },
                {6, 7, 2, 1, 9, 5, 3, 4, 8 },
                {1, 9, 8, 3, 4, 2, 5, 6, 7 },
                {8, 5, 9, 7, 6, 1, 4, 2, 3 },
                {4, 2, 6, 8, 5, 3, 7, 9, 1 },
                {7, 1, 3, 9, 2, 4, 8, 5, 6 },
                {9, 6, 1, 5, 3, 7, 2, 8, 4 },
                {2, 8, 7, 4, 1, 9, 6, 3, 5 },
                {3, 4, 5, 2, 8, 6, 1, 7, 9 },
            };

            for (int x = 0; x < 9; x++)
            {
                for(int y = 0; y < 9; y++)
                {
                    if (solution[x, y] != gridboard[x, y])
                    {
                        er = false;
                       goto break1;
                    }
                    else
                    {
                        er = true;
                    }
                }
            }

            if (er == true)
            {
                goto break2;
            }
        break1:

            if (er == false)
            {
                MessageBox.Show("Board is not Solved, Keep Trying");
            }

        break2:

            if (er == true)
            {
                MessageBox.Show("You have Completed the puzzle");
            }
        }
        


        public int inputToNumb(string input)
        {
            if (input.Equals("1"))
                return 1;
            else if (input.Equals("2"))
                return 2;
            else if (input.Equals("3"))
                return 3;
            else if (input.Equals("4"))
                return 4;
            else if (input.Equals("5"))
                return 5;
            else if (input.Equals("6"))
                return 6;
            else if (input.Equals("7"))
                return 7;
            else if (input.Equals("8"))
                return 8;
            else
                return 9;
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
            visible();
            pictureBox1.Visible = false;
            startButton.Enabled = false;
            pauseButton.Enabled = true;
            checkButton.Enabled = true;
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            pauseButton.Enabled = false;
            timer1.Stop();
            startButton.Enabled = true;
            invisible();
            checkButton.Enabled = false;
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            gridboard[0, 0] = inputToNumb(textBox1.Text);
            gridboard[0, 1] = inputToNumb(textBox2.Text);
            gridboard[0, 2] = inputToNumb(textBox3.Text);
            gridboard[0, 3] = inputToNumb(textBox4.Text);
            gridboard[0, 4] = inputToNumb(textBox5.Text);
            gridboard[0, 5] = inputToNumb(textBox6.Text);
            gridboard[0, 6] = inputToNumb(textBox7.Text);
            gridboard[0, 7] = inputToNumb(textBox8.Text);
            gridboard[0, 8] = inputToNumb(textBox9.Text);

            gridboard[1, 0] = inputToNumb(textBox10.Text);
            gridboard[1, 1] = inputToNumb(textBox11.Text);
            gridboard[1, 2] = inputToNumb(textBox12.Text);
            gridboard[1, 3] = inputToNumb(textBox13.Text);
            gridboard[1, 4] = inputToNumb(textBox14.Text);
            gridboard[1, 5] = inputToNumb(textBox15.Text);
            gridboard[1, 6] = inputToNumb(textBox16.Text);
            gridboard[1, 7] = inputToNumb(textBox17.Text);
            gridboard[1, 8] = inputToNumb(textBox18.Text);

            gridboard[2, 0] = inputToNumb(textBox19.Text);
            gridboard[2, 1] = inputToNumb(textBox20.Text);
            gridboard[2, 2] = inputToNumb(textBox21.Text);
            gridboard[2, 3] = inputToNumb(textBox22.Text);
            gridboard[2, 4] = inputToNumb(textBox23.Text);
            gridboard[2, 5] = inputToNumb(textBox24.Text);
            gridboard[2, 6] = inputToNumb(textBox25.Text);
            gridboard[2, 7] = inputToNumb(textBox26.Text);
            gridboard[2, 8] = inputToNumb(textBox27.Text);

            gridboard[3, 0] = inputToNumb(textBox28.Text);
            gridboard[3, 1] = inputToNumb(textBox29.Text);
            gridboard[3, 2] = inputToNumb(textBox30.Text);
            gridboard[3, 3] = inputToNumb(textBox31.Text);
            gridboard[3, 4] = inputToNumb(textBox32.Text);
            gridboard[3, 5] = inputToNumb(textBox33.Text);
            gridboard[3, 6] = inputToNumb(textBox34.Text);
            gridboard[3, 7] = inputToNumb(textBox35.Text);
            gridboard[3, 8] = inputToNumb(textBox36.Text);

            gridboard[4, 0] = inputToNumb(textBox37.Text);
            gridboard[4, 1] = inputToNumb(textBox38.Text);
            gridboard[4, 2] = inputToNumb(textBox39.Text);
            gridboard[4, 3] = inputToNumb(textBox40.Text);
            gridboard[4, 4] = inputToNumb(textBox41.Text);
            gridboard[4, 5] = inputToNumb(textBox42.Text);
            gridboard[4, 6] = inputToNumb(textBox43.Text);
            gridboard[4, 7] = inputToNumb(textBox44.Text);
            gridboard[4, 8] = inputToNumb(textBox45.Text);

            gridboard[5, 0] = inputToNumb(textBox46.Text);
            gridboard[5, 1] = inputToNumb(textBox47.Text);
            gridboard[5, 2] = inputToNumb(textBox48.Text);
            gridboard[5, 3] = inputToNumb(textBox49.Text);
            gridboard[5, 4] = inputToNumb(textBox50.Text);
            gridboard[5, 5] = inputToNumb(textBox51.Text);
            gridboard[5, 6] = inputToNumb(textBox52.Text);
            gridboard[5, 7] = inputToNumb(textBox53.Text);
            gridboard[5, 8] = inputToNumb(textBox54.Text);

            gridboard[6, 0] = inputToNumb(textBox55.Text);
            gridboard[6, 1] = inputToNumb(textBox56.Text);
            gridboard[6, 2] = inputToNumb(textBox57.Text);
            gridboard[6, 3] = inputToNumb(textBox58.Text);
            gridboard[6, 4] = inputToNumb(textBox59.Text);
            gridboard[6, 5] = inputToNumb(textBox60.Text);
            gridboard[6, 6] = inputToNumb(textBox61.Text);
            gridboard[6, 7] = inputToNumb(textBox62.Text);
            gridboard[6, 8] = inputToNumb(textBox63.Text);

            gridboard[7, 0] = inputToNumb(textBox64.Text);
            gridboard[7, 1] = inputToNumb(textBox65.Text);
            gridboard[7, 2] = inputToNumb(textBox66.Text);
            gridboard[7, 3] = inputToNumb(textBox67.Text);
            gridboard[7, 4] = inputToNumb(textBox68.Text);
            gridboard[7, 5] = inputToNumb(textBox69.Text);
            gridboard[7, 6] = inputToNumb(textBox70.Text);
            gridboard[7, 7] = inputToNumb(textBox71.Text);
            gridboard[7, 8] = inputToNumb(textBox72.Text);

            gridboard[8, 0] = inputToNumb(textBox73.Text);
            gridboard[8, 1] = inputToNumb(textBox74.Text);
            gridboard[8, 2] = inputToNumb(textBox75.Text);
            gridboard[8, 3] = inputToNumb(textBox76.Text);
            gridboard[8, 4] = inputToNumb(textBox77.Text);
            gridboard[8, 5] = inputToNumb(textBox78.Text);
            gridboard[8, 6] = inputToNumb(textBox79.Text);
            gridboard[8, 7] = inputToNumb(textBox80.Text);
            gridboard[8, 8] = inputToNumb(textBox81.Text);

            Check();

        }

        private void btnChangeForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            SudokuSet1.Form2 f2 = new SudokuSet1.Form2();
            f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            themeSelecter();
            invisible();
            checkButton.Enabled = false;
            startButton.Enabled = true;
            pauseButton.Enabled = false;
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YOU QUIT, WHAT A LOOOOSER");
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
