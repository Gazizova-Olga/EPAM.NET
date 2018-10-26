using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class GeometricProgression:ISeries
    {
        double start, multiplicator;
        int currentIndex;

        public GeometricProgression(double start, double multiplicator)
        {
            this.start = start;
            this.multiplicator = multiplicator;
            this.currentIndex = 1;
        }
        public double GetCurrent()
        {
            return start *Math.Pow( multiplicator, currentIndex-1);
        }

        public bool MoveNext()
        {
            currentIndex++;
            return true;
        }

        public void Reset()
        {
            currentIndex = 1;
        }
    }

    
}
