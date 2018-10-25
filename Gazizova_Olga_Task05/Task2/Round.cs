using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Round
    {
        public double R;

        public double X
        {
            get;
            set;
        }
        public double Y
        {
            get;
            set;
        }
         
        public double Radius
        {
            get
            {
                return R;
            }
            set
            {
                if (value > 0)
                {
                    R = value;
                }
                else
                {
                    Console.WriteLine("Некорректное значение радиуса");
                }
            }
        }

        public Round()
        {
            X = Y = 1;
        }

        public Round(int x, int y, double r)
        {
            X = x;
            Y = y;
            this.R = r;
        }

        
        public double GetLength()
        {
            return 2 * Math.PI * R;
        }

        public double GetSquare()
        {
            return Math.Pow(R, 2) * Math.PI;
        }
    }
}
