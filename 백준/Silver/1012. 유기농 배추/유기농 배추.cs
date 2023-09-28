using System;
using System.Collections.Generic;
namespace BFS_DFS_Reculsive
{
    class Cabbage
    {
        static string[,] board = new string[51, 51];
        static bool[,] vis = new bool[51, 51];

        static int[] dx = { 1, 0, -1, 0 };
        static int[] dy = { 0, 1, 0, -1 };

        static int t, n,m,k;


        static Queue<KeyValuePair<int, int>> Q =
            new Queue<KeyValuePair<int, int>>();
        static void Main(string[] args)
        {
            t = int.Parse(Console.ReadLine());

            int[] ans = new int[t];

            for (int T = 0; T < t; T++)
            {

                string[] inputValstr = Console.ReadLine().Split(" ");
                n = int.Parse(inputValstr[0]);
                m = int.Parse(inputValstr[1]);
                k = int.Parse(inputValstr[2]);

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        board[i, j] = "0";
                        vis[i, j] = false;
                    }
                }
                for (int i = 0; i < k; i++)
                {
                    string[] inputValue = Console.ReadLine().Split(" ");
                    board[int.Parse(inputValue[0]), int.Parse(inputValue[1])] = "1";
                }
                

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (board[i, j] == "1" && !vis[i, j])
                        {
                            Q.Enqueue(new KeyValuePair<int, int>(i, j));
                            BFSTest();
                            ans[T]++;
                        }
                    }
                }

            }
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine(ans[i]);
            }


        }
        public static void BFSTest()
        {
            while (Q.Count != 0)
            {
                KeyValuePair<int, int> cur = Q.Peek();
                Q.Dequeue();

                for (int i = 0; i < 4; i++)
                {
                    int nx = cur.Key + dx[i];
                    int ny = cur.Value + dy[i];

                    if (nx < 0 || ny < 0 || nx > n || ny > m)
                        continue;
                    if (vis[nx, ny] || board[nx,ny] == "0" || board[nx,ny] == null)
                        continue;

                    vis[nx, ny] = true;
                    Q.Enqueue(new KeyValuePair<int, int>(nx, ny));
                }
            } 

        }
        
    }
}
