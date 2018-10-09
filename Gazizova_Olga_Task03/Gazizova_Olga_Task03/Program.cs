using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazizova_Olga_Task03
{
    class Program
    {

        public static void SortArray(int[] arr)
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
        public static void Generate(Random rand,int []arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(500);
            }
        }
        static void Main(string[] args)
        {
            int[] numbers = new int[100];
            Random rnd = new Random();
            Generate(rnd,numbers);
            Console.WriteLine("Maximum: {0}",FindMax(numbers));
            Console.WriteLine("Minimum: {0}", FindMin(numbers));
            SortArray(numbers);
            Printing(numbers);
            Console.ReadKey();
        }
    }
}
