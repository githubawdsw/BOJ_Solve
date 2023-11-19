using System;
using System.Collections.Generic;
using System.Text;
namespace Tree
{
    
    class BOJ_14267
    {
        static  List<int>[] nodeList = new List<int>[100005];
        static int[] score = new int[100005];
        static int[] par = new int[100005];
        static string[] relationship;
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string[] inputnm = Console.ReadLine().Split(' ');
            int n = int.Parse(inputnm[0]);
            int m = int.Parse(inputnm[1]);

            relationship = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                int p = int.Parse(relationship[i]);
                par[i + 1] = p;
                if (relationship[i] == "-1")
                    continue;
                if (nodeList[p] == null)
                    nodeList[p] = new List<int>();
                nodeList[p].Add(i + 1);
            }
            for (int i = 0; i < m; i++)
            {
                string[] inputPraise = Console.ReadLine().Split(' ');
                int number = int.Parse(inputPraise[0]);
                int w = int.Parse(inputPraise[1]);
                score[number] += w;
            }
            dfs(1);
            for (int i = 1; i <= n; i++)
                sb.Append($"{score[i]} ");
            Console.WriteLine(sb);
        }
        static void dfs(int node)
        {
            if (par[node] != -1)
                score[node] += score[par[node]];
            if (nodeList[node] == null)
                return;
            foreach (var one in nodeList[node])
                dfs(one);
        }
    }
    
}
