using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    internal class Circle
    {
        static public double GetLenghtLcircle(int r)
        {
            return 2 * Math.PI * r;
        }

        static public double GetSquareCircle(int r)
        {
            return Math.PI * r * r;
        }

        static public string GetPointCircle(int r, int x, int y)
        {
            double lengt = Math.Sqrt(x * x + y * y);
            if (lengt <= r)
                return $"Точка с координатами {x}, {y} принадлежит окружности";
            else
                return $"Точка с координатами {x}, {y}  не принадлежит окружности";
        }
    }
}
