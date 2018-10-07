using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
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

        public static void Printing(int k)
        {
            for (int i = 1; i <= k; i++)
            {
                string str = new string(' ', k - i);
                string str_star = new string('*', 1 + 2 * (i - 1));
                string fin = str + str_star;
                Console.WriteLine(fin);
            }
        }

        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введите количество строк:");
            string line= Console.ReadLine();
            Verifing(line, out n);
            Printing(n);
            Console.ReadKey();
        }
    }
}
