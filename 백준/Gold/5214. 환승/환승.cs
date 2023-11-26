using System;
using System.Collections.Generic;

namespace Graph
{
    
    class BOJ_5214
    {
        static List<int>[] station = new List<int>[101005];
        static int[] dis = new int[101005];
        static int n;
        static void Main(string[] args)
        {
            string[] inputnkm = Console.ReadLine().Split(' ');
            n = int.Parse(inputnkm[0]);
            int k = int.Parse(inputnkm[1]);
            int m = int.Parse(inputnkm[2]);

            for (int i = 1; i <= n + m; i++)
                station[i] = new List<int>();

            for (int i = 1; i <= m; i++)
            {
                string[] inputK = Console.ReadLine().Split(' ');
                for (int j = 0; j < k; j++)
                {
                    station[n + i].Add(int.Parse(inputK[j]));
                    station[int.Parse(inputK[j])].Add(n + i);
                }
            }


            Queue<int> q = new Queue<int>();
            q.Enqueue(1);
            dis[1] = 1;
            while (q.Count != 0)
            {
                int cur = q.Dequeue();
                if (cur == n)
                    break;
                foreach (var one in station[cur])
                {
                    if (dis[one] > 0)
                        continue;
                    dis[one] = dis[cur] + 1;
                    q.Enqueue(one);
                }
            }
            if(dis[n]  == 0)
                Console.WriteLine(-1);
            else
                Console.WriteLine(dis[n] / 2 +1);
        }
    }
    
}
