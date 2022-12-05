using System;

namespace ConsoleApp3
{
    public class Matan
    {
        public double a;
        public double b;
        public double c;
        public double R;
        public Matan()
        {
            this.a = 0;
            this.b = 0;
            this.c = 0;
            this.R = 0;
        }
        public Matan(double a, double b, double c, double R)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.R = R;
        }
        public Matan(double[] asd)
        {
            this.a = asd[0];
            this.b = asd[1];
            this.c = asd[2];
            this.R = asd[3];
        }
        public double MatRadTr()
        {
            return (this.a * this.b * this.c) / 4.0 * this.R;
        }
        public static double MatRadTr(double a, double b, double c, double R)
        {
            return (a * b * c) / 4.0 * R;
        }
        public double MatPrTr()
        {
            return 1.0 / 2.0 * this.a * this.b;
        }
        public static double MatPrTr(double a, double b)
        {
            return 1.0 / 2.0 * a * b;
        }
        public double MatOpOkr()
        {
            return (3.0 * Math.Sqrt(3.0) / 4.0) * this.R * this.R;
        }
        public static double MatOpOkr(double R)
        {
            return (3.0 * Math.Sqrt(3.0) / 4.0) * R * R;
        }
        public double MatStor()
        {
            return (Math.Sqrt(3.0) / 4.0) * this.a * this.a;
        }
        public static double MatStor(double a)
        {
            return (Math.Sqrt(3.0) / 4.0) * a * a;
        }
    }

}