using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Вас приветсвует калькулятор!");
                Console.Write("Введите целое число X=");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число Y=");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите код операции: \n\t 1 - сложение \n\t 2 - вычитание \n\t 3 - произведение \n\t 4 - частное");
                Console.Write("Ваш выбор: ");
                int z = Convert.ToInt32(Console.ReadLine());

                switch (z)
                {
                    case 1:
                        {
                            Console.WriteLine("Результат = {0}", x + y);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Результат = {0}", x - y);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Результат = {0}", x * y);
                            break;
                        }
                    case 4:
                        {
                            int b = x / y;
                            Console.WriteLine("Результат = {0:f2}", (double)x / y);
                            break;

                        }
                    default:
                        {
                            Console.WriteLine("Нет операции с указаным номером");
                            break;
                        }
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("\n Ошибка! Деление на ноль \n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n Ошибка! Входная строка имела неверный формат \n", ex.Message);
            }
            Console.ReadKey();
        }
    }
}
