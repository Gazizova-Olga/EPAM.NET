using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task4
{
    class Program
    {
        public static void TestString(int num)
        {
            string str = "";
            for (int i = 0; i < num; i++)
            {
                str += "*";
            }
        }

        public static void TestBuilder(int num)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < num; i++)
            {
                sb.Append("*");
            }
            string str = sb.ToString();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество циклов");
            int n =  Int32.Parse(Console.ReadLine());
            Stopwatch watch = new Stopwatch();
            watch.Start();
            TestString(n);
            watch.Stop();
            Console.WriteLine("Строки: {0}",watch.Elapsed.TotalMilliseconds);
            watch.Reset();
            watch.Start();
            TestBuilder(n);
            watch.Stop();
            Console.WriteLine("StringBuilder: {0}",watch.Elapsed.TotalMilliseconds);
            Console.ReadKey();

        }
    }
}
