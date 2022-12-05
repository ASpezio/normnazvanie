using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double a = 0;
        double b = 0;
        double c = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                textBox4.Text = "Ошибка";
                textBox5.Text = "Ошибка";
                return;
            }
            
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);


            double D = b * b - 4 * a * c;//считаем дискриминант
            double x;

            if (D < 0)//если отрицательный, то корней нет
            {
                textBox4.Text = "Корней нет";
                textBox5.Text = "Корней нет";
                return;
            }
            else
            {
                if (D == 0)//если равен 0, то 1 корень.
                {
                    x = -b / (2 * a);
                    textBox4.Text = Convert.ToString(x);
                    textBox5.Text = Convert.ToString(x);
                    return;
                }
                else//иначе 2 корня
                {
                    x = (-b + Math.Sqrt(D)) / (2 * a);
                    textBox4.Text = Convert.ToString(x);

                    x = (-b - Math.Sqrt(D)) / (2 * a);
                    textBox5.Text = Convert.ToString(x);

                    return;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = 0;
            b = 0;
            c = 0;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
    }
}
