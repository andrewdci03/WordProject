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

        private List<string> wordList;

        static Random _random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(List<string> List)
        {
            wordList = new List<string>();
            this.wordList = List;
            InitializeComponent();
            this.gameWordList.DataSource = wordList;
        }

        public void refreshList()
        {

            this.gameWordList.DataSource = null;


            this.gameWordList.DataSource = wordList;
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

        private void getLetters()
        {
            if (!checkBox1.Checked)
            {
                Letter_1.Text = Char.ToString(GetLetter());
            } else
            {
                filterList( Letter_1.Text[0] , 0);
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


        // Filters our word list based on the character position and the value of the char
        public void filterList(char letter, int position)
        {
            for (int i = 0; i < wordList.Count ; i++)
            {
                String word = wordList.ElementAt(i);

                char a = word[position];

                if (letter == a)
                {
                    continue;
                }

                else
                {
                    this.wordList.Remove(word);
                    Debug.Print("removed " + word);
                }
 
            }

            refreshList();
        }
    }
}
