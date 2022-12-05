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
        double var1;
        double var2;
        double var3;
        double var4;
        string provVar;
        
        public Physics()
        {
            var1 = 0;
            var2 = 0;
            var3 = 0;
            var4 = 0;
            provVar = "переменная не выбрана";
        }
        
        public Physics(double var1, double var2, double var3, string provVar)
        {
            this.provVar = provVar;
            this.var1 = var1;
            this.var2 = var2;
            this.var3 = var3;
        }
        // V = A * T + V0
        double FormV()
        {
            var4 = var2 * var3 + var1;
            return this.var4;
        }
        // V0 = V - A * T
        double FormV0()
        {
            var4 = var1 - var2 * var3;
            return this.var4;
        }        
        // A = (V - V0) / T
        double FormA()
        {
            var4 = (var1 - var2) / var3;
            return this.var4;
        }        
        // T = (V - V0) / A
        double FormT()
        {
            var4 = (var1 - var2) / var3;
            return this.var4;
        }
    }
}