using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilter
{
    class TextFilter
    {
        static void Main()
        {
            string[] bannedWords = Console.ReadLine().Split(new char[]{ ' ', ',', '.', ':', '\t' },
                                                            StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
            for (int i = 0; i < bannedWords.Length; i++)
            {
                while (text.Contains(bannedWords[i]))
                {
                    string replace = new string('*', bannedWords[i].Length);
                    text = text.Replace(bannedWords[i], replace);
                }
            }
            Console.WriteLine(text); 
        }
    }
}
