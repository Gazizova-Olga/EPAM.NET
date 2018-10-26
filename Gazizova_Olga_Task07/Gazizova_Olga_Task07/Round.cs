using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazizova_Olga_Task07
{
    class Round:Circle
    {
        public Round(int x, int y, double radius) : base(x, y, radius)
        {

        }

        public Round(int x, int y) : base(x, y, 1)
        {

        }

        public Round() : base(0, 0, 1)
        {

        }

        public double Area
        {
            get
            {
                return Math.PI * Math.Pow(Radius, 2);
            }
        }

        public double Length
        {
            get
            {
                return Math.PI * 2 * Radius;
            }
        }


    }
}
