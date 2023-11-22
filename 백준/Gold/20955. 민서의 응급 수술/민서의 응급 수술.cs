using System;
using System.Collections.Generic;
using System.Text;
namespace Tree
{
    
    class BOJ_20955
    {
        static bool[] vis = new bool[100005];
        static  List<int>[] nodeList = new List<int>[100005];
        static int ans = 0;
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string[] inputnm = Console.ReadLine().Split(' ');
            int n = int.Parse(inputnm[0]);
            int m = int.Parse(inputnm[1]);

            for (int i = 0; i < m; i++)
            {
                string[] inputLinked = Console.ReadLine().Split(' ');
                int p1 = int.Parse(inputLinked[0]);
                int p2 = int.Parse(inputLinked[1]);

                if (nodeList[p1] == null)
                    nodeList[p1] = new List<int>();
                if (nodeList[p2] == null)
                    nodeList[p2] = new List<int>();
                nodeList[p1].Add(p2);
                nodeList[p2].Add(p1);
            }

            for (int i = 1; i <= n; i++)
            {
                if (nodeList[i] == null)
                {
                    ans++;
                    continue;
                }
                if (vis[i])
                    continue;
                dfs(i);
                ans++;
            }
            Console.WriteLine((ans - 1) + (m + ans - 1) - (n - 1));
        }
        static void dfs(int node)
        {
            if (vis[node])
                return;
            vis[node] = true;
            foreach (var one in nodeList[node])
                dfs(one);
            
        }
    }
    
}
