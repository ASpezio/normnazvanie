using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ConsoleApp3;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ConsoleApp1;
using WorkWithClass;
using Project_K;



namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        double a, b, c, R, rezultat;
        int rez;
        public Form1()
        {
            InitializeComponent();
           /* SetRoundedShape(control: textBox1, radius: 50); // Округление окна
            SetRoundedShape(control: button0, radius: 50);
            SetRoundedShape(control: button1, radius: 50);
            SetRoundedShape(control: button2, radius: 50);
            SetRoundedShape(control: button3, radius: 50);
            SetRoundedShape(control: button4, radius: 50);
            SetRoundedShape(control: button5, radius: 50);
            SetRoundedShape(control: button6, radius: 50);
            SetRoundedShape(control: button7, radius: 50);
            SetRoundedShape(control: button8, radius: 50);
            SetRoundedShape(control: button9, radius: 50);
            SetRoundedShape(control: buttonsumm, radius: 50);
            SetRoundedShape(control: buttonmin, radius: 50);
            SetRoundedShape(control: buttonpro, radius: 50);
            SetRoundedShape(control: buttondel, radius: 50);
            SetRoundedShape(control: buttonzap, radius: 50);
            SetRoundedShape(control: buttonproc, radius: 50);
            SetRoundedShape(control: buttonrav, radius: 50);
            SetRoundedShape(control: buttondelete, radius: 50);
            SetRoundedShape(control: button10, radius: 50);
            SetRoundedShape(control: button11, radius: 50);
            SetRoundedShape(control: button12, radius: 50);
            SetRoundedShape(control: button13, radius: 50);
            SetRoundedShape(control: button14, radius: 50);
            SetRoundedShape(control: button15, radius: 50);
            SetRoundedShape(control: button16, radius: 50);
            SetRoundedShape(control: button17, radius: 50);
            SetRoundedShape(control: button18, radius: 50);*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "01")
            {
                textBox1.Text = "1";
            }
            else if (textBox1.Text == "02")
            {
                textBox1.Text = "2";
            }
            else if (textBox1.Text == "03")
            {
                textBox1.Text = "3";
            }
            else if (textBox1.Text == "04")
            {
                textBox1.Text = "4";
            }
            else if (textBox1.Text == "05")
            {
                textBox1.Text = "5";
            }
            else if (textBox1.Text == "06")
            {
                textBox1.Text = "6";
            }
            else if (textBox1.Text == "07")
            {
                textBox1.Text = "7";
            }
            else if (textBox1.Text == "08")
            {
                textBox1.Text = "8";
            }
            else if (textBox1.Text == "09")
            {
                textBox1.Text = "9";
            }
            textBox1.ReadOnly = true; //запрет ввода с клавиатуры
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
            if (textBox1.Text == "00")
            {
                textBox1.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }
        private void buttonplusminus_Click(object sender, EventArgs e)
        {
            try
            {
                double rez = double.Parse(textBox1.Text);
                rez = rez * -1;
                textBox1.Text = rez.ToString();
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void buttonzap_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
                textBox1.Text = textBox1.Text + ",";
        }

        private void buttonsumm_Click(object sender, EventArgs e)
        {
            if (a != 0 && b != 0 || a !=0 || b != 0)
            {
                rezultat = a + b;
                textBox1.Text = rezultat.ToString();
                label1.Text = "Ответ: " + rezultat;
            }
            else
            {
                try
                {
                    a = double.Parse(textBox1.Text);
                    textBox1.Clear();
                    rez = 1;
                    label1.Text = a.ToString() + "+";
                }
                catch
                {
                    MessageBox.Show("Ошибка");
                }
            }
        }

        private void buttonmin_Click(object sender, EventArgs e)
        {
            if (a != 0 && b != 0 || a != 0 || b != 0)
            {
                rezultat = a - b;
                textBox1.Text = rezultat.ToString();
                label1.Text = "Ответ: " + rezultat;
            }
            else
            {
                try
                {
                    a = double.Parse(textBox1.Text);
                    textBox1.Clear();
                    rez = 2;
                    label1.Text = a.ToString() + "-";
                }
                catch
                {
                    MessageBox.Show("Ошибка");
                }
            }
        }

        private void buttonpro_Click(object sender, EventArgs e)
        {
            if (a != 0 && b != 0 || a != 0 || b != 0)
            {
                rezultat = a * b;
                textBox1.Text = rezultat.ToString();
                label1.Text = "Ответ: " + rezultat;
            }
            else
            {
                try
                {
                    a = double.Parse(textBox1.Text);
                    textBox1.Clear();
                    rez = 3;
                    label1.Text = a.ToString() + " *";
                }
                catch
                {
                    MessageBox.Show("Ошибка");
                }
            }
        }

        private void buttondel_Click(object sender, EventArgs e)
        {
            if (a != 0 && b != 0 || a != 0)
            {
                rezultat = a/b;
                textBox1.Text = rezultat.ToString();
                label1.Text = "Ответ: " + rezultat;
            }
            else
            {
                try
                {
                    a = double.Parse(textBox1.Text);
                    textBox1.Clear();
                    rez = 4;
                    label1.Text = a.ToString() + "/";
                }
                catch
                {
                    MessageBox.Show("Ошибка");
                }
            }
        }

        private void buttonproc_Click(object sender, EventArgs e)
        {
            if (a != 0 && b != 0 || a != 0)
            {
                rezultat = (a * b)/100;
                textBox1.Text = rezultat.ToString();
                label1.Text = "Ответ: " + rezultat;
            }
            else
            {
                try
                {
                    a = double.Parse(textBox1.Text);
                    textBox1.Clear();
                    rez = 5;
                    label1.Text = a.ToString();
                }
                catch
                {
                    MessageBox.Show("Ошибка");
                }
            }
        }

        private void buttonrav_Click(object sender, EventArgs e)
        {
            string otvet;
            label1.Text = textBox1.Text;
            switch (rez)
            {
                case 1:
                    rezultat = a + double.Parse(textBox1.Text);
                    textBox1.Text = rezultat.ToString();
                    label1.Text = "Ответ: " + rezultat;
                    break;
                case 2:
                    rezultat = a - double.Parse(textBox1.Text);
                    textBox1.Text = rezultat.ToString();
                    label1.Text = "Ответ: " + rezultat;
                    break;
                case 3:
                    rezultat = a * double.Parse(textBox1.Text);
                    textBox1.Text = rezultat.ToString();
                    label1.Text = "Ответ: " + rezultat;
                    break;
                case 4:
                    if (double.Parse(textBox1.Text) == 0)
                    { textBox1.Text = "Error";
                      label1.Text = "Ответ: " + "Error";
                    }
                    else
                    {
                        rezultat = a / double.Parse(textBox1.Text);
                        textBox1.Text = rezultat.ToString();
                        label1.Text = "Ответ: " + rezultat;
                    }
                    break;
                case 5:
                    rezultat = (a * double.Parse(textBox1.Text)) / 100;
                    label1.Text = "Ответ: " + rezultat;
                    break;
                case 6:
                    rezultat = Matan.MatPrTr(a, b);
                    textBox1.Text = rezultat.ToString();
                    label1.Text = "Ответ: " + rezultat;
                    break;
                case 7:
                    rezultat = Matan.MatOpOkr(R);
                    textBox1.Text = rezultat.ToString();
                    label1.Text = "Ответ: " + rezultat;
                    break;
                case 8:
                    rezultat = Matan.MatStor(a);
                    textBox1.Text = rezultat.ToString();
                    label1.Text = "Ответ: " + rezultat;
                    break;
                case 9:
                    rezultat = Matan.MatRadTr(a, b, c, R);
                    textBox1.Text = rezultat.ToString();
                    label1.Text = "Ответ: " + rezultat;
                    break;
                case 11:
                    otvet = QuadraticEquation.Korni(a.ToString(), b.ToString(), c.ToString());
                    textBox1.Text = otvet;
                    label1.Text = "Ответ: " + otvet;
                    break;
                case 10:
                    Physics ph = new Physics(a, b, c);
                    rezultat = ph.FormV();
                    textBox1.Text = rezultat.ToString();
                    label1.Text = "Ответ: " + rezultat;
                    break;
                case 12:
                    Physics ph1 = new Physics(a, b, c);
                    rezultat = ph1.FormV0();
                    textBox1.Text = rezultat.ToString();
                    label1.Text = "Ответ: " + rezultat;
                    break;
                case 13:
                    Physics ph2 = new Physics(a, b, c);
                    rezultat = ph2.FormA();
                    textBox1.Text = rezultat.ToString();
                    label1.Text = "Ответ: " + rezultat;
                    break;
                case 14:
                    Physics ph3 = new Physics(a, b, c);
                    rezultat = ph3.FormT();
                    textBox1.Text = rezultat.ToString();
                    label1.Text = "Ответ: " + rezultat;
                    break;
                case 15:
                    rezultat = FSY.MathSokr(a, b);
                    textBox1.Text = rezultat.ToString();
                    label1.Text = "Ответ: " + rezultat;
                    break;
                case 16:
                    rezultat = FSY.MathSo(a, b);
                    textBox1.Text = rezultat.ToString();
                    label1.Text = "Ответ: " + rezultat;
                    break;
                case 17:
                    rezultat = algebr.SummaKub(a, b);
                    textBox1.Text = rezultat.ToString();
                    label1.Text = "Ответ: " + rezultat;
                    break;
                case 18:
                    rezultat = algebr.Rasnos(a, b);
                    textBox1.Text = rezultat.ToString();
                    label1.Text = "Ответ: " + rezultat;
                    break;

                default:
                    break;
            }
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
            a = double.Parse("0");
            b = double.Parse("0");
            c = double.Parse("0");
            R = double.Parse("0");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            label1.Text = "a =" + a.ToString() + ";" + "b =" + b.ToString() + ";" + "c =" + c.ToString() + ";" + "R =" + R.ToString();
            textBox1.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            b = double.Parse(textBox1.Text);
            label1.Text = "a =" + a.ToString() + ";" + "b =" + b.ToString() + ";" + "c =" + c.ToString() + ";" + "R =" + R.ToString();
            textBox1.Text = "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            c = double.Parse(textBox1.Text);
            label1.Text = "a =" + a.ToString() + ";" + "b =" + b.ToString() + ";" + "c =" + c.ToString() + ";" + "R =" + R.ToString();
            textBox1.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            R = double.Parse(textBox1.Text);
            label1.Text = "a =" + a.ToString() + ";" + "b =" + b.ToString() + ";" + "c =" + c.ToString() + ";" + "R =" + R.ToString();
            textBox1.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label1.Text = "a =" + a.ToString() + ";" + "b =" + b.ToString() + ";" + "c =" + c.ToString() + ";" + "R =" + R.ToString() + " Выбран расчёт - Площадь прямоугольного треугольника по двум катетам";
            rez = 6;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            label1.Text = "a =" + a.ToString() + ";" + "b =" + b.ToString() + ";" + "c =" + c.ToString() + ";" + "R =" + R.ToString() + " Выбран расчёт -  Решения квадратных уравнений";
            rez = 11;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Text = "a =" + a.ToString() + ";" + "b =" + b.ToString() + ";" + "c =" + c.ToString() + ";" + "R =" + R.ToString() + " Выбран расчёт -  Нахождение средней скорости";
            rez = 10;
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            label1.Text = "a =" + a.ToString() + ";" + "b =" + b.ToString() + ";" + "c =" + c.ToString() + ";" + "R =" + R.ToString() + " Выбран расчёт -  Нахождение начальной скорости";
            rez = 12;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            label1.Text = "a =" + a.ToString() + ";" + "b =" + b.ToString() + ";" + "c =" + c.ToString() + ";" + "R =" + R.ToString() + " Выбран расчёт -  Нахождение ускорения";
            rez = 13;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            label1.Text = "a =" + a.ToString() + ";" + "b =" + b.ToString() + ";" + "c =" + c.ToString() + ";" + "R =" + R.ToString() + " Выбран расчёт -  Нахождение времени";
            rez = 14;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            label1.Text = "a =" + a.ToString() + ";" + "b =" + b.ToString() + ";" + "c =" + c.ToString() + ";" + "R =" + R.ToString() + " Выбран расчёт -  Нахождение квадрата суммы";
            rez = 15;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            label1.Text = "a =" + a.ToString() + ";" + "b =" + b.ToString() + ";" + "c =" + c.ToString() + ";" + "R =" + R.ToString() + " Выбран расчёт -  Нахождение квадрата разности";
            rez = 16;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            label1.Text = "a =" + a.ToString() + ";" + "b =" + b.ToString() + ";" + "c =" + c.ToString() + ";" + "R =" + R.ToString() + " Выбран расчёт -  Нахождение  куб суммы";
            rez = 17;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            label1.Text = "a =" + a.ToString() + ";" + "b =" + b.ToString() + ";" + "c =" + c.ToString() + ";" + "R =" + R.ToString() + " Выбран расчёт -  Нахождение  разность кубов";
            rez = 18;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            label1.Text = "a =" + a.ToString() + ";" + "b =" + b.ToString() + ";" + "c =" + c.ToString() + ";" + "R =" + R.ToString() + " Выбран расчёт - Дискриминант";
            rez = 11;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text = "a =" + a.ToString() + ";" + "b =" + b.ToString() + ";" + "c =" + c.ToString() + ";" + "R =" + R.ToString() + " Выбран расчёт - Радиус описанной окружности";
            rez = 7;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label1.Text = "a =" + a.ToString() + ";" + "b =" + b.ToString() + ";" + "c =" + c.ToString() + ";" + "R =" + R.ToString() + " Выбран расчёт - Сторона";
            rez = 8;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label1.Text = "a =" + a.ToString() + ";" + "b =" + b.ToString() + ";" + "c =" + c.ToString() + ";" + "R =" + R.ToString() + " Выбран расчёт - Площадь треугольника по радиусу описанной окружности и трем сторонам";
            rez = 9;
        }

       /* static void SetRoundedShape(Control control, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddLine(radius, 0, control.Width - radius, 0);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddLine(control.Width, radius, control.Width, control.Height - radius);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddLine(control.Width - radius, control.Height, radius, control.Height);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.AddLine(0, control.Height - radius, 0, radius);
            path.AddArc(0, 0, radius, radius, 180, 90);
            control.Region = new Region(path);
        }*/
    }
}
