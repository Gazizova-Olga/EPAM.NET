using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazizova_Olga_Task04
{
    class Program
    {
        public static double FindMedium(string s)
        {
            int mark = s.Length;
            double index = 0, 
                sum = 0,
                k=0,
                medium=0.00;
            for (int i = 0; i < mark; i++)
            {
                if (char.IsLetter(s[i]))
                {
                    index++;
                }
                else
                {
                    if (index != 0)
                    {
                        sum += index;
                        k++;
                        index = 0;
                    }
                }
            }
            sum += index;
            k++;
            medium = sum / k;
            return medium;
        }
       
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            Console.WriteLine("Средняя длина слова {0:N}", FindMedium(str));
            Console.ReadKey();
        }
    }
}
