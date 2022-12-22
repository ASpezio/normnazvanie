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
        public double A;
        public double B;
        public double C;
        public double R;   
        public Physic() { this.A = 0; this.B = 0; this.C = 0; this.R = 0 }
        public Physic(double A, double B, double C, double R)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.R = R;
           
        }

        public double Formula1()
        {
            return  this.A * this.B / (this.C * this.R);
        }
        public double Formula1( double A, double B, double C, double R)
        {
            return   A * B / (C * R);
        }
        public double Formula2()
        {
            return  this.A * (this.B - this.C);
        }
        public double Formula2 ( double A , double B, double C)
            {
        return  A* (B-C);
            }
       
       
    }
}


