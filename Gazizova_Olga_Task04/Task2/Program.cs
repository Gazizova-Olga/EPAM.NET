using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        public static void CollectLetters(ref string s)
        {
            var temp= new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]))
                {
                    temp.Append(s[i]);
                }
            }
            s = temp.ToString();
        }
        

        public static string Duplicate(string first, string second)
        {
            int len1 = first.Length;
            int len2 = second.Length;
            var exo=new StringBuilder();
            string ex;
            for (int i = 0; i < len1; i++)
            {
                exo.Append(first[i]);
                for (int j = 0; j < len2; j++)
                {
                    if (first[i] == second[j])
                    {
                        exo.Append(first[i]);
                        break;
                    }
                }
            }
            ex = exo.ToString();
            return ex;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую строоку");
            string str=Console.ReadLine();
            Console.WriteLine("Введите контрольную строку");
            string control = Console.ReadLine();
            CollectLetters(ref control);
            Console.WriteLine("Итоговая строка: {0}", Duplicate(str,control));
            Console.ReadKey();
        }
    }
}
