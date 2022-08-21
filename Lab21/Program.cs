using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab21
{
    internal class Program
    {
        const int n = 5;
        const int m = 7;
        static int[,] path = new int[n, m];
        static char[,] symbol = new char[n, m];

        static void Main(string[] args)
        {
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    path[i, j] = random.Next(1, 20);
                    Console.Write("{0}\t", path[i, j]);
                }
                Console.WriteLine();
            }
            ThreadStart threadstart = new ThreadStart(Garner1);
            Thread thread = new Thread(threadstart);
            thread.Start();
            Garner2();
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0}\t", symbol[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
        static void Garner1()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (path[i, j] >= 0)
                    {
                        int delay = path[i, j];
                        path[i, j] = -1;
                        symbol[i, j] = '+';
                        Thread.Sleep(delay);
                    }
                }
            }
        }
        static void Garner2()
        {
            for (int j = m - 1; j >= 0; j--)
            {
                for (int i = n - 1; i >= 0; i--)
                {
                    if (path[i, j] >= 0)
                    {
                        int delay = path[i, j];
                        path[i, j] = -2;
                        symbol[i, j] = '-';
                        Thread.Sleep(delay);
                    }
                }
            }
        }

    }
}
