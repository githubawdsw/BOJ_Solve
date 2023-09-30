using System;
using System.Linq;

namespace Dynamic
{
    
    class BOJ_1965
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] inputarr = Console.ReadLine().Split(' ');
            int[] dp = new int[1005];

            for (int i = 0; i < inputarr.Length; i++)
                dp[i] = 1;
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                    if (int.Parse(inputarr[i]) > int.Parse(inputarr[j]))
                        dp[i] = Math.Max(dp[j] + 1, dp[i]);
            }
            Console.WriteLine(  dp.Max());
        }
    }
    
}
