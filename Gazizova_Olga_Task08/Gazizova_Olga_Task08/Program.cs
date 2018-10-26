using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazizova_Olga_Task08
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArray<int> test1 = new DynamicArray<int>();
            for (int i = 1; i < 5; i++)
            {
                test1.Add(i);
            }
            for (int i = 0; i < test1.Length; i++)
            {
                Console.WriteLine(test1[i]);
            }
            Console.WriteLine();
            test1.Insert(8, test1.Length);
            for (int i = 0; i < test1.Length; i++)
            {
                Console.WriteLine(test1[i]);
            }
            Console.ReadKey();
        }
    }
}
