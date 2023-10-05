using System;
using System.Collections.Generic;

namespace Graph
{

    class BOJ_11724
    {
        static void Main(string[] args)
        {
            string[] inputnm = Console.ReadLine().Split(' ');
            int n = int.Parse(inputnm[0]);
            int m = int.Parse(inputnm[1]);
            List<int>[] arrList = new List<int>[1005];
            bool[] vis = new bool[1005];

            while (m > 0)
            {
                m--;
                int u, v;
                string[] inputuv = Console.ReadLine().Split(' ');
                u = int.Parse(inputuv[0]);
                v = int.Parse(inputuv[1]);

                if (arrList[u] == null)
                    arrList[u] = new List<int>();
                if (arrList[v] == null)
                    arrList[v] = new List<int>();

                arrList[u].Add(v);
                arrList[v].Add(u);
            }
           
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (vis[i])
                    continue;
                if(arrList[i] == null)
                {
                    count++;
                    continue;
                }
                vis[i] = true;
                Queue<int> q = new Queue<int>();
                q.Enqueue(i);
                while (q.Count != 0)
                {
                    int cur = q.Dequeue();
                    foreach(var one in arrList[cur])
                    {
                        if (vis[one])
                            continue;
                        q.Enqueue(one);
                        vis[one] = true;
                    }
                }
                count++;
            }
            Console.WriteLine(count);
        }
    }

}
