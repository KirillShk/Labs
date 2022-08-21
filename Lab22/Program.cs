using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива");
            int n = Convert.ToInt32(Console.ReadLine());

            Func<object, int[]> func1 = new Func<object, int[]>(GetArray);
            Task<int[]> task1 = new Task<int[]>(func1, n);

            Func<Task<int[]>, int> func2 = new Func<Task<int[]>, int>(GetSumArray);
            Task<int> task2 = task1.ContinueWith<int>(func2);

            Func<Task<int[]>, int> func3 = new Func<Task<int[]>, int>(GetMaxArrayElement);
            Task<int> task3 = task1.ContinueWith<int>(func3);

            Action<Task<int>> action1 = new Action<Task<int>>(PrintSum);
            Task task4 = task2.ContinueWith(action1);

            Action<Task<int>> action2 = new Action<Task<int>>(PrintMaxValue);
            Task task5 = task3.ContinueWith(action2);

            task1.Start();
            Console.ReadKey();
        }
        static int[] GetArray(object a)
        {
            int n = (int)a;
            int[] array = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(-100, 100);
                //  Console.Write("{0} |",array[i]);
            }
            return array;
        }

        static int GetSumArray(Task<int[]> task)
        {
            int[] array = task.Result;
            int sum = 0;
            foreach (int a in array)
            {
                sum += a;
            }
            return sum;
        }

        static int GetMaxArrayElement(Task<int[]> task)
        {
            int[] array = task.Result;
            int max = array[0];
            foreach (int a in array)
            {
                if (a > max)
                {
                    max = a;
                }
            }
            return max;
        }

        static void PrintSum(Task<int> task2)
        {
            int sum = task2.Result;
            Console.WriteLine($"\nСумма элементов массива = {sum}");
        }
        static void PrintMaxValue(Task<int> task3)
        {
            int MaxValue = task3.Result;
            Console.WriteLine($"\nМаксимальный элемент массива = {MaxValue}");
        }


    }
}
