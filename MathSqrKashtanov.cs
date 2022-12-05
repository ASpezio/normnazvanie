using System;

namespace ConsoleApp1
{
    class QuadraticEquation
    {
        double a;//поля
        double b;//поля
        double c;//поля


        public QuadraticEquation()//конструктор инциализации, если пусто
        {
            a = 0;
            b = 0;
            c = 0;
        }
        public QuadraticEquation(double a, double b, double c)//конструктор с конкретными данными
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public QuadraticEquation(QuadraticEquation qe)//конструктор копирования
        {
            this.a = qe.a;
            this.b = qe.b;
            this.c = qe.c;
        }
        public override string ToString()//перегрузка для вывода
        {
            return $"Коэффициент a = {a} b = {b} c = {c}";
        }

        public void input()//метод для ввода данных
        {
            Console.WriteLine($"Введите коэффициенты: ");

            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b = ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("c = ");
            c = Convert.ToDouble(Console.ReadLine());
        }

        public string korni()//метод для поиска корней
        {
            double D = b * b - 4 * a * c;//считаем дискриминант
            string s = "";//строка для фиксирования корней
            double x;

            if (D < 0)//если отрицательный, то корней нет
            {
                s = "корней нет";
                return s;
            }
            else
            {
                if (D == 0)//если равен 0, то 1 корень.
                {
                    x = -b / (2 * a);
                    s = Convert.ToString(x);
                    return s;
                }
                else//иначе 2 корня
                {
                    x = (-b + Math.Sqrt(D)) / (2 * a);
                    s = Convert.ToString(x);

                    x = (-b - Math.Sqrt(D)) / (2 * a);
                    s += ' ' + Convert.ToString(x);
                    return s;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            QuadraticEquation eq = new QuadraticEquation();//создаем новый объект

            //тест расчета корней
            eq.input();//обращаемся к методу для ввода коэфф
            string result;//строка для хранения корней
            result = eq.korni();

            Console.WriteLine("Полученные корни: " + result);
            
            QuadraticEquation eq2 = new QuadraticEquation(2, 5, 0);//через конструктор заполнил 2 объект с коэфф

            QuadraticEquation eq3 = new QuadraticEquation(eq2);//тест конструктора копирования
            Console.WriteLine(eq3);
        }
    }
}
