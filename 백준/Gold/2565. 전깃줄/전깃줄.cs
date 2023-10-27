using System;
using System.Collections.Generic;
using System.Linq;

namespace Dynamic
{
    class BOJ_2565
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Tuple<int,int>> tupleList = new List<Tuple<int,int>>();
            for (int i = 0; i < n; i++)
            {
                string[] inputab = Console.ReadLine().Split(' ');
                int a = int.Parse(inputab[0]);
                int b = int.Parse(inputab[1]);
                tupleList.Add(new Tuple<int, int>(a, b));
            }
            tupleList.Sort();

            int[] dp = new int[105];
            for (int i = 0; i < n; i++)
                dp[i] = 1;
            
            for (int i = 0; i < n; i++)
                for (int j = 0; j < i; j++)
                    if (tupleList[i].Item2 > tupleList[j].Item2)
                        dp[i] = Math.Max(dp[j] + 1, dp[i]);

            int ans = n - dp.Max();
            Console.WriteLine(  ans);
        }
    }
    
}
