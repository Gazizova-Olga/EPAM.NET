using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazizova_Olga_Task03
{
    class Program
    {

        public static int SortingArr(int[] arr)
        {
            int l = arr.Length;
            int temp = 0;
            for (int i = 0; i < l; i++)
            {
                for (int j = i + 1; j < l; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
           return arr[l-1];
        }

        public static void Printing(int[] arr)
        {
            foreach (var elem in arr)
            {
                Console.WriteLine(elem);
            }
        }

        public static int FindMax(int[] arr)
        {
            int mark = arr[0];
            int l = arr.Length;
            for (int i = 1; i < l; i++)
            {
                if (mark < arr[i])
                {
                    mark = arr[i];
                }
            }
            return mark;
        }
        public static int FindMin(int[] arr)
        {
            int mark = arr[0];
            int l = arr.Length;
            for (int i = 1; i < l; i++)
            {
                if (mark > arr[i])
                {
                    mark = arr[i];
                }
            }
            return mark;
        }
        public static int Generate(int []arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                arr[i] = rnd.Next(500);
            }
            return arr[99];
        }
        static void Main(string[] args)
        {
            int[] numbers = new int[100];
            Generate(numbers);
            Console.WriteLine("Maximum: {0}",FindMax(numbers));
            Console.WriteLine("Minimum: {0}", FindMin(numbers));
            SortingArr(numbers);
            Printing(numbers);
            Console.ReadKey();
        }
    }
}
