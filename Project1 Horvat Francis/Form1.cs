﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1_Horvat_Francis
{
    public partial class Form1 : Form
    {
        static Random _random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            getLetters();
            timer1.Enabled = true;
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            getLetters();
        }

        private void getLetters()
        {
            if (!checkBox1.Checked)
            {
                Letter_1.Text = Char.ToString(GetLetter());
            }
            if (!checkBox2.Checked)
            {
                Letter_2.Text = Char.ToString(GetLetter());
            }
            if (!checkBox3.Checked)
            {
                Letter_3.Text = Char.ToString(GetLetter());
            }
            if (!checkBox4.Checked)
            {
                Letter_4.Text = Char.ToString(GetLetter());
            }
            if (!checkBox5.Checked)
            {
                Letter_5.Text = Char.ToString(GetLetter());
            }
        }

        public static char GetLetter()
        {
            // This method returns a random lowercase letter.
            // ... Between 'a' and 'z' inclusize.
            int num = _random.Next(0, 26); // Zero to 25
            char let = (char)('a' + num);
            return let;
        }
    }
}
