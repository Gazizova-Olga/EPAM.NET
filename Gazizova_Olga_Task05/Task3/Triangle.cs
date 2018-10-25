using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Triangle
    {
        private double a;
        public double A
        {
            get
            {
                return a;
            }
            set
            {
                if (value > 0)
                {
                    a = value;
                }
                else
                {
                    Console.WriteLine("Некорректное значение");
                }
            }
        }

        private double b;
        public double B
        {
            get
            {
                return b;
            }
            set
            {
                if (value > 0)
                {
                    b = value;
                }
                else
                {
                    Console.WriteLine("Некорректное значение");
                }
            }
        }

        private double c;
        public double C
        {
            get
            {
                return c;
            }
            set
            {
                if (value > 0)
                {
                    c = value;
                }
                else
                {
                    Console.WriteLine("Некорректное значение");
                }
            }
        }

        public Triangle(double a, double b, double c)
        {
            string ex = "Треугольника с такими сторонами не существует";
            if (a + b <= c || b + c <= a || a + c <= b)
            {
                throw new Exception(ex);
            }
            else
            {
                A = a;
                B = b;
                C = c;
            }
        }

        public double GetLenth()
        {
            return A + B + C;
        }

        public double GetSquare()
        {
            double p = (A + B + C) / 2;
            return Math.Pow(p * (p - A) * (p - B) * (p - C), 0.5);
        }
    }
}
