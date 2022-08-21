using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите коэффициенты уровня k  и x");
            double k = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            Linear_equation linear_Equation = new Linear_equation(k, b);
            Console.WriteLine(linear_Equation.Root());
            Console.ReadKey();
        }
    }
}
