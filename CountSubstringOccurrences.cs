using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CountSubstringOccurrences
{
    class CountSubstringOccurrences
    {
        static void Main()
        {
            string text = Console.ReadLine().ToLowerInvariant();
            string subStr = Console.ReadLine();
            int index = text.IndexOf(subStr);
            int count = 0;
            while ((index <= text.Length)&&(index >= 0))
            {
                count++;
                index = text.IndexOf(subStr, index + 1);
            }
            Console.WriteLine(count);
        }
    }
}
