using System;
using System.Collections.Generic;

namespace GreedyAlgorithm
{
    
    class BOJ_11047
    {
        static int n, k;
        static List<int> inputcoin = new List<int>();
        static void Main(string[] args)
        {
            string[] inputnk = Console.ReadLine().Split(' ');
            n = int.Parse(inputnk[0]);
            k = int.Parse(inputnk[1]);

            for (int i = 0; i < n; i++)
                inputcoin.Add(int.Parse(Console.ReadLine()));

            int ans = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                ans += k / inputcoin[i];
                k %= inputcoin[i];
            }
            Console.WriteLine(ans);
        }
    }
    
}
