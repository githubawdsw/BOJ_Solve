using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace Sorting
{
    
    class BOJ_2910
    {
        static int N;
        static long C;
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            string[] inputNC = Console.ReadLine().Split(' ');
            N = int.Parse(inputNC[0]);
            C = long.Parse(inputNC[1]);

            string[] inputarr = Console.ReadLine().Split(' ');
            long[] countlist = new long[N];
            for (int i = 0; i < N; i++)
            {
                countlist[i] = long.Parse(inputarr[i]);
            }

            var groupby = countlist.GroupBy(x => x).OrderByDescending(x => x.Count());
            foreach(var g in groupby)
            {
                if (g.Key == 0)
                    continue;
                for (int i = 0; i < g.Count(); i++)
                {
                    sb.Append($"{g.Key} ");
                }
            }
            Console.WriteLine(sb);
        }

    }
}
