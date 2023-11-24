using System;
using System.Collections.Generic;

namespace Minimum_Spanning_Tree
{
    class BOJ_1368
    {
        static List<Tuple<int, int, int>> costPi = new List<Tuple<int, int, int>>();
        static int[] par = new int[305];
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int cost = int.Parse(Console.ReadLine());
                costPi.Add( new Tuple<int, int, int>(cost, n + 1, i));
            }

            for (int i = 1; i <= n; i++)
            {
                string[] relation =Console.ReadLine().Split(' ');
                for (int j = i; j < n; j++)
                    costPi.Add( new Tuple<int, int, int>(int.Parse(relation[j]), i, j + 1));
            }
            costPi.Sort( );

            int ans = 0;
            int count = 0;
            for (int i = 0; i < costPi.Count; i++)
            {
                Tuple<int, int, int> cur = costPi[i];
                if (!is_diff_group(cur.Item2, cur.Item3))
                    continue;
                ans += cur.Item1;
                count++;
                if(count == n)
                    break;
            }
            Console.WriteLine(ans);
        }

        static bool is_diff_group(int u, int v)
        {
            u = find(u); v = find(v);
            if (u == v)
                return false;
            if (par[u] == par[v])
                par[u]--;

            if (par[u] < par[v])
                par[v] = u;
            else
                par[u] = v;

            return true;
        }

        static int find(int x)
        {
            if (par[x] <= 0 )
                return x;
            return par[x] = find(par[x]);
        }
    }

}
