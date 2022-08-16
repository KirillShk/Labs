using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_1
{
    internal class Program
    {
        static double GetAreaTriangle(double x, double y, double z)
        {
            double p = (x + y + z) / 2;
            return Math.Sqrt(p * (p - x) * (p - y) * (p - z));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны треугольника 1:");
            double x1 = Convert.ToInt32(Console.ReadLine());
            double y1 = Convert.ToInt32(Console.ReadLine());
            double z1 = Convert.ToInt32(Console.ReadLine());
            double S1 = GetAreaTriangle(x1, y1, z1);
            Console.WriteLine("Введите стороны треугольника 2:");
            double x2 = Convert.ToInt32(Console.ReadLine());
            double y2 = Convert.ToInt32(Console.ReadLine());
            double z2 = Convert.ToInt32(Console.ReadLine());
            double S2 = GetAreaTriangle(x2, y2, z2);

            if (S1 > S2)
                Console.WriteLine("Площадь треугольника 1 больше");
            else if (S2 < S1)
                Console.WriteLine("Площадь треугольника 2 больше");
            else
                Console.WriteLine("Площади треугольников ровны");
            Console.ReadKey();
        }
    }
}
