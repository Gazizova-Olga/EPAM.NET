using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazizova_Olga_Task07
{
    class Canvas
    {
        public void DrawAll(IPrinter printer, List<Figure> figures)
        {
            foreach (var item in figures)
            {
                printer.Print(item);
            }
        }
    }
}
