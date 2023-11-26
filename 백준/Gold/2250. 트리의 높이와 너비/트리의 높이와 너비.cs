using System;
using System.Collections.Generic;
using System.Linq;
namespace Tree
{
    
    class BOJ_2250
    {
        static  List<int>[] nodeList = new List<int>[10005];
        static List<Tuple<int,int>> levelArr = new List<Tuple<int, int>>();
        static int columm = 1;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool[] isNotRoot = new bool[10005];
            for (int i = 0; i < n; i++)
            {
                string[] nodearr = Console.ReadLine().Split(' ');
                int par = int.Parse(nodearr[0]);
                int left = int.Parse(nodearr[1]);
                int right = int.Parse(nodearr[2]);
                if (nodeList[par] == null)
                    nodeList[par] = new List<int>();
                nodeList[par].Add(left);
                nodeList[par].Add(right);
                if (left != -1)
                    isNotRoot[left] = true;
                if (right != -1)
                    isNotRoot[right] = true;
            }
            int root = 1;
            for (int i = 1; i <= n; i++)
                if (!isNotRoot[i])
                    root = i;

            dfs(root, 1);

            levelArr = levelArr.OrderBy(x => x.Item1).ToList();
            int ans = 0;
            int level = levelArr[root - 1].Item1;
            int width = 0;
            for (int i = 1; i < levelArr.Count; i++)
            {
                if (levelArr[i].Item1 == levelArr[i - 1].Item1)
                    width += levelArr[i].Item2 - levelArr[i - 1].Item2;
                else
                    width = 0;
                if (ans < width)
                    level = levelArr[i].Item1;
                ans = Math.Max(ans, width);
            }
            Console.WriteLine($"{level} {ans + 1}");
        }
        static void dfs(int node, int level)
        {
            if( nodeList[node][0] != -1)
                dfs(nodeList[node][0], level + 1);
            levelArr.Add(new Tuple<int, int>(level, columm++));
            if (nodeList[node][1] != -1)
                dfs(nodeList[node][1], level + 1);
        }
    }
    
}
