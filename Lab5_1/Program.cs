using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];
            int s = 0;

            Console.WriteLine("Введите по очереди 7 чисел");
            for (int i = 0; i < 7; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                s += array[i];
            }
            Console.WriteLine("Среднеарифмитическое = {0}", s / 7);
            Console.ReadKey();
        }
    }
}
