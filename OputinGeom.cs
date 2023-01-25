using System;

namespace ConsoleApp2
{
    public class Math
    {
        public double a; // основание 
        public double b; // основание 
        public double c; // высота
        public double R; // полупериметр 
        public Math()
        {
            this.a = 0;
            this.b = 0;
            this.c = 0;
            this.R = 0;
        }
        public Math(double a, double b, double c, double R)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.R = R;
        }
        public double MathPlPoverPrParal()
        {
            return 2(this.a * this.b + this.a * this.c + this.b * this.c);
        }
        public static double MathPlPoverPrParal(double a, double b, double c)
        {
            return 2(ab + ac + bc);
        }
        public double MathPlTr()
        {
            return Math.sqrt(this.R(this.R - this.a)(this.R - this.b)(this.R - this.c));
        }
        public static double MathPlTr(double a, double b, double c, double R)
        {
            return Math.sqrt(R(R - a)(R - b)(R - c);
        }

    }
}