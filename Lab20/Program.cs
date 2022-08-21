using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20
{
    internal class Program
    {
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности");
            double r = Convert.ToDouble(Console.ReadLine());
            MyDelegate myDelegate = LengthCircumference;
            double result = myDelegate(r);
            Console.WriteLine("Длина окружности = {0:f2}", result);
            myDelegate = AreaCircle;
            result = myDelegate(r);
            Console.WriteLine("Площадь круга = {0:f2}", result);
            myDelegate = BallVolume;
            result = myDelegate(r);
            Console.WriteLine("Объём шара = {0:f2}", result);
            Console.ReadKey();

        }

        static double LengthCircumference(double r) => 2 * Math.PI * r;

        static double AreaCircle(double r) => Math.PI * r * r;

        static double BallVolume(double r) => (4 / 3) * Math.PI * Math.Pow(r, 3);
    }
}
