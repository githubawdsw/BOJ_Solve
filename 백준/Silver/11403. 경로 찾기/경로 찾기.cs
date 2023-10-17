using System;
using System.Collections.Generic;
using System.Text;
namespace Graph
{
    
    class BOJ_11403 
    {
        static List<int>[] arrList = new List<int>[105];
        static bool[] vis;
        static int[,] board = new int[105, 105];
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string[] inputarr = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                    if(inputarr[j] == "1")
                    {
                        if (arrList[i] == null)
                            arrList[i] = new List<int>();
                        arrList[i].Add(j + 1);
                    }
            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    vis = new bool[105];
                    if (arrList[i] == null)
                        continue;
                    if (dfs(i, j))
                        board[i, j] = 1;
                }
            }
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                    sb.Append($"{board[i,j]} ");
                sb.AppendLine();
            }
            Console.WriteLine(sb);
        }
        static bool dfs(int node , int end )
        {
            vis[node] = true;
            if (arrList[node] == null && node != end)
                return false;
            else if (arrList[node] == null && node == end)
                return true;
            for (int i = 0; i < arrList[node].Count; i++)
            {
                if (arrList[node][i] == end)
                    return true;
                if (vis[arrList[node][i]])
                    continue;
                if (dfs(arrList[node][i], end))
                    return true;
            }
            return false;
        }
    }
    
}
