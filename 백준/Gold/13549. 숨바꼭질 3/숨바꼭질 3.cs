using System;
using System.Collections.Generic;
namespace BFS_DFS_Reculsive
{
    
    class HideAndSeek3_13549
    {
        static int[] board = new int[100002];
        static int[] seek = { -1, 1};

        static int n, k;
        static Queue<int> Q = new Queue<int>();

        static void Main(string[] args)
        {
            string[] inputAmount = Console.ReadLine().Split(" ");
            n = int.Parse(inputAmount[0]);
            k = int.Parse(inputAmount[1]);

            Q.Enqueue(n);
            board[n] = 1;

            BFSTest(n, k);
        }
        public static void BFSTest(int _n , int _k)
        {
            int cur = 0;
            while (board[k] == 0)
            {
                if(Q.Count != 0)
                {
                    cur = Q.Peek();
                    Q.Dequeue();
                }
                if (2 * cur < 100001 && board[2 * cur] == 0)
                {
                    Q.Enqueue(2 * cur);
                    board[2 * cur] = board[cur];
                }

                for (int i = 0; i < 2; i++)
                {
                    
                    int nx = cur + seek[i];
                    if (nx < 0 || nx > 100001)
                        continue;
                    if (board[nx] != 0)
                        continue;
                    board[nx] = board[cur] + 1;
                    Q.Enqueue(nx);
                    

                }
            }
            Console.WriteLine(board[k] - 1);

        }
    }
    
}
