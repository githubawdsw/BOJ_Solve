using System;
using System.Collections.Generic;
using System.Text;
namespace BFS_DFS_Reculsive
{
    
    class HideAndSeek4_13913
    {
        static int[] board = new int[100003];
        static int[] beforePos = new int[100003];
        static int[] seek = { 1, -1 , 2};

        static int n, k;
        static StringBuilder sb = new StringBuilder();

        static void Main(string[] args)
        {
            string[] inputAmount = Console.ReadLine().Split(" ");
            n = int.Parse(inputAmount[0]);
            k = int.Parse(inputAmount[1]);

            board[n] = 1;
            beforePos[n] = n;

            if (n < k)
            {
                BFSTest();

                Stack<int> pos = new Stack<int>();
                pos.Push(k);
                while (pos.Peek() != n)
                {
                    pos.Push(beforePos[pos.Peek()]);
                }

                int count = pos.Count;
                for (int i = 0; i < count; i++)
                {
                    sb.Append(pos.Pop());
                    sb.Append(" ");
                }
            }
            else
            {
                board[k] = n - k + 1;
                while (n != k)
                {
                    sb.Append(n);
                    sb.Append(" ");
                    n--;
                }
                sb.Append(n);
                sb.Append(" ");
            }

            Console.WriteLine(board[k] - 1);
            Console.WriteLine(sb);

        }
        public static void BFSTest()
        {
            Queue<int> Q = new Queue<int>();
            Q.Enqueue(n);
            while (board[k] == 0)
            {
                int cur = 0;

                if (Q.Count != 0)
                    cur = Q.Dequeue();
                
                for (int i = 0; i < 3; i++)
                {
                    int nx;
                    if (i != 2)
                        nx = cur + seek[i];
                    else
                        nx = cur * seek[i];

                    if (nx < 0 || nx > 100000 || board[nx] != 0)
                        continue;

                    board[nx] = board[cur] + 1;
                    beforePos[nx] = cur;
                    Q.Enqueue(nx);
                }
            }
        }
    }
    
}
