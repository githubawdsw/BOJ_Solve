using System;
using System.Collections.Generic;

namespace MathAlgorithm
{
    
    class BOJ_2869
    {
        static void Main(string[] args)
        {
            string[] inputABV = Console.ReadLine().Split(' ');
            int a, b, v;
            a = int.Parse(inputABV[0]);
            b = int.Parse(inputABV[1]);
            v = int.Parse(inputABV[2]);
            int count = 0;

            count = (v - b) / (a - b);
            if ((v - b) % (a - b) > 0)
                count++;
            Console.WriteLine(count);
        }
    }
    
}
