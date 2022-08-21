using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите поочередно значения в грудусах, минутах и секундах");
            int gradus = Convert.ToInt32(Console.ReadLine());
            int minute = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());
            Radians radians = new Radians(gradus, minute, second);
            double ResultRadians = radians.ToRadians();
            Console.WriteLine("Значение в радианах = {0}", ResultRadians);
            Console.ReadKey();
        }
    }
}
