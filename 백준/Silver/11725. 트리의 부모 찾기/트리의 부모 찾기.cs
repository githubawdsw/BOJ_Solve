using System;
using System.Collections.Generic;
using System.Text;
namespace Tree
{
    class BOJ_11725
    {
        static int[] ans = new int[100005];
        static  List<int>[] nodeList = new List<int>[100005];
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n-1; i++)
            {
                string[] inputNode = Console.ReadLine().Split(' ');
                if (nodeList[int.Parse(inputNode[0])] == null)
                    nodeList[int.Parse(inputNode[0])] = new List<int>();
                if (nodeList[int.Parse(inputNode[1])] == null)
                    nodeList[int.Parse(inputNode[1])] = new List<int>();
                nodeList[int.Parse(inputNode[0])].Add(int.Parse(inputNode[1]));
                nodeList[int.Parse(inputNode[1])].Add(int.Parse(inputNode[0]));
            }
            dfs(1);
            StringBuilder sb = new StringBuilder();
            for (int i = 2; i <= n; i++)
                sb.AppendLine($"{ans[i]}");
            Console.WriteLine(sb);
        }
        static void dfs(int node)
        {
            foreach (var one in nodeList[node])
            {
                if (ans[node] == one)
                    continue;
                ans[one] = node;
                dfs(one);
            }
        }
    }

}
