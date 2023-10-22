using System;
using System.Collections.Generic;

namespace MathAlgorithm
{
    
    class BOJ_1456
    {
        static void Main(string[] args)
        {
            string[] inputAB = Console.ReadLine().Split(' ');
            long A = long.Parse(inputAB[0]);
            long B = long.Parse(inputAB[1]);
            List<long> primelist = new List<long>();
            bool[] check = new bool[10000005];
            check[1] = true;
            for (long i = 2; i * i < check.Length; i++)
            {
                if (check[i] == true)
                    continue;
                for (long j = i; j * i < check.Length; j++)
                    check[j * i] = true;
            }

            for (int i = 2; i < check.Length; i++)
            {
                if (check[i] == false)
                    primelist.Add(i);
            }

            int count = 0;
            foreach ( var one in primelist)
            {
                for (long i = one; i <= B / one; i *= one)
                {
                    if( i  * one>= A )
                        count++;
                }
            }
            Console.WriteLine(count);
        }
    }
    
}
