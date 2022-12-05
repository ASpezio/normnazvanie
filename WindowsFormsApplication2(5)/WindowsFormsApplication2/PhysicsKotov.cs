using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithClass
{
    public class Physics
    {
        // var1, var2, var3, (могут принимать значения V, V0, A, T) var4 (сободная переменная к которой будет присваиваться искомая переменная)
        public double var1;
        public double var2;
        public double var3;
        
        public Physics()
        {
            var1 = 0;
            var2 = 0;
            var3 = 0;
        }
        
        public Physics(double a, double b, double c)
        {
            this.var1 = a;
            this.var2 = b;
            this.var3 = c;

        }
        // V = A * T + V0
        public double FormV()
        {
            return this.var2 * this.var3 + this.var1;
        }
        // V0 = V - A * T
        public double FormV0()
        {
            return this.var1 - this.var2 * this.var3;
        }
        // A = (V - V0) / T
        public double FormA()
        {
            return (this.var1 - this.var2) / this.var3;
        }
        // T = (V - V0) / A
        public double FormT()
        {
            return (this.var1 - this.var2) / this.var3;
        }
    }
}