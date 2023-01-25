using System;

namespace ConsoleApp27
{
    public class MathTrapeznikov
    {
        public double a; 
        public double b; 
        public double c; 
        public double R;
        public MathTrapeznikov()
        {
            this.a = 0;
            this.b = 0;
            this.c = 0;
            this.R = 0;
        }
        public MathTrapeznikov(double a, double b, double c, double R)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.R = R;
        }
        public double MathPlTrap()
        {
            return (this.a + this.b) / 2 * this.c;
        }
        public static double MathPlTrap(double a, double b, double c)
        {
            return (a + b) / 2 * c;
        }
        public double MathSredLinTr()
        {
            return (this.a * this.R + this.b * this.c) / 2;
        }
        public static double MathSredLinTr(double a, double b, double c, double R)
        {
            return (a + R + b * c) / 2;
        }

    }
}