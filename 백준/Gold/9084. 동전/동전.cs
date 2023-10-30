using System;
using System.Collections.Generic;
namespace Dynamic
{
    
    class BOJ_9084
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while (t> 0)
            {
                t--;
                int n = int.Parse(Console.ReadLine());
                string[] coin = Console.ReadLine().Split(' ');
                int target = int.Parse(Console.ReadLine());
                int[] d = new int[10005];

                d[0] = 1;
                for (int i = 0; i < n; i++)
                {
                    for (int j = int.Parse(coin[i]); j <= target; j++)
                    {
                        d[j] += d[j - int.Parse(coin[i])];
                    }
                }

                Console.WriteLine(d[target]);
            }


        }
    }
    
}
