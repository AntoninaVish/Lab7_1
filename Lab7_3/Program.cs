using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double S2;
            double S1;
            Console.WriteLine("Два треугольника заданы длинами своих сторон, определяем площадь какого из них больше.");
            {
                Console.WriteLine("Введите длины сторон первого треугольника:");
                Console.Write("x=");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write("y=");
                double y = Convert.ToDouble(Console.ReadLine());
                Console.Write("z=");
                double z = Convert.ToDouble(Console.ReadLine());
                S1 = Param(x, y, z);
                Console.WriteLine("Площадь первого треугольника {0}", S1);
            }

            {
                Console.WriteLine("Введите длины сторон второго треугольника:");
                Console.Write("x=");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write("y=");
                double y = Convert.ToDouble(Console.ReadLine());
                Console.Write("z=");
                double z = Convert.ToDouble(Console.ReadLine());
                S2 = Param(x, y, z);
                Console.WriteLine("Площадь второго треугольника {0}", S2);
            }
            if (S1 > S2)
            {
                Console.WriteLine("Площадь первого треугольника равна {0}, она больше площади второго треугольника {1}", S1, S2);
            }
            if (S1 < S2)
            {
                Console.WriteLine("Площадь второго треугольника равна {0}, она больше площади первого треугольника {1}", S2, S1);
            }
            if (S1==S2)
            {
                Console.WriteLine("Площадь первого треугольника {0}, она равна площади второго треугольника {1}", S1, S2);
            }
            Console.ReadKey();
        }
        static double Param(double x, double y, double z)
        {
            double p = (x + y + z) / 2;
            double S = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            return S;
        }
        

    }
}
