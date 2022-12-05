using System;




namespace ConsoleApp3

{
    public class algebr

    {
        public double a;
        public double b;
        public algebr()

        {
            this.a = 0;
            this.b = 0;
        }
        public algebr(double a, double b)
        {
            this.a = a;
            this.b = b;

            

        }


        public static double SummaKub(double a,double b)

        {

            return (Math.Pow(a,3))+(3*Math.Pow(a,2))*b+(3*a*Math.Pow(b,2))+(Math.Pow(b,3));

        }
        public static double Rasnos(double a, double b)

        {

            return (a - b) * ((a*a) + a*b + (b * b));

        }







    }
}