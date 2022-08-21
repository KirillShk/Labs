using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    internal class Building
    {
        string adress;
        int length;
        int width;
        int height;

        int Lenght
        {
            get
            {
                return length;
            }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Значение длины не может быть меньше или равно нулю");
                else
                    length = value;
            }
        }

        int Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Значение ширины не может быть меньше или равно нулю");
                else
                    width = value;
            }
        }
        int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Значение высоты не может быть меньше или равно нулю");
                else
                    height = value;
            }
        }

        public Building(string adress, int length, int width, int height)
        {
            this.adress = adress;
            this.Lenght = length;
            this.Width = width;
            this.Height = height;
        }

        public string Print()
        {
            return $"Адрес здания - {adress} \n длина - {length} \n ширина - {width} \n высота - {height} \n ";
        }
    }
}
