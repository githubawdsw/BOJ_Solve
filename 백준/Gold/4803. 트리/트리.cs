using System;
using System.Collections.Generic;
using System.Text;
namespace Tree
{

    class BOJ_4803
    {
        static List<int>[] nodeList;
        static bool isTree = false;

        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int tcase = 0;
            while (true)
            {
                nodeList = new List<int>[505];
                bool[] vis = new bool[505];
                int count = 0;

                string[] inputnm = Console.ReadLine().Split(' ');
                int n = int.Parse(inputnm[0]);
                int m = int.Parse(inputnm[1]);
                if (n == 0 && m == 0)
                    break;
               
                if (m == 0)
                {
                     if (n == 1)
                        sb.AppendLine($"Case {++tcase}: There is one tree.");
                     else
                        sb.AppendLine($"Case {++tcase}: A forest of {n} trees.");
                    continue;
                }
                for (int i = 0; i < m; i++)
                {
                    string[] inputNode = Console.ReadLine().Split(' ');
                    int p1 = int.Parse(inputNode[0]);
                    int p2 = int.Parse(inputNode[1]);
                    if (nodeList[p1] == null)
                        nodeList[p1] = new List<int>();
                    if (nodeList[p2] == null)
                        nodeList[p2] = new List<int>();
                    nodeList[p1].Add(p2);
                    nodeList[p2].Add(p1);
                }

                for (int i = 1; i <= n; i++)
                {
                    if (vis[i] )
                        continue;
                    if( nodeList[i] == null)
                    {
                        count++;
                        continue;
                    }
                    vis[i] = true;
                    isTree = true;
                    dfs(i , vis , -1);
                    if(isTree)
                        count++;
                }
                if (count == 0 )
                    sb.AppendLine($"Case {++tcase}: No trees.");
                else if (count == 1)
                    sb.AppendLine($"Case {++tcase}: There is one tree.");
                else
                    sb.AppendLine($"Case {++tcase}: A forest of {count} trees.");
            }
            Console.Write(sb);
        }
        static void dfs(int node , bool[] vis , int par)
        {
            foreach (var one in nodeList[node])
            {
                if (one == par)
                    continue;
                if (vis[one])
                {
                    isTree = false;
                    return;
                }
                vis[one] = true;
                dfs(one, vis , node);
            }
        }
    }
    
}
