using System;
using System.Collections.Generic;
using System.Linq;
namespace GreedyAlgorithm
{
    
    class BOJ_1700
    {
        static int n ,k;
        static int[] app = new int[105];
        static bool[] isUse = new bool[105];
        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');
            n = int.Parse(nk[0]);
            k = int.Parse(nk[1]);
            
            string[] inputarr = Console.ReadLine().Split(' ');

            for (int i = 1; i <= k; i++)
                app[i] = int.Parse(inputarr[i - 1]);

            int ans = 0;
            int count = 0;
            for (int i = 1; i <= k; i++)
            {
                int cur = app[i];

                if (isUse[cur])
                    continue;

                if (count < n)
                {
                    isUse[cur] = true;
                    count++;
                }
                else
                {
                    List<Tuple<int, int>> Tlist = new List<Tuple<int, int>>();
                    for (int j = 1; j <= k; j++)
                    {
                        if (isUse[j] == false)
                            continue;

                        bool vis = false;
                        for (int a = i+1; a <= k; a++)
                            if (app[a] == j)
                            {
                                Tlist.Add(new Tuple<int, int>(a, j));
                                vis = true;
                                break;
                            }

                        if (vis == false)
                            Tlist.Add(new Tuple<int, int>(k + 1, j));
                    }
                    Tlist = Tlist.OrderByDescending(x=>x.Item1).ThenByDescending(x=>x.Item2).ToList();
                    int target = Tlist[0].Item2;
                    isUse[target] = false;
                    ans++;
                    isUse[cur] = true;
                }
            }
            Console.WriteLine(ans);
        }
    }
    
}
