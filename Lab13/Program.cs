using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите адрес здания, длину, ширину, высоту, кол-во этажей");
            string adress = Convert.ToString(Console.ReadLine());
            int length = Convert.ToInt32(Console.ReadLine());
            int width = Convert.ToInt32(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine());
            int floor = Convert.ToInt32(Console.ReadLine());
            Building bulding = new Building(adress, length, width, height);
            Console.WriteLine(bulding.Print());
            MultiBuilding multiBuilding = new MultiBuilding(adress, length, width, height, floor);
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
        }
    }
}
