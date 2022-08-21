using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начальное значение прогрессии и её шаг");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество элеметов на вывод");
            int c = Convert.ToInt32(Console.ReadLine());
            ArithProgression arith = new ArithProgression();
            arith.setStart(a);
            arith.setStep(b);
            for (int i = 0; i < c; i++)
            {
                Console.WriteLine("{0}-й элемент арифметической прогрессии: {1}", i + 2, arith.getNext());
            }
            arith.reset();
            Console.WriteLine("\n");
            for (int i = 0; i < c - 1; i++)
            {
                Console.WriteLine("{0}-й элемент арифметической прогрессии: {1}", i + 2, arith.getNext());
            }
            GeomProgression geom = new GeomProgression();
            Console.WriteLine("\n");
            geom.setStart(a);
            geom.setStep(b);
            for (int i = 0; i < c; i++)
            {
                Console.WriteLine("{0}-й элемент геометрической прогрессии: {1}", i + 2, geom.getNext());
            }
            geom.reset();
            Console.WriteLine("\n");
            for (int i = 0; i < c - 1; i++)
            {
                Console.WriteLine("{0}-й элемент геометрической прогрессии: {1}", i + 2, geom.getNext());
            }
            Console.ReadKey();
        }
    }
}
