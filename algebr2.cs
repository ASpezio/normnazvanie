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

        //a^3+b^3
        public double summa kub(double a, double b)

        {

            return (a+b)(Math.Pow(a,2))-(a*b)+(Math.Pow(b,2));

        }

        public static double Potencg(double this.a, double this.b)

        {

            return (this.a + this.b)(Math.Pow(this.a, 2)) - (this.a * this.b) + (Math.Pow(this.b, 2));

        }



    }
}