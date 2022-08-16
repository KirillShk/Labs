using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_2
{
    internal class Program
    {
        static void GetCubVolumeArea(double a, out double S, out double V)
        {
            V = Math.Pow(a, 3);
            S = 6 * a * a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение ребра куба:");

            double a = Convert.ToInt32(Console.ReadLine());
            double s;
            double v;
            GetCubVolumeArea(a, out s, out v);
            Console.WriteLine("Объём куба = {0:.0}, Площадь куба = {1:.0}", s, v);
            Console.ReadKey();
        }
    }
}
