using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1_Horvat_Francis
{
    public partial class Form1 : Form
    {

        private List<string> curList, wordList;

        static Random _random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(List<string> List)
        {
            InitializeComponent();
            wordList = List;
            curList = new List<string>();

            for (int i = 0; i < List.Count; i++)
            {
                gameWordList.Items.Add(List.ElementAt(i));
            }
        }



        private void startButton_Click(object sender, EventArgs e)
        {
            if (this.startButton.Text == "GO!") { 
            getLetters();
            timer1.Enabled = true;
            this.startButton.Text = "Stop!";
            }

            else
            {
                startButton.Text = "GO!";
                timer1.Enabled = false;
            }

            
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            getLetters();
        }



        // This function will generate random characters in our text boxes as long as they are not clicked.
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
            return Char.ToUpper(let);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            searchWords(1);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            searchWords(2);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            searchWords(3);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            searchWords(4);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            searchWords(5);
        }

        public void searchWords(int position)
        {
            char one, two, three, four, five;

            one = Letter_1.Text[0];
            two = Letter_2.Text[0];
            three = Letter_3.Text[0];
            four = Letter_4.Text[0];
            five = Letter_5.Text[0];

            switch (position) {
                case 1:
                    
                    for (int i =  gameWordList.Items.Count - 1; i > -1; i-- )
                    {
                        if ( gameWordList.Items[i].ToString()[0] == one )
                        {
                            Letter_1.BackColor = System.Drawing.Color.Green;
                        }
                        else
                        {
                            gameWordList.Items.Remove(gameWordList.Items[i].ToString());
                        }
                    }
                    break;

                case 2:

                    for (int i = gameWordList.Items.Count - 1; i > -1; i--)
                    {
                        if (gameWordList.Items[i].ToString()[1] == two)
                        {
                            Letter_2.BackColor = System.Drawing.Color.Green;
                        }
                        else
                        {
                            gameWordList.Items.Remove(gameWordList.Items[i].ToString());
                        }
                    }
                    break;

                case 3:

                    for (int i = gameWordList.Items.Count - 1; i > -1; i--)
                    {
                        if (gameWordList.Items[i].ToString()[2] == three)
                        {
                            Letter_3.BackColor = System.Drawing.Color.Green;
                        }
                        else
                        {
                            gameWordList.Items.Remove(gameWordList.Items[i].ToString());
                        }
                    }
                    break;

                case 4:

                    for (int i = gameWordList.Items.Count - 1; i > -1; i--)
                    {
                        if (gameWordList.Items[i].ToString()[3] == four)
                        {
                            Letter_4.BackColor = System.Drawing.Color.Green;
                        }
                        else
                        {
                            gameWordList.Items.Remove(gameWordList.Items[i].ToString());
                        }
                    }
                    break;

                case 5:

                    for (int i = gameWordList.Items.Count - 1; i > -1; i--)
                    {
                        if (gameWordList.Items[i].ToString()[4] == five)
                        {
                            Letter_5.BackColor = System.Drawing.Color.Green;
                        }
                        else
                        {
                            gameWordList.Items.Remove(gameWordList.Items[i].ToString());
                        }
                    }
                    break;

            }

        }
       
    }
}
