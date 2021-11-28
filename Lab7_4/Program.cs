using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисления объема и площади поверхности куба:");
            Console.Write("Введите длину ребра куба:");
            double a = Convert.ToDouble(Console.ReadLine());
            Param(a);
            Console.ReadKey();
        }
        static void Param(double a)
        {
            double V = Math.Pow (a, 3);
            double S = 6 * (Math.Pow(a, 2));
            Console.WriteLine("Объем поверхности куба {0}",V);
            Console.WriteLine("Площадь поверхности куба {0}",S);
        }
    }
}
