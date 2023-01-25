using System;

namespace ConsoleApp2
{
    public class Math
    {
        public double a; // основание 
        public Math()
        {
            this.a = 0;
        }
        public Math(double a)
        {
            this.a = a;
        }
        public double PlRavnTr()
        {
            return (a^2 * Math.sqrt(3)) / 4;
        }
        public static double PlRavnTr(double a)
        {
            return (this.a^2 * Math.sqrt(3)) / 4;
        }
        public double PlPravShest()
        {
            return (3 * a^2 * Math.sqrt(3)) / 2;
        }
        public static double PlPravShest(double a)
        {
            return (3 * this.a^2 * Math.sqrt(3)) / 2;
        }

    }
}