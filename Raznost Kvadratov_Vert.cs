using System;

namespace ConsoleApp3
{
    public class algebra
    {
        public double a;
        public double b;
        public algebra()
        {
            this.a = 0;
            this.b = 0;
        }
        public algebra(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        //(a-b)(a+b) - разность квадратов
        public double raznost kvadrat(double a, double b)
        {
            return Math.Pow(a, 2)-Math.Pow(b, 2);
        }
        public static double Potencg(double this.a, double this.b)
        {
            return Math.Pow(this.a, 2)-Math.Pow(this.b, 2);
        }
    }
}