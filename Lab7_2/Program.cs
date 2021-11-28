using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = (float)Convert.ToDouble(Console.ReadLine());
            float V = Param(a);
            float S = Param(a);
            Console.WriteLine(V);
            Console.WriteLine(S);
            Console.ReadKey();
        }
        static float Param(float a)
        {
            float V = a * a * a;
            
            return V;
            float S = 6 * (a * a);
            return S;
        }
    }
}
