using System;
using System.Collections.Generic;

namespace Graph
{
    
    class BOJ_2617
    {
        static List<int>[] heavy = new List<int>[101];
        static List<int>[] light = new List<int>[101];
        static bool[] vis;
        static int n;
        static void Main(string[] args)
        {
            string[] inputnm = Console.ReadLine().Split(' ');
            n = int.Parse(inputnm[0]);
            int m = int.Parse(inputnm[1]);
            while (m-- > 0)
            {
                string[] trust = Console.ReadLine().Split(' ');
                int mheavy = int.Parse(trust[0]);
                int mlight = int.Parse(trust[1]);

                if (heavy[mheavy] == null)
                    heavy[mheavy] = new List<int>();
                if (light[mlight] == null)
                    light[mlight] = new List<int>();

                heavy[mheavy].Add(mlight);
                light[mlight].Add(mheavy);
            }

            int ans = 0;
            for (int i = 1; i <= n; i++)
            {
                bool h = false; bool l = false ;
                if(heavy[i] != null)
                    h = bfs(i , heavy);
                if(light[i] != null)
                    l = bfs(i , light);
                if (h || l)
                    ans++;
            }
            Console.WriteLine(ans);
        }
        static bool bfs(int node , List<int>[] arrlist)
        {
            vis = new bool[101];
            vis[node] = true;
            int count = 0;

            Queue<int> q = new Queue<int>();
            q.Enqueue(node);
            while (q.Count != 0)
            {
                int cur = q.Dequeue();
                if (arrlist[cur] == null)
                    continue;
                foreach (var one in arrlist[cur])
                {
                    if (vis[one])
                        continue;
                    q.Enqueue(one);
                    vis[one] = true;
                    count++;
                }
            }
            return count >= (n + 1) / 2;
            
        }
    }
    
}
