using System;

namespace ConsoleApp26
{
    public class MathOputin
    {
        public double a; // основание 
        public double b; // основание 
        public double c; // высота
        public double R; // полупериметр 
        public MathOputin()
        {
            this.a = 0;
            this.b = 0;
            this.c = 0;
            this.R = 0;
        }
        public MathOputin(double a, double b, double c, double R)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.R = R;
        }
        
        public double MathPlPoverPrParal()
        {
            return 2 * (this.a * this.b + this.a * this.c + this.b * this.c);
        }
        public static double MathPlPoverPrParal(double a, double b, double c)
        {
            return 2 * (a * b + a * c + b * c);
        }
        public double MathPlTr()
        {
            return (this.R * (this.R - this.a) * (this.R - this.b) * (this.R - this.c)) / 2;
        }
        public static double MathPlTr(double a, double b, double c, double R)
        {
            return (R * (R - a) * (R - b) * (R - c)) / 2;
        }

    }
}