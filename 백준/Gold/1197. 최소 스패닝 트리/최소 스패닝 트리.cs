using System;
using System.Collections.Generic;

namespace Minimum_Spanning_Tree
{
    class BOJ_1197
    {
        static int[] nodeArr = new int[10005];
        static void Main(string[] args)
        {
            string[] inputve = Console.ReadLine().Split(' ');
            int v = int.Parse(inputve[0]);
            int e = int.Parse(inputve[1]);

            Tuple<int, int, int>[] edge = new Tuple<int, int, int>[100005];
            for (int i = 0; i < e; i++)
            {
                string[] inputabc = Console.ReadLine().Split(' ');
                int a = int.Parse(inputabc[0]);
                int b = int.Parse(inputabc[1]);
                int c = int.Parse(inputabc[2]);
                edge[i] = new Tuple<int, int, int>(c, a, b);
            }
            Array.Sort(edge, 0, e);

            int count = 0;
            int ans = 0;
            for (int i = 0; i < e; i++)
            {
                Tuple<int, int, int> cur = edge[i];
                if (!is_diff_group(cur.Item2, cur.Item3))
                    continue;
                ans += cur.Item1;
                count++;
                if (count == v - 1)
                    break;
            }
            Console.WriteLine(ans);
        }
        static bool is_diff_group(int u, int v)
        {
            u = find(u); v = find(v);

            if (u == v)
                return false;
            if (nodeArr[u] == nodeArr[v])
                nodeArr[u]--;

            if (nodeArr[u] < nodeArr[v])
                nodeArr[v] = u;
            else
                nodeArr[u] = v;

            return true;
        }
        static int find(int x)
        {
            if (nodeArr[x] <= 0)
                return x;
            return nodeArr[x] = find(nodeArr[x]);
        }
    }
}
