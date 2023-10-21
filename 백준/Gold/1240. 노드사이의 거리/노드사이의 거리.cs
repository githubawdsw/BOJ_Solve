using System;
using System.Collections.Generic;
using System.Text;
namespace Tree
{
    
    class BOJ_1240
    {
        static bool[] vis;
        static Dictionary<int, int>[] nodeDict = new Dictionary<int, int>[1005];
        static int ans = 0;
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            string[] inputnm = Console.ReadLine().Split(' ');
            int n = int.Parse(inputnm[0]);
            int m = int.Parse(inputnm[1]);

            for (int i = 0; i < n-1; i++)
            {
                string[] inputdist = Console.ReadLine().Split(' ');
                int p1 = int.Parse(inputdist[0]);
                int p2 = int.Parse(inputdist[1]);
                if (nodeDict[p1] == null)
                    nodeDict[p1] = new Dictionary<int, int>();
                if (nodeDict[p2] == null)
                    nodeDict[p2] = new Dictionary<int, int>();
                nodeDict[p1][p2] = int.Parse(inputdist[2]);
                nodeDict[p2][p1] = int.Parse(inputdist[2]);
            }

            for (int i = 0; i < m; i++)
            {
                string[] dist = Console.ReadLine().Split(' ');
                int p1 = int.Parse(dist[0]);
                int p2 = int.Parse(dist[1]);

                vis = new bool[1005];
                vis[p1] = true;
                ans = 0;
                dfs(p1, p2 , 0);
                sb.AppendLine(ans.ToString());
            }
            Console.WriteLine(sb);
        }
        static void dfs(int p1, int end, int count)
        {
            foreach (var one in nodeDict[p1])
            {
                if (vis[one.Key])
                    continue;
                if (one.Key == end)
                {
                    ans = count + one.Value;
                    return;
                }
                vis[one.Key] = true;
                dfs(one.Key, end , count + one.Value);
            }
        }
    }
    
}
