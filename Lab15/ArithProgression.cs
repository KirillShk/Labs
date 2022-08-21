using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class ArithProgression : ISeries
    {
        int startValue;
        int step;
        int currentValue;
        public int getNext()
        {
            currentValue += step;
            return currentValue;
        }

        public void reset()
        {
            currentValue = startValue;
        }

        public void setStart(int a)
        {
            startValue = a;
            currentValue = startValue;
        }
        public void setStep(int b)
        {
            step = b;
        }
    }
}
