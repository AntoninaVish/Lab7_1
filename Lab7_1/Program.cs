using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());
            double p, S;
            GetParam(x, y, z, out p, out S);

            Console.WriteLine(p);
            Console.WriteLine(S);
            Console.ReadKey();
        }
        static void GetParam(int x, int y, int z, out double p, out double S)
        {
           p = (x+y+z)/2;
           S = Math.Sqrt(p*(p-x)*(p-y)*(p-z));
         }
    }
}
