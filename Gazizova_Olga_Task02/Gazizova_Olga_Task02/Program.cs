using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazizova_Olga_Task02
{
    class Program
    {
        static void Verifing(string k, out double a)
        {
            double f;
            while (!Double.TryParse(k, out f)||f<=0)
            {
                Console.WriteLine("Некорректное значение. Введите заново.");
                k = Console.ReadLine();
            }
            
            a = f;
        }
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Введите значение ширины прямоугольника");
            var str = Console.ReadLine();
            Verifing(str,out a);
            Console.WriteLine("Введите значение длины прямоугольника");
            str = Console.ReadLine();
            Verifing(str, out b);
            Console.WriteLine("Площадь прямоуголника составляет: {0}", a * b);
            Console.ReadKey();
        }
    }
}
