using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите животное");
            string AnimalName = Convert.ToString(Console.ReadLine());
            if (AnimalName == "кошка")
            {
                Cat cat = new Cat(AnimalName);
                cat.ShowInfo();
            }
            else if (AnimalName == "собака")
            {
                Dog dog = new Dog(AnimalName);
                dog.ShowInfo();
            }
            else
                Console.WriteLine("Такого животного нет");
            Console.ReadKey();
        }
    }
}
