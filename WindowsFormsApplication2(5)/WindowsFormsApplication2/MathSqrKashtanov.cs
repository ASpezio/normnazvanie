using System;

namespace ConsoleApp1
{
    class QuadraticEquation
    {
        public string a;//поля
        public string b;//поля
        public string c;//поля

        public QuadraticEquation()//конструктор инциализации, если пусто
        {
            a = "0";
            b = "0";
            c = "0";
        }
        public QuadraticEquation(string a, string b, string c)//конструктор с конкретными данными
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public static string Korni(string a, string b, string c)//метод для поиска корней
        {
            double D = double.Parse(b) * double.Parse(b) - 4 * double.Parse(a) * double.Parse(c);//считаем дискриминант
            string s = "";
            double x;

            if (D < 0)//если отрицательный, то корней нет
            {
                s = "нет корней";
            }
            else
            {
                if (D == 0)//если равен 0, то 1 корень.
                {
                    x = -double.Parse(b) / (2 * double.Parse(a));
                    s = $"{x}";
                }
                else//иначе 2 корня
                {
                    x = (-double.Parse(b) + Math.Sqrt(D)) / (2 * double.Parse(a));
                    s = $"Первый корень:{x}";
                    x = (-double.Parse(b) - Math.Sqrt(D)) / (2 * double.Parse(a));
                    s += $" Второй корень:{x}";
                }
            }
            return s;
        }
    }
}
