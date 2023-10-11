using System;
using System.Collections.Generic;
namespace BFS_DFS_Reculsive
{
    class HideAndSeek
    {
        static int[] distan = new int[200000];

        static int[] dx = { 1,  -1 , 2};

        static int n, m;

        static void Main(string[] args)
        {
            string[] inputAmount = Console.ReadLine().Split(" ");
            n = int.Parse(inputAmount[0]);
            m = int.Parse(inputAmount[1]);

            BFSTest(n, m);
        }
        public static void BFSTest(int _n , int _m)
        {
            Queue<int> Q = new Queue<int>();
            distan[n] = 1;
            Q.Enqueue(n);

            while (distan[m] == 0)
            {
                int cur = 0;
                if (Q.Count != 0)
                {
                    cur = Q.Peek();
                    Q.Dequeue();
                }

                for (int i = 0; i < 3; i++)
                {
                    if (i != 2)
                    {
                        int nx = cur + dx[i];
                        if (nx < 0 || nx > 100000)
                            continue;
                        if (distan[nx] != 0)
                            continue;
                        distan[nx] = distan[cur] + 1;
                        Q.Enqueue(nx);
                    }
                    else
                    {
                        int nx = cur * 2;
                        if (nx < 0 || nx > 100000)
                            continue;
                        if (distan[nx] != 0)
                            continue;
                        distan[nx] = distan[cur] + 1;
                        Q.Enqueue(nx);
                    }
                }
            }

            Console.WriteLine(distan[m]-1);

        }
    }
}
