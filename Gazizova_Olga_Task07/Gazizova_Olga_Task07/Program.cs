using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazizova_Olga_Task07
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = new Line(0, 0, 1, 1);
            var circle = new Circle(0, 0, 4);
            var round = new Round(4, 4, 2);
            var ring = new Ring(1, 1, 8, 3);
            var rectangle = new Rectangle(1, 1, 5, 7);
            List<Figure> figures = new List<Figure>();
            figures.Add(line);
            figures.Add(circle);
            figures.Add(round);
            figures.Add(ring);
            figures.Add(rectangle);
            Canvas canvas = new Canvas();
            ConsolePrinter printer = new ConsolePrinter();
            canvas.DrawAll(printer, figures);
            Console.ReadKey();
        }
    }
}
