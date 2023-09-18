using System;
using System.Collections.Generic;
using System.Text;
namespace Graph
{
    
    class BOJ_2606
    {
        static List<int>[] arrList = new List<int>[105];
        static bool[] vis = new bool[105];
        static void Main(string[] args)
        {
            int vertex = int.Parse(Console.ReadLine());
            int branch = int.Parse(Console.ReadLine());
            for (int i = 0; i < branch; i++)
            {
                string[] inputarr = Console.ReadLine().Split(' ');
                int first = int.Parse(inputarr[0]);
                int second = int.Parse(inputarr[1]);
                if (arrList[first] == null)
                    arrList[first] = new List<int>();
                if (arrList[second] == null)
                    arrList[second] = new List<int>();
                arrList[first].Add(second);
                arrList[second].Add(first);
            }
            if(arrList[1] == null)
            {
                Console.WriteLine(0);
                return;
            }
            
            dfs( 1 );

            int ans = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (vis[i])
                    ans++;
            }
            Console.WriteLine(ans);
        }
        static void dfs(int node)
        {
            if(node != 1)
                vis[node] = true;
            for (int i = 0; i < arrList[node].Count; i++)
            {
                if (vis[arrList[node][i]] || arrList[node][i] == 1)
                    continue;
                dfs(arrList[node][i]);
            }
        }
    }
    
}
