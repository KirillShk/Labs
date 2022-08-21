using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    struct Linear_equation
    {
        double k_St;
        double b_St;

        public Linear_equation(double k, double b)
        {
            this.k_St = k;
            this.b_St = b;
        }
        public string Root()
        {
            if (k_St == 0 && b_St != 0)
                return "Решений нет";
            else if (k_St == 0 && b_St == 0)
                return "Решение: х- любое число";
            double x = -b_St / k_St;
            return $"Решение: x = {x}";

        }

    }
}
