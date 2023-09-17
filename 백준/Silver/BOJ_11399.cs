using System;
using System.Collections.Generic;

namespace GreedyAlgorithm
{
    
    class BOJ_11399
    {
        static int n;
        static int[] d;
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            List<int> intlist = new List<int>();
            d = new int[n];

            string[] inputTime = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
                intlist.Add(int.Parse(inputTime[i]));
            intlist.Sort();

            d[0] = intlist[0];
            for (int i = 1; i < n; i++)
                d[i] = d[i-1] + intlist[i];

            int ans = 0;
            for (int i = 0; i < n; i++)
                ans += d[i];
            
            Console.WriteLine(ans);
        }
    }
    
}
