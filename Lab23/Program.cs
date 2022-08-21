using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите факториал числа");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 0)
                Console.WriteLine("Факториал числа 0 = 1");
            else if (n < 0)
                Console.WriteLine("Значение n должно быть натуральным числом");
            else
            {
                FactorialAsync(n);
                Task task1 = Task.Run(() => GetArray(n));
            }
            Console.ReadKey();
        }
        static void GetFactorial(int n)
        {
            int f = 1;
            for (int i = 1; i <= n; i++)
            {
                f *= i;
                Thread.Sleep(10);
            }
            Console.WriteLine("\n Факториал числа {0} = {1}", n, f);
        }

        static void GetArray(int n)
        {
            int[] array = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(1, 50);
                Console.WriteLine("Элемент массива {0} = {1}", i + 1, array[i]);
            }
        }

        static async void FactorialAsync(int n)
        {
            await Task.Run(() => GetFactorial(n));
        }
    }
}
