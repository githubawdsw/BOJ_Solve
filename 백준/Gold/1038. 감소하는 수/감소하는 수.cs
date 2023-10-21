using System;
using System.Collections.Generic;

namespace MathAlgorithm
{
    
    class BOJ_1038
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<long> decreasingNum = new List<long>();
            for (int i = 1; i < 1024; i++)
            {
                int brute = i;
                long num = 0;
                for (int j = 9; j >= 0; j--)
                {
                    if (brute % 2 == 1)
                        num = 10 * num + j;
                    brute /= 2;
                }
                decreasingNum.Add(num);
            }

            decreasingNum.Sort();
            if (n > 1022)
                Console.WriteLine(-1);
            else
                Console.WriteLine(decreasingNum[n]);
        }
    }
    
}
