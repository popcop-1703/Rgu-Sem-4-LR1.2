using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lr1._2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //1.1
        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double y = 0;
            y = Math.Log(Math.Abs(x-2));
            label1.Text = Convert.ToString(y);

        }
        //1.2
        private void button2_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox2.Text);
            int y = int.Parse(textBox3.Text);
            String a = "";
            if((x > -15 && x < 0) && (y < 0 && y > -15))
            {
                a = "Нет";
            }
            else if(((x >= -15 && x <= 0) && (y == 0 || y == -15)) || ((x == 0 || x == -15) && (y <= 0 && y >= -15)))
            {
                a = "на границе";
            }
            else
            {
                a = "да";
            }
            label2.Text = a;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string text = "";
            int speed = 0;
            text = textBox4.Text;
            if (text == "а")
            {
                speed = 60;
            }
            else if (text == "в") {
                speed = 20;
            }
            else if (text == "м")
            {
                speed = 40;
            }
            else if (text == "с")
            {
                speed = 200;
            }
            else if (text == "п")
            {
                speed = 120;
            }
            else
            {
                label3.Text = "Буква не нравится";
            }
            if(speed != 0)
            {
                label3.Text = text + " скорость =" + speed;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int number = 0;
            for (int i = 100; i < 1000; i++)
            {
                string s = i.ToString();
                if (s[0] == s[1] || s[0] == s[2] || s[1] == s[2])
                {
                    number++; //я решил сделать все в winform, поэтому не добавил вывод всех чисел
                }
            }
            label4.Text = number.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            int n = 5;
            int two = 2;
            int three = 2;
            for (int i = n; i >= 1; --i)
            {
                for (int j = 1; j <= i; j++)
                {
                    label5.Text += Convert.ToString(two);
                }
                label5.Text += "\n";
                for(int k = 1; k <= i; k++)
                {
                    label5.Text += Convert.ToString(three + k);
                }
                three--;
                label5.Text += "\n";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double a, b, h;
            a = double.Parse(textBox5.Text);
            b = double.Parse(textBox6.Text);
            h = double.Parse(textBox7.Text);
            double y;
            int i = 1;
            label9.Text = "";
            label9.Text += "# " + "x " + "f(x) " + "\n";
            for (double x = a; x <= b; x += h, ++i)
            {
                if ((x+2) <= 1)
                {
                    y = Math.Pow(x,2);
                }
                else if((x+2) > 1 && (x+2) < 10)
                {
                    y = 1/(x+2);
                }
                else
                {
                    y = x + 2;
                }
                
                label9.Text += i + " " +  x + " " + y + "\n";
            }
        }
    }
}
