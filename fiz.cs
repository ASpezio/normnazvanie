using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fiz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double h, m;
            string action;
            Console.WriteLine("С какой высоты падает тело?(Укажите значение в метрах)");
            h = double.Parse(Console.ReadLine());

            Console.WriteLine("Какова масса тела? (Укажите значение в килограммах)");
            m = double.Parse(Console.ReadLine());

            Console.WriteLine("Модуль скорости тела в момент падения равеен"); 
            Console.WriteLine(Math.Sqrt(2 * (9.8 * h)));
            Console.WriteLine("Время падения с высоты " + h + " метров равно ");
            Console.WriteLine(Math.Sqrt((2 * h)/9.8) + " секунд");
        }
    }
}
