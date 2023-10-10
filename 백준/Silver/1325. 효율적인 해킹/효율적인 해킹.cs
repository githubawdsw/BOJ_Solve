using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graph
{
    
    class BOJ_1325 
    {
        static List<int>[] arrList = new List<int>[10005];
        static StringBuilder sb = new StringBuilder();
        static bool[] vis;
        static int max = 0;
        static int count = 0;
        static void Main(string[] args)
        {
            string[] inputnm = Console.ReadLine().Split(' ');
            int n = int.Parse(inputnm[0]);
            int m = int.Parse(inputnm[1]);
            while (m-- > 0)
            {
                string[] trust = Console.ReadLine().Split(' ');
                int p1 = int.Parse(trust[0]);
                int p2 = int.Parse(trust[1]);

                if (arrList[p2] == null)
                    arrList[p2] = new List<int>();

                arrList[p2].Add(p1);
            }

            int[] ans = new int[10005];
            for (int i = 1; i <= n; i++)
            {
                if (arrList[i] == null)
                    continue;
                count = 1;
                vis = new bool[10005];
                vis[i] = true;
                dfs(i );
                ans[i] = count;
            }
            for (int i = 1; i <= n; i++)
            {
                if (max == ans[i])
                    sb.Append($"{i} ");
            }

            Console.WriteLine(sb);
        }
        static void dfs(int node)
        {
            max = Math.Max(max, count);
            if (arrList[node] == null)
                return;
            foreach (var one in arrList[node])
            {
                if (vis[one] )
                    continue;
                count++;
                vis[one] = true;
                dfs(one);
            }
        }
    }
    
}
