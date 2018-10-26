using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя файла");
            var fileName = Console.ReadLine();
            if (File.Exists(fileName))
            {
                var fileContent = File.ReadAllText(fileName);
                fileContent = fileContent.ToLower();
                var words = SelectWords(fileContent);
                Counter test = new Counter(words);
                foreach (var item in test.Words)
                {
                    Console.WriteLine($"{item.Key}     {item.Value}");
                }
            }
            else
            {
                Console.WriteLine("Файл не найден");
            }
            Console.ReadKey();
        }

        public static string[] SelectWords(string str)
        {
            var words = Regex.Split(str, "\\W", RegexOptions.Multiline);
            return words;
        }
    }
}
