using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazizova_Olga_Task07
{
    class Circle : Figure
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

            public Circle()
            {
                X = Y = 1;
            }

            public Circle(int x, int y, double r)
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

     /*   public override void DrawAll
        {
            base.Draw(p);
            Console.WriteLine("Центр:({0},{1}); радиус: {2}", this.X, Y, R);*/
       // }
    }
}

