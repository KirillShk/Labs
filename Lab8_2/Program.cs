using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Temp\Files\List_Numbers.txt";
            Random rand = new Random();
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(rand.Next(0, 15));
                }
            }
            int Sum = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    int a = Convert.ToInt32(sr.ReadLine());
                    Sum += a;
                }
                Console.WriteLine(Sum);
            }
            Console.ReadKey();
        }
    }
}
