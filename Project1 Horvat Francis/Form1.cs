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
        }

        // This function will reset the entire list of words into the
        // list box by filling in the listbox with elements
        private void initializeList()
        {
            // First check if the listbox has items
            
            if (gameWordList.Items.Count > 0)
            {
                // clear list
                gameWordList.Items.Clear();
            }

            // Fill in the list box

            for (int i = 0; i < wordList.Count; i++)
            {
                gameWordList.Items.Add(wordList.ElementAt(i));
            }

        }



        private void startButton_Click(object sender, EventArgs e)
        {
            if (this.startButton.Text == "GO!") {
                // Fill in the list box
            initializeList();
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
            // reset the game

            gameWordList.Items.Clear();
            resetAllComponents();
        }

        private void resetAllComponents()
        {
            // Set the button to "Go"
            startButton.Text = "GO!";
            // Set the reset the entire list
            Letter_1.Text = "@";
            Letter_2.Text = "@";
            Letter_3.Text = "@";
            Letter_4.Text = "@";
            Letter_5.Text = "@";

            // clear all button colors
            Letter_1.BackColor = Color.Empty;
            Letter_2.BackColor = Color.Empty;
            Letter_3.BackColor = Color.Empty;
            Letter_4.BackColor = Color.Empty;
            Letter_5.BackColor = Color.Empty;

            // clear all words
            gameWordList.Items.Clear();

            // Make buttons clickable again
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            checkBox4.Enabled = true;
            checkBox5.Enabled = true;


            // Clear the check boxes

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;





        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // If there is only one word left in the list then fill it;
            if (gameWordList.Items.Count == 1)
            {
                string word = gameWordList.Items[0].ToString();
                Letter_1.Text = Char.ToString(word[0]);
                Letter_2.Text = Char.ToString(word[1]);
                Letter_3.Text = Char.ToString(word[2]);
                Letter_4.Text = Char.ToString(word[3]);
                Letter_5.Text = Char.ToString(word[4]);

                Letter_1.BackColor = Color.Green;
                Letter_2.BackColor = Color.Green;
                Letter_3.BackColor = Color.Green;
                Letter_4.BackColor = Color.Green;
                Letter_5.BackColor = Color.Green;

                checkBox1.Checked = true;
                checkBox2.Checked = true;
                checkBox3.Checked = true;
                checkBox4.Checked = true;
                checkBox5.Checked = true;

            } else
            {
                getLetters();
            }

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


        // REFACTOR Checkbox logic if time permits.
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            searchWords(1);
            checkBoxes();
            checkBox1.Enabled = false;
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            searchWords(2);
            checkBoxes();
            checkBox2.Enabled = false;
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            searchWords(3);
            checkBoxes();
            checkBox3.Enabled = false;
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            searchWords(4);
            checkBoxes();
            checkBox4.Enabled = false;
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            searchWords(5);
            checkBoxes();
            checkBox5.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resetAllComponents();
        }

        public void searchWords(int position)
        {
            char one, two, three, four, five;

            one = Letter_1.Text[0];
            two = Letter_2.Text[0];
            three = Letter_3.Text[0];
            four = Letter_4.Text[0];
            five = Letter_5.Text[0];

            

            List<string> reloadList = new List<string>();

            // Save the previous state of the game list
            for (int i = gameWordList.Items.Count - 1; i > -1; i--)
            {
                reloadList.Add(gameWordList.Items[i].ToString());
            }



                // variable to keep track of the count of matching words found;
                int count = 0;

            switch (position) {

               

                case 1:
                    
                    for (int i =  gameWordList.Items.Count - 1; i > -1; i-- )
                    {
                        if ( gameWordList.Items[i].ToString()[0] == one )
                        {
                            Letter_1.BackColor = System.Drawing.Color.Green;
                            count++;
                        }
                        else
                        {
                                           

                            gameWordList.Items.Remove(gameWordList.Items[i].ToString());


                        }

                        // If no words were found make the box red
                        // reload the previous list as well
                        
                    }

                    if (count <= 0)
                    {
                        gameWordList.Items.Clear();
                        Letter_1.BackColor = System.Drawing.Color.Red;
                        for (int j = 0; j < reloadList.Count; j++)
                        {
                            if (reloadList.Count > 0)
                                gameWordList.Items.Add(reloadList.ElementAt(j));
                        }

                    }
                    break;

                case 2:

                    for (int i = gameWordList.Items.Count - 1; i > -1; i--)
                    {
                        if (gameWordList.Items[i].ToString()[1] == two)
                        {
                            Letter_2.BackColor = System.Drawing.Color.Green;
                            count++;
                        }
                        else
                        {


                            gameWordList.Items.Remove(gameWordList.Items[i].ToString());


                        }

                        // If no words were found make the box red
                        // reload the previous list as well

                    }

                    if (count <= 0)
                    {
                        gameWordList.Items.Clear();
                        Letter_2.BackColor = System.Drawing.Color.Red;
                        for (int j = 0; j < reloadList.Count; j++)
                        {
                            if (reloadList.Count > 0)
                                gameWordList.Items.Add(reloadList.ElementAt(j));
                        }

                    }
                    break;

                case 3:

                    for (int i = gameWordList.Items.Count - 1; i > -1; i--)
                    {
                        if (gameWordList.Items[i].ToString()[2] == three)
                        {
                            Letter_3.BackColor = System.Drawing.Color.Green;
                            count++;
                        }
                        else
                        {


                            gameWordList.Items.Remove(gameWordList.Items[i].ToString());


                        }

                        // If no words were found make the box red
                        // reload the previous list as well

                    }

                    if (count <= 0)
                    {
                        gameWordList.Items.Clear();
                        Letter_3.BackColor = System.Drawing.Color.Red;
                        for (int j = 0; j < reloadList.Count; j++)
                        {
                            if (reloadList.Count > 0)
                                gameWordList.Items.Add(reloadList.ElementAt(j));
                        }

                    }
                    break;

                case 4:

                    for (int i = gameWordList.Items.Count - 1; i > -1; i--)
                    {
                        if (gameWordList.Items[i].ToString()[3] == four)
                        {
                            Letter_4.BackColor = System.Drawing.Color.Green;
                            count++;
                        }
                        else
                        {


                            gameWordList.Items.Remove(gameWordList.Items[i].ToString());


                        }

                        // If no words were found make the box red
                        // reload the previous list as well

                    }

                    if (count <= 0)
                    {
                        gameWordList.Items.Clear();
                        Letter_4.BackColor = System.Drawing.Color.Red;
                        for (int j = 0; j < reloadList.Count; j++)
                        {
                            if (reloadList.Count > 0)
                                gameWordList.Items.Add(reloadList.ElementAt(j));
                        }

                    }
                    break;

                case 5:

                    for (int i = gameWordList.Items.Count - 1; i > -1; i--)
                    {
                        if (gameWordList.Items[i].ToString()[4] == five)
                        {
                            Letter_5.BackColor = System.Drawing.Color.Green;
                            count++;
                        }
                        else
                        {


                            gameWordList.Items.Remove(gameWordList.Items[i].ToString());


                        }

                        // If no words were found make the box red
                        // reload the previous list as well

                    }

                    if (count <= 0)
                    {
                        gameWordList.Items.Clear();
                        Letter_5.BackColor = System.Drawing.Color.Red;
                        for (int j = 0; j < reloadList.Count; j++)
                        {
                            if (reloadList.Count > 0)
                                gameWordList.Items.Add(reloadList.ElementAt(j));
                        }
                    }
                    break;
            }
        }
        
        //Checks to see if the user selected a word and displays a message
        public void checkBoxes()
        {
            if (Letter_1.BackColor == Color.Green && Letter_2.BackColor == Color.Green &&
                Letter_3.BackColor == Color.Green && Letter_4.BackColor == Color.Green &&
                Letter_5.BackColor == Color.Green)
            {
                MessageBox.Show("Congratulations you won!");               
            }
        }       
    }
}
