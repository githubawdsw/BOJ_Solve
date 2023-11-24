using System;
using System.Collections.Generic;
using System.Linq;
namespace Tree
{
    
    class BOJ_1167
    {
        static Dictionary<int, int>[] nodeDict = new Dictionary<int, int>[100005];
        static bool[] vis;
        static int max , maxdis = 0 , root = 0;
        static List<int> returnList;
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            for (int i = 0; i < v; i++)
            {
                string[] nodeinfo = Console.ReadLine().Split(' ');
                int par = int.Parse(nodeinfo[0]);
                if (nodeDict[par] == null)
                    nodeDict[par] = new Dictionary<int, int>();

                int child = 0;
                for (int j = 1; j < nodeinfo.Length; j++)
                {
                    if (j % 2 == 1 && nodeinfo[j] == "-1")
                        break ;
                    if (j % 2 == 1)
                    {
                        int n1 = int.Parse(nodeinfo[j]);
                        if (nodeDict[n1] == null)
                            nodeDict[n1] = new Dictionary<int, int>();
                        child = n1;
                    }
                    else if(j % 2 == 0)
                    {
                        nodeDict[par][child] = int.Parse(nodeinfo[j]);
                        nodeDict[child][par] = int.Parse(nodeinfo[j]);
                    }
                }
            }

            int ans = 0;

            vis = new bool[100005];
            vis[1] = true;
            returnList = new List<int>();
            dfs(1, 0);

            vis = new bool[100005];
            vis[root] = true;
            returnList = new List<int>();
            dfs(root , 0);
            max = returnList.Max();
            ans = Math.Max(ans, max);
            
            Console.WriteLine(ans);
        }
        static void dfs(int node , int length)
        {
            if (maxdis < length)
            {
                root = node;
                maxdis = length;
            }
            foreach (var one in nodeDict[node])
            {
                if (vis[one.Key])
                    continue;
                vis[one.Key] = true;
                int sum = length;
                sum += one.Value;
                if (nodeDict[one.Key].Count == 1)
                    returnList.Add(sum);
                dfs(one.Key, sum);
            }
        }
    }
    
}
