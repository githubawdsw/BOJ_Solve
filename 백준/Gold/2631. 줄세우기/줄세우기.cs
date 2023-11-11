using System;
using System.Collections.Generic;
using System.Linq;

namespace Dynamic
{
    
    class BOJ_2631
    {
        static void Main(string[] args)
        {
            int[] dp = new int[205];
            int n = int.Parse(Console.ReadLine());
            List<int>list = new List<int>();
            for (int i = 0; i < n; i++)
                list.Add(int.Parse(Console.ReadLine()));
            for (int i = 0; i < n; i++)
                dp[i] = 1;

            for (int i = 1; i < n; i++)
                for (int j = 0; j < i; j++)
                    if (list[i] > list[j])
                        dp[i] = Math.Max(dp[j] + 1, dp[i]);

            Console.WriteLine(  n - dp.Max());
        }
    }
    
}
