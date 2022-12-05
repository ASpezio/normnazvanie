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
        //(a-b)^3 - Куб разности
        public double raznost kub(double a, double b)
        {
            return Math.Pow(a, 3)-3*Math.Pow(a, 2)*b+3*a*Math.Pow(b, 2)-Math.Pow(b, 3);
        }
        public static double Potencg(double this.a, double this.b)
        {
            return Math.Pow(this.a, 3)-3*Math.Pow(this.a, 2)*this.b+3*this.a*Math.Pow(this.b, 2)-Math.Pow(this.b, 3);
        }
    }
}