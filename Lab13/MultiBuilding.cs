using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    sealed class MultiBuilding : Building
    {
        int floor;

        int Floor
        {
            get { return floor; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Поле этаж не может быть меньше или равно нулю");
                else
                    floor = value;
            }

        }
        public MultiBuilding(string adress, int length, int width, int height, int floor)
            : base(adress, length, width, height)
        {
            this.Floor = floor;
        }
        public string Print()
        {
            string result = base.Print();
            result += $"Кол-во этажей -{floor}";
            return result;
        }
    }
}
