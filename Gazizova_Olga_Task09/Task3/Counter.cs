using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Counter
    {
        public Dictionary<string, int> Words { get; private set; }

        public Counter(string[] words)
        {
            Words = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (!string.IsNullOrEmpty(word))
                {
                    if (Words.ContainsKey(word))
                    {
                        Words[word]++;
                    }
                    else
                    {
                        Words.Add(word, 1);
                    }
                }

            }
        }
    }
}
