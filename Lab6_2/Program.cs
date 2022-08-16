using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string s1 = Console.ReadLine();
            string s1t = ""; // переменная для преобразование строки s1
            string s2 = "";
            string[] s1Array = s1.Split();

            foreach (string s in s1Array)
            {
                s1t += s.ToLower();
            }
            s1 = s1t;
            foreach (char s in s1)
            {
                s2 = s + s2;
            }
            int result = string.Compare(s1, s2);
            if (result == 0)
                Console.WriteLine("Строка является палиндромом");
            else
                Console.WriteLine("Строка не является палиндромом");
            Console.ReadKey();
        }
    }
}
