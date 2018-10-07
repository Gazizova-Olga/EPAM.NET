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

        public static int Generate(int[,,] arr)
        {
            Random rnd = new Random ();
            Random minus = new Random();
            int dim = arr.GetLength(0);
            int dim1 = arr.GetLength(1);
            int dim2 = arr.GetLength(2);
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim1; j++)
                {
                    for (int k = 0; k < dim2; k++)
                    {
                        int mark = minus.Next(2);
                        if (mark == 1)
                        {
                            arr[i, j, k] = rnd.Next(100);
                        }
                        else
                            arr[i, j, k] = -rnd.Next(100);
                    }
                }
            }

            return arr[dim-1,dim1-1,dim2-1];
        }

        public static int Nullify(int[,,] arr)
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

            return arr[dim-1,dim1-1,dim2-1];
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
            Generate(numbers);
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
