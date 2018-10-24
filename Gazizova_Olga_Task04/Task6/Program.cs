using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task6
{
    class Program
    {
        public static void CheckForm(string s)
        {
            Regex patternNorm = new Regex(@"^-?[0-9]+\.?[0-9]+$");     
            Regex patternScience = new Regex(@"^-?[0-9]\.?[0-9]+e[-+]?[0-9]+$");                           
            Match controlNorm = patternNorm.Match(s);
            Match controlSci = patternScience.Match(s);
            if (controlSci.Success)
            {
                Console.WriteLine("Число в научной нотации");
            }
            else
            {
                if (controlNorm.Success)
                {
                    Console.WriteLine("Число в обычной нотации");
                }
                else
                {
                    Console.WriteLine("Введенная последовательность символов числом не является.");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            string number = Console.ReadLine();
            CheckForm(number);
            Console.ReadKey();
        }
    }
}
