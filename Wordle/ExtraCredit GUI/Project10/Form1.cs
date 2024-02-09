using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project10
{
    public partial class Form1 : Form
    {
        public ArrayList wordsList = new ArrayList();
        string randomW;
        Words word = new Words();
        int key = 1;
        int guessNum = 1;
        public Form1()
        {
            InitializeComponent();
            readFile();


        }

        public void readFile()
        {
            using (StreamReader reader = new StreamReader("C:\\Users\\kushp\\Desktop\\words.txt"))
            {
                string line;
                int count = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    if (count != 0 && line.Length == 5)
                    {
                        this.wordsList.Add(line);
                    }
                    count++;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UxEnter_Click(object sender, EventArgs e)
        {

            int text = Convert.ToInt32(textBox2.Text);

            word.rNum(wordsList);
            randomW = word.word(wordsList);
            textBox3.Text = randomW;
            if (text == 1)
            {
                for (int i = 1; i <= 6; i++)
                {
                    Label l1 = new Label();
                    Label l2 = new Label();
                    l2.Text = "";
                    l1.Text = "Guess " + i;
                    TextBox guess = new TextBox();
                    flowLayoutPanel1.Controls.Add(l1);
                    flowLayoutPanel1.Controls.Add(l2);
                    flowLayoutPanel1.Controls.Add(guess);


                }
            }
            if (text == 2)
            {
                for (int i = 1; i <= 4; i++)
                {
                    Label l1 = new Label();
                    Label l2 = new Label();
                    l2.Text = "";
                    l1.Text = "Guess " + i;
                    TextBox guess = new TextBox();
                    flowLayoutPanel1.Controls.Add(l1);
                    flowLayoutPanel1.Controls.Add(l2);
                    flowLayoutPanel1.Controls.Add(guess);
                }
            }
            if (text == 3)
            {
                for (int i = 1; i <= 3; i++)
                {
                    Label l1 = new Label();
                    Label l2 = new Label();
                    l2.Text = "";
                    l1.Text = "Guess " + i;
                    TextBox guess = new TextBox();
                    flowLayoutPanel1.Controls.Add(l1);
                    flowLayoutPanel1.Controls.Add(l2);
                    flowLayoutPanel1.Controls.Add(guess);
                }
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            textBox3.Text = "";
            key = 1;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String gues = textBox4.Text;
            String guesup = gues.ToUpper();
            string res = word.check(randomW, guesup);
            if (res.Contains("*") || res.Contains("-"))
            {


                flowLayoutPanel1.Controls[key].Text = res;
                flowLayoutPanel1.Controls[key + 1].Text = guesup;

                flowLayoutPanel1.Controls[key - 1].Text = $"Guess {guessNum}";
                guessNum++;
            }
            else
            {
                flowLayoutPanel1.Controls[key + 1].Text = guesup;
                flowLayoutPanel1.Controls[key + 2].Text = "You Win";
            }
            key += 3;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
