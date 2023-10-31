using System;
using System.Collections.Generic;
namespace BFS_DFS_Reculsive
{
    class Color_Blindness
    {
        static string[,] board = new string[101, 101];
        static bool[,] vis = new bool[101, 101];

        static int[] dx = { 1, 0, -1, 0 };
        static int[] dy = { 0, 1, 0, -1 };

        static int n;
        
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string InputValue = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    board[i, j] = InputValue[j].ToString();
                }
            }
                

            int notBlindness = BFSTest(n);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (board[i, j] == "G")
                        board[i, j] = "R";
                    vis[i, j] = false;
                }
            }
            int colorBlindness = BFSTest(n);

            Console.WriteLine($"{notBlindness} {colorBlindness}");
        }
        public static int BFSTest(int _n)
        {
            int num = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (board[i, j] == null || vis[i, j])
                        continue;

                    num++;
                    vis[i, j] = true;

                    Queue<KeyValuePair<int, int>> Q =
                        new Queue<KeyValuePair<int, int>>();
                    Q.Enqueue(new KeyValuePair<int, int>(i, j));

                    while (Q.Count != 0)
                    {
                        KeyValuePair<int, int> cur = Q.Peek();
                        Q.Dequeue();

                        for (int k = 0; k < 4; k++)
                        {
                            int nx = cur.Key + dx[k];
                            int ny = cur.Value + dy[k];

                            if (nx < 0 || nx > _n || ny < 0 || ny > _n)
                                continue;
                            if (vis[nx, ny] || board[nx, ny] != board[cur.Key, cur.Value])
                                continue;
                            vis[nx, ny] = true;
                            Q.Enqueue(new KeyValuePair<int, int>(nx, ny));
                        }
                    }
                }
            }
            return num;
        }
        
    }
}
