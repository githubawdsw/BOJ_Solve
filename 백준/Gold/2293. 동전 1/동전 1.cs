using System;
using System.Collections.Generic;
namespace Dynamic
{
    
    class BOJ_2293
    {
        static int n, k;
        static int[] d = new int[10005];
        static List<int> coin = new List<int>();
        static void Main(string[] args)
        {
            string[] inputnk = Console.ReadLine().Split(' ');
            n = int.Parse(inputnk[0]);
            k = int.Parse(inputnk[1]);

            for (int i = 0; i < n; i++)
                coin.Add(int.Parse(Console.ReadLine()));

            d[0] = 1;
            for (int i = 0; i < n; i++)
                for (int j = coin[i]; j <= k; j++)
                    d[j] += d[j - coin[i]];
                
            Console.WriteLine(d[k]);
        }
    }
    
}
