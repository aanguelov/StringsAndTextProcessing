using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class ReverseString
    {
        static void Main()
        {
            string text = Console.ReadLine();
            text = ReversingString(text);
            Console.WriteLine(text);
            
        }
        static string ReversingString(string s) 
        {
            StringBuilder reversed = new StringBuilder();
            for (int i = s.Length-1; i >= 0; i--)
            {
                reversed.Append(s[i]);
            }
            return reversed.ToString();
        }
    }
}
