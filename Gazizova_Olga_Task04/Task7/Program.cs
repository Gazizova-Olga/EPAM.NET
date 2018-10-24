using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task7
{
    class Program
    {
        public static int CountTime(string s)
        {
            int marker = 0;
            Regex pattern = new Regex(@"(\s|^)(([0-9]|1[0-9]|2[0-3]):[0-5][0-9])(\s|$|\p{P})");
            Match sent = pattern.Match(s);
            while (sent.Success)
            {
                marker++;
                sent= sent.NextMatch();
            }
            return marker;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите фразу");
            string str = Console.ReadLine();
            Console.WriteLine("Время встречается в тексте {0} раз(а)", CountTime(str));
            Console.ReadKey();
        }
    }
}
