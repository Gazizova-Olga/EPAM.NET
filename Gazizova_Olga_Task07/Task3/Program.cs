using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            
                IIndexableSeries progression = new ArithmeticalProgression(2, 2);
                Console.WriteLine("Progression:");
                PrintSeries(progression);

                IIndexableSeries list = new List(new double[] { 5, 8, 6, 3, 1 });
                Console.WriteLine("List:");
                PrintSeries(list);

                Console.ReadKey();
        }

            static void PrintSeries(IIndexableSeries series)
            {
                series.Reset();

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(series[i]);
                    series.MoveNext();
                }
            }
    }
    
}
