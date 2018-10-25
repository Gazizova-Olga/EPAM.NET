using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны треугольника. А: ");
            var a = Double.Parse(Console.ReadLine());
            Console.WriteLine("B: ");
            var b = Double.Parse(Console.ReadLine());
            Console.WriteLine("C: ");
            var c = Double.Parse(Console.ReadLine());
            Triangle tri = new Triangle(a,b,c);
            Console.WriteLine("Периметр треугольника: {0}\nПлощадь треугольника: {1}", tri.GetLenth(), tri.GetSquare());
            Console.ReadKey();
        }
    }
}
