using System;
using System.Collections.Generic;
namespace MathAlgorithm
{
    
    class BOJ_1193
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int denominator;
            int numerator;

            int i = 1;
            while (n > i)
            {
                n -= i;
                i++;
            }
            denominator = i - n + 1;
            numerator = n;
            if (i % 2 == 1)
            {
                int swap = denominator;
                denominator = numerator;
                numerator = swap;
            }

            Console.WriteLine($"{numerator}/{denominator}");
        }
    }
    
}
