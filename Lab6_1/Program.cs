using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string s1 = Console.ReadLine();

            string[] s1Array = s1.Split();
            string max = s1Array[0];
            foreach (string s in s1Array)
            {
                if (s.Length > max.Length)
                {
                    max = s;
                }
            }
            Console.WriteLine("Самое длинное слово в строке: {0}", max);
            Console.ReadKey();
        }
    }
}
