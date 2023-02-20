using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pt2_try
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void letterClick(Button letterGiven, TextBox letterAnswer1, TextBox letterAnswer2, TextBox letterAnswer3, TextBox letterAnswer4)
        { 
            if (letterAnswer1.Text == string.Empty)
            {
                letterAnswer1.Text = letterGiven.Text;
                letterGiven.Hide();
            }else if (letterAnswer2.Text == string.Empty)
            {
                letterAnswer2.Text = letterGiven.Text;
                letterGiven.Hide();
            }else if (letterAnswer3.Text == string.Empty)
            {
                letterAnswer3.Text = letterGiven.Text;
                letterGiven.Hide();
            }else if (letterAnswer4.Text == string.Empty)
            {
                letterAnswer4.Text = letterGiven.Text;
                letterGiven.Hide();
            }
        }
        private void letterBack(TextBox letterAnswer, Button b1, Button b2, Button b3, Button b4, Button b5, Button b6, Button b7, Button b8, Button b9, Button b10, Button b11, Button b12)
        {
            if (letterAnswer.Text == b1.Text)
            {
                letterAnswer.Clear();
                b1.Show();
            }else if (letterAnswer.Text == b2.Text)
            {
                letterAnswer.Clear();
                b2.Show();
            }else if (letterAnswer.Text == b3.Text)
            {
                letterAnswer.Clear();
                b3.Show();
            }else if (letterAnswer.Text == b4.Text)
            {
                letterAnswer.Clear();
                b4.Show();
            }else if (letterAnswer.Text == b5.Text)
            {
                letterAnswer.Clear();
                b5.Show();
            }else if (letterAnswer.Text == b6.Text)
            {
                letterAnswer.Clear();
                b6.Show();
            }else if (letterAnswer.Text == b7.Text)
            {
                letterAnswer.Clear();
                b7.Show();
            }else if (letterAnswer.Text == b8.Text)
            {
                letterAnswer.Clear();
                b8.Show();
            }else if (letterAnswer.Text == b9.Text)
            {
                letterAnswer.Clear();
                b9.Show();
            }else if (letterAnswer.Text == b10.Text)
            {
                letterAnswer.Clear();
                b10.Show();
            }else if (letterAnswer.Text == b11.Text)
            {
                letterAnswer.Clear();
                b11.Show();
            }else if (letterAnswer.Text == b12.Text)
            {
                letterAnswer.Clear();
                b12.Show();
            }
        }
        private void checkAnswer(TextBox letterAnswer1, TextBox letterAnswer2, TextBox letterAnswer3, TextBox letterAnswer4)
        {
            string answer = letterAnswer1.Text + letterAnswer2.Text + letterAnswer3.Text + letterAnswer4.Text;
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty && textBox3.Text != string.Empty && textBox4.Text != string.Empty)
            {
                MessageBox.Show(answer == "RACE" ? "Your answer is Correct!" : "Sorry, your answer is Incorrect!", "Result");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            letterClick(button1, textBox1, textBox2, textBox3, textBox4);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            letterClick(button2, textBox1, textBox2, textBox3, textBox4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            letterClick(button3, textBox1, textBox2, textBox3, textBox4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            letterClick(button4, textBox1, textBox2, textBox3, textBox4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            letterClick(button5, textBox1, textBox2, textBox3, textBox4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            letterClick(button6, textBox1, textBox2, textBox3, textBox4);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            letterClick(button7, textBox1, textBox2, textBox3, textBox4);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            letterClick(button8, textBox1, textBox2, textBox3, textBox4);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            letterClick(button9, textBox1, textBox2, textBox3, textBox4);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            letterClick(button10, textBox1, textBox2, textBox3, textBox4);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            letterClick(button11, textBox1, textBox2, textBox3, textBox4);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            letterClick(button12, textBox1, textBox2, textBox3, textBox4);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            letterBack(textBox1, button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12);
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            letterBack(textBox2, button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12);
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            letterBack(textBox3, button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12);
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            letterBack(textBox4, button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            checkAnswer(textBox1, textBox2, textBox3, textBox4);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            checkAnswer(textBox1, textBox2, textBox3, textBox4);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            checkAnswer(textBox1, textBox2, textBox3, textBox4);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            checkAnswer(textBox1, textBox2, textBox3, textBox4);
        }
    }
}