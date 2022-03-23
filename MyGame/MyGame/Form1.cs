using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int value1, value2;

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))
            {

            }
            else
                e.Handled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                if (Convert.ToInt32(textBox1.Text) + 10 <= Convert.ToInt32(label1.Text))
                {
                    textBox1.Text = (Convert.ToInt32(textBox1.Text) + 10).ToString();
                }
                else
                    textBox1.Text = label1.Text;
            }
            else
                if (10 <= Convert.ToInt32(label1.Text))
                    textBox1.Text = "10";
                else
                    textBox1.Text = label1.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                if (Convert.ToInt32(textBox1.Text) + 100 <= Convert.ToInt32(label1.Text))
                {
                    textBox1.Text = (Convert.ToInt32(textBox1.Text) + 100).ToString();
                }
                else
                    textBox1.Text = label1.Text;
            }
            else
                if (100 <= Convert.ToInt32(label1.Text))
                textBox1.Text = "100";
            else
                textBox1.Text = label1.Text;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                if (Convert.ToInt32(textBox1.Text) + 1000 <= Convert.ToInt32(label1.Text))
                {
                    textBox1.Text = (Convert.ToInt32(textBox1.Text) + 1000).ToString();
                }
                else
                    textBox1.Text = label1.Text;
            }
            else
               if (1000 <= Convert.ToInt32(label1.Text))
                textBox1.Text = "1000";
            else
                textBox1.Text = label1.Text;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                if (Convert.ToInt32(textBox1.Text) + 10000 <= Convert.ToInt32(label1.Text))
                {
                    textBox1.Text = (Convert.ToInt32(textBox1.Text) + 10000).ToString();
                }
                else
                    textBox1.Text = label1.Text;
            }
            else
               if (10000 <= Convert.ToInt32(label1.Text))
                textBox1.Text = "10000";
            else
                textBox1.Text = label1.Text;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                textBox1.Text = (Convert.ToInt32(textBox1.Text) * 1/2).ToString();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                if (Convert.ToInt32(textBox1.Text) * 2 <= Convert.ToInt32(label1.Text))
                {
                    textBox1.Text = (Convert.ToInt32(textBox1.Text) * 2).ToString();
                }
                else
                    textBox1.Text = label1.Text;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            textBox1.Text = label1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && Convert.ToInt32(textBox1.Text) <= Convert.ToInt32(label1.Text))
            {
                if (label10.Text != string.Empty)
                {
                    label10.Text = (Convert.ToInt32(label10.Text) + Convert.ToInt32(textBox1.Text)).ToString();
                    label1.Text = (Convert.ToInt32(label1.Text) - Convert.ToInt32(textBox1.Text)).ToString();
                }
                else
                {
                    label10.Text = textBox1.Text;
                    label1.Text = (Convert.ToInt32(label1.Text) - Convert.ToInt32(textBox1.Text)).ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && Convert.ToInt32(textBox1.Text) <= Convert.ToInt32(label1.Text))
            {
                if (label11.Text != string.Empty)
                {
                    label11.Text = (Convert.ToInt32(label11.Text) + Convert.ToInt32(textBox1.Text)).ToString();
                    label1.Text = (Convert.ToInt32(label1.Text) - Convert.ToInt32(textBox1.Text)).ToString();
                }
                else
                {
                    label11.Text = textBox1.Text;
                    label1.Text = (Convert.ToInt32(label1.Text) - Convert.ToInt32(textBox1.Text)).ToString();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X != 26 || pictureBox2.Location.X != 26)
            {
                pictureBox1.Location = new Point(26, pictureBox1.Location.Y);
                pictureBox2.Location = new Point(26, pictureBox2.Location.Y);
            }
            timer1.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Вычисление рандомных значений
            value1 = rnd.Next(1, 30);
            value2 = rnd.Next(1, 30);
            //Собственно бег
            pictureBox1.Location = new Point(pictureBox1.Location.X + value1, pictureBox1.Location.Y);
            pictureBox2.Location = new Point(pictureBox2.Location.X + value2, pictureBox2.Location.Y);
            //Определение победителя
            if (pictureBox1.Location.X + pictureBox1.Width >= 774 && pictureBox2.Location.X + pictureBox2.Width >= 774)
            {
                timer1.Enabled = false;
                MessageBox.Show("Ничья");
                if (label10.Text != string.Empty)
                {
                    label1.Text = (Convert.ToInt32(label1.Text) + (Convert.ToInt32(label10.Text) * 1/2)).ToString();
                }
                if (label11.Text != string.Empty)
                {
                    label1.Text = (Convert.ToInt32(label1.Text) + (Convert.ToInt32(label11.Text) * 1/2)).ToString();
                }
                label10.Text = string.Empty;
                label11.Text = string.Empty;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
            }
            else
            {
                if (pictureBox1.Location.X + pictureBox1.Width >= 774)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("Мурка выйграла!!!");
                    if (label10.Text != string.Empty)
                    {
                        label1.Text = (Convert.ToInt32(label1.Text) + Convert.ToInt32(label10.Text) + ((Convert.ToInt32(label10.Text) / 100) * 95)).ToString();
                    }
                    label10.Text = string.Empty;
                    label11.Text = string.Empty;
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                }
                if (pictureBox2.Location.X + pictureBox2.Width >= 774)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("Пусена выйграла!!!");
                    if (label11.Text != string.Empty)
                    {
                        label1.Text = (Convert.ToInt32(label1.Text) + Convert.ToInt32(label11.Text) + (Convert.ToInt32(label11.Text) / 100 * 95)).ToString();
                    }
                    label10.Text = string.Empty;
                    label11.Text = string.Empty;
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                }
            }
        }
    }
}
