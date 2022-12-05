using System;




namespace ConsoleApp3

{

    public class Fizik

    {

        public double a;

        public double b;

        public double c;

        

        public Fizik()

        {

            this.a = 0;

            this.b = 0;

            this.c = 0;

           

        }

        public Fizik(double a, double b, double c)

        {

            this.a = a;

            this.b = b;

            this.c = c;

           

        }


        public double Uprug()

        {

            return (this.a/2)*(Math.Pow(this.b,2)-Math.Pow(this.c,2));

        }
        public static double Uprug(double a, double b, double c)

        {

            return (a / 2) * (Math.Pow(b, 2) - Math.Pow(c, 2));

        }

        public  double Potencg()

        {

            return (this.a*this.b*this.c);

        }
        public static double Potencg(double a, double b, double c)

        {

            return (a * b * c);

        }
        public  double Kinitet()

        {

            return ((this.a * Math.Pow(this.b, 2)) / 2);

        }
        public static double Kinitet(double a, double b)

        {

            return ((a * Math.Pow(b, 2)) / 2);

        }



    }
}