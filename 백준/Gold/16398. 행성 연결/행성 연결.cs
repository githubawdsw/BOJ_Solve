using System;
using System.Collections.Generic;

namespace Minimum_Spanning_Tree
{
    
    class BOJ_16398
    {
        static List<Tuple<int, int, int>> costList = new List<Tuple<int, int, int>>();
        static int[] par = new int[1005];
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string[] inputcost = Console.ReadLine().Split(' ');
                for (int j = i; j < n; j++)
                    costList.Add(new Tuple<int, int, int>(int.Parse(inputcost[j]), i, j + 1));
            }

            costList.Sort();
            long ans = 0;
            int count = 0;
            if(n == 1)
            {
                Console.WriteLine(ans);
                return;
            }
            for (int i = 0; i < costList.Count; i++)
            {
                var cur = costList[i];
                if (!is_diff_group(cur.Item2, cur.Item3))
                    continue;
                ans += cur.Item1;
                count++;
                if (count == n - 1)
                    break;
            }
            Console.WriteLine(ans);
        }
        static bool is_diff_group(int a, int b)
        {
            a = unionfind(a); b = unionfind(b);
            if (a == b)
                return false;

            if (par[a] == par[b])
                par[a]--;
            if (par[a] < par[b])
                par[b] = a;
            else
                par[a] = b;
            return true;
        }
        static int unionfind(int x)
        {
            if (par[x] <= 0)
                return x;
            return par[x] = unionfind(par[x]);
        }
    }
    
}
