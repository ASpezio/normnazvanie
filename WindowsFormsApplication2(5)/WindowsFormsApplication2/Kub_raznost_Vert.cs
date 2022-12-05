using System;

namespace ConsoleApp3
{
    public class alg
    {
        public double a;
        public double b;
        public alg()
        {
            this.a = 0;
            this.b = 0;
        }
        public alg(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        //(a-b)^3 - Куб разности
        public static double RaznostKub(double a, double b)
        {
            return Math.Pow(a, 3)-3*Math.Pow(a, 2)*b+3*a*Math.Pow(b, 2)-Math.Pow(b, 3);
        }
        public static double RaznostkKvadrat(double a, double b)
        {
            return Math.Pow(a, 2) - Math.Pow(b, 2);
        }

    }
}