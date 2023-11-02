using System;
using System.Collections.Generic;
using System.Text;
namespace Tree
{

    class BOJ_15681
    {
        static List<int>[] nodeList;
        static bool[] vis = new bool[100005];
        static int[] d = new int[100005];
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            nodeList = new List<int>[100005];

            string[] inputnrq = Console.ReadLine().Split(' ');
            int n = int.Parse(inputnrq[0]);
            int r = int.Parse(inputnrq[1]);
            int q = int.Parse(inputnrq[2]);

            for (int i = 0; i < n-1; i++)
            {
                string[] uv = Console.ReadLine().Split(' ');
                int u = int.Parse(uv[0]);
                int v = int.Parse(uv[1]);
                if (nodeList[u] == null)
                    nodeList[u] = new List<int>();
                if (nodeList[v] == null)
                    nodeList[v] = new List<int>();
                nodeList[u].Add(v);
                nodeList[v].Add(u);
            }
            dfs(r , -1);
            for (int i = 0; i < q; i++)
            {
                int inputQ = int.Parse(Console.ReadLine());
                sb.AppendLine((d[inputQ] + 1).ToString());
            }
            Console.WriteLine(sb);
        }
        static  int dfs(int node , int par)
        {
            foreach (var one in nodeList[node])
            {
                if (one == par)
                    continue;
                d[node] += dfs(one, node);
            }
            return d[node] + 1;
        }
    }
    
}
