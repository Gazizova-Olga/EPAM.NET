using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Task3
{
    class Program

    {
        public static void GetNationInfo(string s)
        {
            var culture = CultureInfo.CreateSpecificCulture(s);
            Console.WriteLine(culture.DisplayName);
            Console.Write("Представление даты: ");
            Console.WriteLine(culture.DateTimeFormat.FullDateTimePattern);
            Console.Write("Десятичный разделитель: ");
            Console.WriteLine(culture.NumberFormat.NumberDecimalSeparator);
            Console.Write("Разделитель групп разрядов: ");
            Console.WriteLine(culture.NumberFormat.NumberGroupSeparator);
        }

        static public void GetInvariantInfo()
        {
            Console.WriteLine(CultureInfo.InvariantCulture.DisplayName);
            Console.Write("Представление даты: ");
            Console.WriteLine(CultureInfo.InvariantCulture.DateTimeFormat.FullDateTimePattern);
            Console.Write("Десятичный разделитель: ");
            Console.WriteLine(CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator);
            Console.Write("Разделитель групп разрядов: ");
            Console.WriteLine(CultureInfo.InvariantCulture.NumberFormat.NumberGroupSeparator);
        }
        static void Main(string[] args)
        {
            
            GetNationInfo("ru");
            Console.WriteLine();
            GetNationInfo("en");
            Console.WriteLine();
            Console.ReadKey();

            GetInvariantInfo();
            Console.WriteLine();
            GetNationInfo("en");
            Console.WriteLine();
            Console.ReadKey();

            GetInvariantInfo();
            Console.WriteLine();
            GetNationInfo("ru");
            Console.WriteLine();
            Console.ReadKey();

        }

       
    }
}
