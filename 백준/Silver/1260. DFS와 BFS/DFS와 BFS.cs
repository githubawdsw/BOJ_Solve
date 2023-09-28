using System;
using System.Collections.Generic;
using System.Text;
namespace Graph
{
    
    class BOJ_1260
    {
        static List<int>[] arrList = new List<int>[1005];
        static bool[] visbfs = new bool[1005];
        static bool[] visdfs = new bool[1005];
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            string[] inputnmv = Console.ReadLine().Split(' ');
            int n = int.Parse(inputnmv[0]);
            int m = int.Parse(inputnmv[1]);
            int v = int.Parse(inputnmv[2]);

            while (m > 0)
            {
                m--;
                int p1, p2;
                string[] inputuv = Console.ReadLine().Split(' ');
                p1 = int.Parse(inputuv[0]);
                p2 = int.Parse(inputuv[1]);

                if (arrList[p1] == null)
                    arrList[p1] = new List<int>();
                if (arrList[p2] == null)
                    arrList[p2] = new List<int>();

                arrList[p1].Add(p2);
                arrList[p2].Add(p1);
            }

            for (int i = 1; i <= n; i++)
            {
                if (arrList[i] == null)
                    continue;
                arrList[i].Sort();
            }

            if( arrList[v] == null)
            {
                Console.WriteLine( v );
                Console.WriteLine(v);
                return;
            }


            sb.Append($"{v} ");
            // 재귀dfs
            visdfs[v] = true;
            dfs(v);
            Console.WriteLine(sb);

            // bfs
            sb.Clear();
            sb.Append($"{v} ");
            Queue<int> q = new Queue<int>();
            q.Enqueue(v);
            visbfs[v] = true;
            while (q.Count != 0)
            {
                int cur = q.Dequeue();
                foreach (var one in arrList[cur])
                {
                    if (visbfs[one])
                        continue;
                    visbfs[one] = true;
                    sb.Append($"{one} ");
                    q.Enqueue(one);
                }
            }
            Console.WriteLine(sb);
        }

        static void dfs(int k)
        {
            foreach (var one in arrList[k])
            {
                if (visdfs[one])
                    continue;
                sb.Append($"{one} ");
                visdfs[one] = true;
                dfs(one);
            }
        }
    }

}
