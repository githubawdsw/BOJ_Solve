using System;
using System.Collections.Generic;

namespace MathAlgorithm
{
    
    class BOJ_1292
    {
        static void Main(string[] args)
        {
            string[] inputab = Console.ReadLine().Split(' ');
            int a = int.Parse(inputab[0]);
            int b = int.Parse(inputab[1]);

            List<int> arrlist = new List<int>();
            for (int i = 1; i <= b; i++)
                for (int j = 1; j <= i; j++)
                    arrlist.Add(i);

            int ans = 0;
            for (int i = a-1; i < b; i++)
                ans += arrlist[i];

            Console.WriteLine(ans);
        }
    }
    
}
