using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    class Program
    {
        public static int Counting(int k)
        {
            int sum = 0;
            int mark = 0;
            while (mark < 1000)
            {
                mark = mark + k;
                sum += mark;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int temp = Counting(3) + Counting(5);
            Console.WriteLine("Сумма чисел  из диапазона от 0 до 1000, которые кратны 3 или 5, составляет {0}", temp);
            Console.ReadKey();
        }
    }
}
