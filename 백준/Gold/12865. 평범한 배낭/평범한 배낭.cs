using System;
using System.Collections.Generic;
using System.Linq;
namespace Dynamic
{
    
    class BOJ_12865
    {
        static int n, k;
        static int[,] d = new int[105 ,100005];
        static List<Tuple<int, int>> backpack = new List<Tuple<int, int>>();
        static void Main(string[] args)
        {
            string[] inputnk = Console.ReadLine().Split(' ');
            n = int.Parse(inputnk[0]);
            k = int.Parse(inputnk[1]);

            backpack.Add(new Tuple<int, int>(0, 0));
            for (int i = 0; i < n; i++)
            {
                string[] inputbp = Console.ReadLine().Split(' ');
                backpack.Add(new Tuple<int, int>(int.Parse(inputbp[0]), int.Parse(inputbp[1])));
            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j <= k; j++)
                {
                    d[i, j] = d[i - 1, j];
                    if(backpack[i].Item1 <= j)
                        d[i, j] = Math.Max(backpack[i].Item2 + d[i - 1, j - backpack[i].Item1], d[i, j]);
                }
            }

            Console.WriteLine(d[n,k]);
        }
    }
    
}
