using System;

namespace ConsoleApp2
{
    public class Math
    {
        public double a; // основание 
        public double b; // основание 
        public double c; // высота
        public Math()
        {
            this.a = 0;
            this.b = 0;
            this.c = 0;
        }
        public Math(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double MathPlTrap()
        {
            return (this.a + this.b) / 2 * this.c;
        }
        public static double MathPlTrap(double a, double b, double c)
        {
            return (a + b) / 2 * c;
        }
        public double MathSredLin()
        {
            return (this.a + this.b) / 2;
        }
        public static double MathSredLin(double a, double b)
        {
            return (a + b) / 2;
        }

    }
}