using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
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

        public static void Generate(Random rand, int[,] arr)
        {
            int dim = arr.GetLength(0);
            int dim1 = arr.GetLength(1);
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim1; j++)
                {
                    arr[i,j] = rand.Next(50);
                }
            }
        }
        public static int Sum(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if ((i + j) % 2 != 0)
                    {
                        sum = sum + arr[i, j];
                    }
                }
            }
            return sum;
        }
        public static void Printing(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine("Numbers[{0},{1}]= {2}", i, j, arr[i, j]);
                }
            }
        }
        static void Main(string[] args)
        {
            int a, b;
            Random rnd = new Random();
            Console.WriteLine("Введите 2 измерения двухмерного массива \nПервое ");
            string str = Console.ReadLine();
            Verifing(str, out a);
            Console.WriteLine("Второе");
            str = Console.ReadLine();
            Verifing(str, out b);
            int[,] numbers = new int[a, b];
            Generate(rnd,numbers);
            Printing(numbers);
            Console.WriteLine("Сумма требуемых элементов {0}", Sum(numbers));
            Console.ReadKey();
        }
    }
}
