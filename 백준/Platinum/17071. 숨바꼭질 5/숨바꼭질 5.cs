using System;
using System.Collections.Generic;
using System.Text;
namespace BFS_DFS_Reculsive
{
    
    class HideAndSeek5_17071
    {
        static int[] board = new int[500003];
        static int[,] vis = new int[2, 500003];
        static int[] seek = { 2, 1, -1 };
        static int n, k;
        static int count = 0;

        static void Main(string[] args)
        {
            string[] inputAmount = Console.ReadLine().Split(" ");
            n = int.Parse(inputAmount[0]);
            k = int.Parse(inputAmount[1]);

            if (n == k)
            {
                Console.WriteLine(0);
                return;
            }
            BFSTest();
           
            bool found = false;
            while (k <= 500000)
            {
                if(vis[count % 2, k] <= count)
                {
                    found = true;
                    break;
                }
                k += ++count;
            }
            
            if (found)
                Console.WriteLine(count);
            else
                Console.WriteLine(-1);
        }


        public static void BFSTest()
        {
            Queue<Tuple< int,int>> Q = new Queue<Tuple<int, int>>();
            Q.Enqueue(new Tuple<int, int>( n , 0));

            
            vis[0, n] = 1;
            while (Q.Count != 0)
            {
                Tuple<int, int > cur;
                cur = Q.Dequeue();

                int nvt = cur.Item2 + 1;
                for (int i = 0; i < 3; i++)
                {
                    int nx = 0;
                    if (i != 0) 
                        nx = cur.Item1 + seek[i];
                    else
                        nx = cur.Item1 * seek[i];

                    if (nx < 0 || nx > 500000)
                        continue;
                    if (vis[nvt % 2, nx] != 0)
                        continue;
                    vis[nvt % 2, nx] = nvt;
                    Q.Enqueue(new Tuple<int, int>( nx, nvt));
                }


            }
        }
    }
    
}
