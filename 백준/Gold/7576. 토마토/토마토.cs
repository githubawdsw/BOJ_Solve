using System;
using System.Collections.Generic;
namespace BFS_DFS_Reculsive
{
    class Tomato
    {
        static string[,] board = new string[1000, 1000];
        static int[,] distan = new int[1000, 1000];

        static int[] dx = { 1, 0, -1, 0 };
        static int[] dy = { 0, 1, 0, -1 };

        static int n, m;
        static void Main(string[] args)
        {
            string[] inputAmount = Console.ReadLine().Split(" ");
            n = int.Parse(inputAmount[1]);
            m = int.Parse(inputAmount[0]);

            
            
            BFSTest(n, m);
        }
        public static void BFSTest(int _n , int _m)
        {

            Queue<KeyValuePair<int, int>> Q =
                new Queue<KeyValuePair<int, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] inputValString = Console.ReadLine().Split(" ");
                for (int j = 0; j < m; j++)
                {
                    board[i, j] = inputValString[j];

                    if (board[i, j] == "1")
                    {
                        Q.Enqueue(new KeyValuePair<int, int>(i, j));
                    }
                    if (board[i, j] == "0")
                    {
                        distan[i, j] = -1;
                    }
                }
            }

            while (Q.Count != 0)
            {
                KeyValuePair<int, int> cur = Q.Peek();
                Q.Dequeue();

                for (int i = 0; i < 4; i++)
                {
                    int nx = cur.Key + dx[i];
                    int ny = cur.Value + dy[i];
                    if (nx < 0 || nx >= _n || ny < 0 || ny >= _m)
                        continue;
                    if (distan[nx, ny] >= 0 )
                        continue;
                    distan[nx, ny] = distan[cur.Key, cur.Value] + 1;
                    Q.Enqueue(new KeyValuePair<int, int>(nx, ny));
                }
            }

            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {

                    
                    if (distan[i, j] == -1)
                    {
                        Console.WriteLine(-1);
                        return;
                    }
                    ans = Math.Max(ans, distan[i, j]);

                }
                
            }
            Console.WriteLine(ans);

        }
    }
}
