using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты х1 и у1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты х2 и у2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты х3 и у3");
            int x3 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());
            if (x1 == x2 && y2 == y3)
            {
                int x4 = x3;
                int y4 = y1;
                Console.WriteLine("Координаты х4 и у4: {0},{1}", x4, y4);
            }
            else if (x1 == x3 && y2 == y3)
            {
                int x4 = x2;
                int y4 = y1;

                Console.WriteLine("Координаты х4 и у4: {0},{1}", x4, y4);
            }
            else if (x1 == x3 && y1 == y2)
            {
                int x4 = x2;
                int y4 = y3;
                Console.WriteLine("Координаты х4 и у4: {0},{1}", x4, y4);
            }
            else if (x1 == x2 && y1 == y3)
            {
                int x4 = x3;
                int y4 = y2;
                Console.WriteLine("Координаты х4 и у4: {0},{1}", x4, y4);
            }
            else if (x2 == x3 && y1 == y2)
            {
                int x4 = x1;
                int y4 = y3;
                Console.WriteLine("Координаты х4 и у4: {0},{1}", x4, y4);
            }
            else if (x2 == x3 && y1 == y3)
            {
                int x4 = x1;
                int y4 = y2;
                Console.WriteLine("Координаты х4 и у4: {0},{1}", x4, y4);
            }
            else
            {
                Console.WriteLine("Прямоугольник не параллелен оси кооординат");
            }
            Console.ReadKey();
        }
    }
}
