using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task5
{
    class Program
    {
        public static void ReplaceTags(ref string s)
        {          
            s = Regex.Replace(s, @"<.*?>", "_"); 
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите HTML текст");
            string str = Console.ReadLine();
            ReplaceTags(ref str);
            Console.WriteLine("Итоговая строка: {0}", str);
            Console.ReadKey();
        }
    }
}
