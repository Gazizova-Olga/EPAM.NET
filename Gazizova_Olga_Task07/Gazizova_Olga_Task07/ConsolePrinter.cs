using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazizova_Olga_Task07
{
    class ConsolePrinter:IPrinter
    {
        public virtual void Print(Figure f)
        {
            Console.WriteLine($"{f.GetType().Name}");
        }
    }
}
