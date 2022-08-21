using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите коорднаты х и у");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            double LengthCircle = Circle.GetLenghtLcircle(r);
            double SquareCircle = Circle.GetSquareCircle(r);
            string a = Circle.GetPointCircle(r, x, y);

            Console.WriteLine($"Длина окружности = {LengthCircle} \n Площадь окружности = {SquareCircle} \n {a}");
            Console.ReadKey();
        }
    }
}
