using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersChangeNumbers
{
    class LettersChangeNumbers
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[]{' ','\t'},StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char frontLetter = input[i].First();
                char endLetter = input[i].Last();
                double num = double.Parse(input[i].Substring(1, input[i].Length - 2));
                double tempSum = 0;
                if (char.IsUpper(frontLetter))
                {
                    tempSum = num / (frontLetter - 64);
                }
                else
                {
                    tempSum = num * (frontLetter - 96);
                }
                if (char.IsUpper(endLetter))
                {
                    tempSum -= endLetter - 64;
                }
                else
                {
                    tempSum += endLetter - 96;
                }
                sum += tempSum;
            }
            Console.WriteLine("{0:F2}",sum);
        }
    }
}
