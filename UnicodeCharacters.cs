using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main()
        {
            
            string word = Console.ReadLine();
            char[] elements = word.ToCharArray();
            for (int i = 0; i < elements.Length; i++)
            {
                int dec = elements[i];
                Console.Write("\\00" + dec.ToString("x"));
            }
            Console.WriteLine();
        }
    }
}
