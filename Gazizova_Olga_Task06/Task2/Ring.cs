using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Ring
    {
        private Round innerRound;
        private Round outerRound;

        public Ring(double x, double y, double radius, double innerRadius)
        {
            innerRound.X = x;
            innerRound.Y = y;
            innerRound.Radius = innerRadius;
            outerRound.Radius = radius;
        }

        private double x;
        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = innerRound.X;
            }
        }

        private double y;
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = innerRound.Y;
            }
        }

        private double outer;
        public double OuterLength
        {
            get
            {
                return outer;
            }
            set
            {
                outer = outerRound.GetLength();
            }
        }

        private double area;
        public double Area
        {
            get
            {
                return area;
            }
            set
            {
                area = Math.PI * Math.Pow(outerRound.Radius, 2) - Math.PI * Math.Pow(innerRound.Radius, 2);
            }
        }

        private double inner;
        public double InnerLength
        {
            get
            {
                return inner;
            }
            set
            {
                inner = Math.PI * 2 * innerRound.Radius;
            }
        }
    }
}
