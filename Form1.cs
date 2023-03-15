using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            if((x > -15 || x < 0) && (y < 0 || y > -15))
            {
                a = "Нет";
            }
            else if((x >= -15 && x <= 0) && (y >= -15 && y <= 0 ))
            {
                a = "на границе";
            }
            else
            {
                a = "Внутри";
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
            int[] nums = { 2, 2, 2, 2, 2, 3, 4, 5, 6, 7, 2, 2, 2, 2, 2, 2, 3, 4, 5, 2, 2, 2, 1, 2, 3, 2, 2, 0, 1, 2, -1 };

            int count = 5;
            label5.Text = "";
            for (int i = 0; i < nums.Length; i++)
            {
                //Console.Write(nums[i] + " ");
                label5.Text += nums[i] + " ";
                count--;
                if (count == 0)
                {
                    label5.Text += "\n";
                    if (i < nums.Length - 1)
                    {
                        count = nums[i + 1];
                    }
                }
            }
        }
    }
}
