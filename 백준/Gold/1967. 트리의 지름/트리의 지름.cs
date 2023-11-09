using System;
using System.Collections.Generic;
using System.Linq;
namespace Tree
{
    
    class BOJ_1967
    {
        static Dictionary<int, int>[] nodeDict = new Dictionary<int, int>[10005];
        static bool[] vis;
        static int max;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if(n == 1)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = 0; i < n - 1; i++)
            {
                string[] nodepcw = Console.ReadLine().Split(' ');
                int p = int.Parse(nodepcw[0]);
                int c = int.Parse(nodepcw[1]);
                int w = int.Parse(nodepcw[2]);
                if (nodeDict[p] == null)
                    nodeDict[p] = new Dictionary<int, int>();
                if (nodeDict[c] == null)
                    nodeDict[c] = new Dictionary<int, int>();
                nodeDict[p][c] = w;
                nodeDict[c][p] = w;
            }

            int ans = 0;
            int length;
            for (int i = 1; i <= n; i++)
            {
                length = 0;
                max = 0;
                vis = new bool[10005];
                vis[i] = true;
                dfs(i , length );
                ans = Math.Max(ans , max);
            }
            Console.WriteLine(ans);
        }
        static void dfs(int node, int length)
        {
            foreach (var one in nodeDict[node])
            {
                if (vis[one.Key])
                    continue;
                int sum = length;
                vis[one.Key] = true;
                sum += one.Value;
                max = Math.Max(max, sum);
                dfs(one.Key , sum);
            }
        }
    }
    
}
