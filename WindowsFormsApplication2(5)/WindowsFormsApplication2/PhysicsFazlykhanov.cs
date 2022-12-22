using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Physic
    {
        public double a;
        public double b;
        public double c;
        public double R;
        public Physic() { this.a = 0; this.b = 0; this.c = 0; this.R = 0; }
        public Physic(double a, double b, double c, double R)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.R = R;
           
        }

        public  double Formula1()
        {
            return  this.a * this.b / (this.c * this.R);
        }
        public static double Formula1( double a, double b, double c, double R)
        {
            return   a * b / (c * R);
        }
        public double Formula2()
        {
            return  this.a * (this.b - this.c);
        }
        public static double Formula2 ( double a , double b, double c)
            {
        return  a* (b-c);
            }
       
       
    }
}


