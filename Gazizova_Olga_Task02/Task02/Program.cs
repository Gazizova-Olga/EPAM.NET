using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        public static void Verifing(string k, out int a)
        {
            int f;
            while (!Int32.TryParse(k, out f) || f <= 0)
            {
                Console.WriteLine("Некорректное значение. Введите заново.");
                k = Console.ReadLine();
            }
            a = f;
        }
        public static void Printing(int s)
        {
            for (int i = 1; i <= s; i++)
            {
                string str = new string('*', i);
                Console.WriteLine(str);
            }
        }
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите количество строк:");
            string n = Console.ReadLine();
            Verifing(n, out a);
            Printing(a);
            Console.ReadKey();
        }
    }
}
