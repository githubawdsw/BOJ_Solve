using System;
using System.Collections.Generic;
namespace BFS_DFS_Reculsive
{
    class Program
    {
        static string[,] board = new string[502, 502];
        static bool[,] vis = new bool[502, 502];

        static int[] dx = { 1, 0, -1, 0 };
        static int[] dy = { 0, 1, 0, -1 };

        static int n, m;
        static void Main(string[] args)
        {
            string[] inputAmount = Console.ReadLine().Split(" ");
            n = int.Parse(inputAmount[0]);
            m = int.Parse(inputAmount[1]);

            for (int i = 0; i < n; i++)
            {
                string[] inputValString = Console.ReadLine().Split(" ");
                for (int j = 0; j < m; j++)
                {
                    board[i, j] = inputValString[j];
                }
            }
            
            BFSTest(n, m);
        }
        public static void BFSTest(int _n , int _m)
        {
            int num = 0;
            int mx = 0;
            for (int k = 0; k < n; k++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (board[k, j] == "0" || vis[k, j])
                        continue;
                    num++;
                    Queue<KeyValuePair<int, int>> Q =
                        new Queue<KeyValuePair<int, int>>();

                    vis[k, j] = true;
                    Q.Enqueue(new KeyValuePair<int, int>(k, j));

                    int area = 0;
                    while (Q.Count != 0)
                    {
                        area++;
                        KeyValuePair<int, int> cur = Q.Peek();
                        Q.Dequeue();
                        for (int i = 0; i < 4; i++)
                        {
                            int nx = cur.Key + dx[i];
                            int ny = cur.Value + dy[i];
                            if (nx < 0 || nx >= _n || ny < 0 || ny >= _m)
                                continue;
                            if (vis[nx, ny] || board[nx, ny] !=  "1")
                                continue;
                            vis[nx, ny] = true;
                            Q.Enqueue(new KeyValuePair<int, int>(nx, ny));
                        }
                    }
                    mx = Math.Max(mx, area);
                }
            }
            Console.WriteLine( $"{num}\n{mx}");

        }
    }
}
