using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    internal class Radians
    {
        int gradusCl;
        int minuteCl;
        int secondCl;

        public int MinuteCl
        {
            get { return minuteCl; }
            set
            {
                if (value < 0)
                {
                    minuteCl = 0;
                }
                else if (value > 60)
                {
                    gradusCl += value / 60;
                    minuteCl = value % 60;
                }
                else
                {
                    minuteCl = value;
                }
            }
        }
        public int SecondCl
        {
            get { return secondCl; }
            set
            {
                if (value < 0)
                {
                    minuteCl = 0;
                }
                else if (value > 60)
                {
                    minuteCl += value / 60;
                    secondCl = value % 60;
                }
                else
                {
                    secondCl = value;
                }
            }
        }

        public Radians(int gradus, int minute, int second)
        {
            this.gradusCl = gradus;
            this.MinuteCl = minute;
            this.SecondCl = second;
        }

        public double ToRadians()
        {
            return (gradusCl + (double)minuteCl / 60 + (double)secondCl / 3600) * Math.PI / 180;
        }

    }
}
