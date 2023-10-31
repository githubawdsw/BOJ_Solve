using System;
using System.Collections.Generic;
namespace GreedyAlgorithm
{
    
    class BOJ_11000
    {
        static int n;
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());

            List<Tuple<int, int>> inputlist = new List<Tuple<int, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] st = Console.ReadLine().Split(' ');
                inputlist.Add(new Tuple<int, int>(int.Parse(st[0]), 1));
                inputlist.Add(new Tuple<int, int>(int.Parse(st[1]), -1));
            }

            inputlist.Sort();
            int ans = 0;
            int curtime = inputlist[0].Item1;
            int cur = 0;
            int index = 0;
            while (true)
            {
                while (index < 2 * n && inputlist[index].Item1 == curtime)
                {
                    cur += inputlist[index].Item2;
                    index++;
                }
                ans = Math.Max(ans, cur);
                if (index == 2 * n)
                    break;
                curtime = inputlist[index].Item1;
            }

            Console.WriteLine(ans);
        }
    }
    
}
