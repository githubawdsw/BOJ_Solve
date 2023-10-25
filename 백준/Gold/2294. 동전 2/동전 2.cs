using System;
using System.Collections.Generic;
namespace Dynamic
{
    
    class BOJ_2294
    {
        static int n, k;
        static int[] d = new int[10005];
        static List<int> coin = new List<int>();
        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');
            n = int.Parse(nk[0]);
            k = int.Parse(nk[1]);
            for (int i = 0; i < n; i++)
               coin.Add(int.Parse(Console.ReadLine()));
            for (int i = 0; i < d.Length; i++)
                d[i] = 100005;

            d[0] = 0;
            for (int i = 0; i < n; i++)
                for (int j = coin[i]; j <= k; j++)
                    d[j] = Math.Min(d[j], d[j - coin[i]] + 1) ;
                
            Console.WriteLine(d[k] == 100005 ? -1 : d[k]);
            
        }
    }
    
}
