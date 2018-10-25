using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Round baloon = new Round();
            Console.WriteLine("Введите координаты центра круга. Х:");
            baloon.X = double.Parse(Console.ReadLine());
            Console.WriteLine("Y: ");
            baloon.Y = double.Parse(Console.ReadLine());
            Console.WriteLine("Радиус:");
            baloon.R = double.Parse(Console.ReadLine());
            Console.WriteLine("Длина окрудности: {0}\nПлощадь круга: {1}", baloon.GetLength(), baloon.GetSquare() );
            Console.ReadKey();
        }
    }
}
