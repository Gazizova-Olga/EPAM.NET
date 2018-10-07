using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
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
            for (int s = k - 1; s >= 0; s--)
            {
                for (int i = 1; i <= k - s; i++)
                {
                    string str_empty = new string(' ', k - i);
                    string str_star = new string('*', 1 + 2 * (i - 1));
                    string fin = str_empty + str_star;

                    Console.WriteLine(fin);
                }
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Сколько ярусов у ёлки?");
            string str = Console.ReadLine();
            Verifing(str,out n);
            Printing(n);
            Console.ReadKey();
        }
    }
}
