using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Palindromes
    {
        static void Main()
        {
            string[] text = Console.ReadLine().Split(new char[] { ' ', ',', '!', '?', '.' },
                                                        StringSplitOptions.RemoveEmptyEntries);
            List<string> palindromes = new List<string>();
            for (int i = 0; i < text.Length; i++)
            {
                string reversed = ReversingString(text[i]);
                if (text[i]==reversed)
                {
                    palindromes.Add(text[i]);
                }
            }
            palindromes.Sort();
            Console.WriteLine(string.Join(", ",palindromes));
        }
        static string ReversingString(string s) 
        {
            StringBuilder reversed = new StringBuilder();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                reversed.Append(s[i]);
            }
            return reversed.ToString();
        }
    }
}
