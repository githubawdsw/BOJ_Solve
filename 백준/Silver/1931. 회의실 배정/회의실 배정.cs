using System;
using System.Collections.Generic;
using System.Linq;
namespace GreedyAlgorithm
{
    
    class BOJ_1931
    {
        static int n;
        static List<Tuple<int, int>> inputtime = new List<Tuple<int, int>>();
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] time = Console.ReadLine().Split(' ');
                inputtime.Add(new Tuple<int, int>(int.Parse(time[0]), int.Parse(time[1])));
            }

            inputtime = inputtime.OrderBy(x => x.Item2).ThenBy(x => x.Item1).ToList();

            int ans = 0;
            int t = 0;
            for (int i = 0; i < n; i++)
            {
                if (t > inputtime[i].Item1)
                    continue;
                ans++;
                t = inputtime[i].Item2;
            }

            Console.WriteLine(ans);
        }
    }
    
}
