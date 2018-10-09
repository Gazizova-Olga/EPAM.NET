using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
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

        public static void Generate(Random rand, Random min, int[,,] arr)
        {
            int dim = arr.GetLength(0);
            int dim1 = arr.GetLength(1);
            int dim2 = arr.GetLength(2);
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim1; j++)
                {
                    for (int k = 0; k < dim2; k++)
                    {
                        int mark = min.Next(2);
                        if (mark == 1)
                        {
                            arr[i, j, k] = rand.Next(100);
                        }
                        else
                            arr[i, j, k] = -rand.Next(100);
                    }
                }
            }
        }

        public static void Nullify(int[,,] arr)
        {
            int dim = arr.GetLength(0);
            int dim1 = arr.GetLength(1);
            int dim2 = arr.GetLength(2);
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim1; j++)
                {
                    for (int k = 0; k < dim2; k++)
                    {
                        if (arr[i, j, k] > 0)
                        {
                            arr[i, j, k] = 0;
                        }
                    }
                }
            }
        }

        public static void Printing(int[,,] arr)
        {
            int dim = arr.GetLength(0);
            int dim1 = arr.GetLength(1);
            int dim2 = arr.GetLength(2);
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim1; j++)
                {
                    for (int k = 0; k < dim2; k++)
                    {
                        Console.WriteLine("Элемент [{0},{1},{2}]: {3}",i,j,k,arr[i,j,k]);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int a, b, c;
            Random rnd = new Random();
            Random minus = new Random();
            Console.WriteLine("Введите 3 измерения трехмерного массива \nПервое ");
            string str = Console.ReadLine();
            Verifing(str, out a);
            Console.WriteLine("Второе");
            str = Console.ReadLine();
            Verifing(str, out b);
            Console.WriteLine("Третье");
            str = Console.ReadLine();
            Verifing(str, out c);
            int[,,] numbers = new int[a, b, c];
            Generate(rnd, minus,numbers);
            Console.WriteLine("Исходный массив");
            Printing(numbers);
            Console.ReadKey();
            Nullify(numbers);
            Console.WriteLine("Массив с обнуленными элементами");
            Printing(numbers);
            Console.ReadKey();
        }

        }
}
