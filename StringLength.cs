using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLength
{
    class StringLength
    {
        static void Main()
        {
            string text = Console.ReadLine();
            if (text.Length <= 20)
            {
                Console.WriteLine(text.PadRight(20,'*'));
            }
            else
            {
                Console.WriteLine(text.Remove(21));
            }
        }
    }
}
