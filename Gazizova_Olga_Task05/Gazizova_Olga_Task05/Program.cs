using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazizova_Olga_Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            User prob = new User("Tom", "Jerry", DateTime.Parse("2002.11.23"));
            Console.WriteLine("Возраст: {0}", prob.Age);
            Console.ReadKey();
        }
    }
}
