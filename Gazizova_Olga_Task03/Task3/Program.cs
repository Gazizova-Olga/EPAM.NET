using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
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

        public static int Generate(int[] arr)
        {
            Random rnd = new Random();
            Random minus = new Random();
            int dim = arr.Length;
            for (int i = 0; i < dim; i++)
            {
                int mark = minus.Next(2);
                if (mark == 1)
                {
                    arr[i] = rnd.Next(50);
                }
                else
                    arr[i] = -rnd.Next(50);
            }

            return arr[dim - 1];
        }

        public static void Printing(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Numbers [{0}] ={1}", i, arr[i]);
            }
        }
        public static int Sum(int[] arr)
        {
            int goal=0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    goal += arr[i];
                }
            }
            return goal;
        }

        static void Main(string[] args)
        {
            int mas;
            Console.WriteLine("Какова размерность массива?");
            string str = Console.ReadLine();
            Verifing(str, out mas);
            int[] numbers = new int[mas];
            Generate(numbers);
            Printing(numbers);
            Console.WriteLine("Сумма неотрицательных элемнтов равна {0}", Sum(numbers));
            Console.ReadKey();

        }

    }
}
