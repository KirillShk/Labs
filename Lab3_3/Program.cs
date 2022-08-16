using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите возраст в годах");

            int x = Convert.ToInt32(Console.ReadLine());
            if ((x >= 20) && (x <= 69))
            {
                switch (x % 10)
                {
                    case 0:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                        {
                            Console.WriteLine("Возраст = {0} лет", x);
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("Возраст = {0} год", x);
                            break;
                        }
                    case 2:
                    case 3:
                    case 4:
                        {
                            Console.WriteLine("Возраст = {0} года", x);
                            break;
                        }
                }

            }
            else
            {
                Console.WriteLine("Ошибка! Возраст не попадает в диапозон");
            }
            Console.ReadKey();

        }
    }
}
