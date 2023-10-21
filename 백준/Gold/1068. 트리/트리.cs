using System;
using System.Collections.Generic;
using System.Linq;
namespace Tree
{
    
    class BOJ_1068
    {
        static List<int>[] nodeList = new List<int>[55];
        static int ans = 0;
        static int del;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] nodeinfo = Console.ReadLine().Split(' ');
            del = int.Parse(Console.ReadLine());

            int root = 0;
            for (int i = 0; i < nodeinfo.Length; i++)
            {
                if (nodeinfo[i] == "-1")
                {
                    root = i;
                    continue;
                }
                int par = int.Parse(nodeinfo[i]);
                if (par == del || i == del) 
                    continue;

                if (nodeList[par] == null)
                    nodeList[par] = new List<int>();
                nodeList[par].Add(i);
            }
            if(root == del)
            {
                Console.WriteLine(0);
                return;
            }

            dfs(root);
            Console.WriteLine(ans);
        }
        static void dfs(int node)
        {
            if( nodeList[node] == null)
            {
                ans++;
                return;
            }
            foreach (var one in nodeList[node])
                dfs(one);

        }
    }
    
}
