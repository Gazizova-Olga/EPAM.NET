using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazizova_Olga_Task07
{
    class Figure
    {
        public virtual void DrawAll(IPrinter p)
        {
            p.Print(this);
        }
    }
}
