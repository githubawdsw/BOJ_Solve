using System;
using System.Collections.Generic;
using System.Text;

namespace BFS_DFS_Reculsive
{
    
    class Iceberg_2573
    {
        static int[,] board = new int[303, 303];
        static int[,] subt = new int[303, 303];
        static bool[,] vis = new bool[303, 303];

        static int N, M;

        static int[] dx = { 1, 0, -1, 0 };
        static int[] dy = { 0, 1, 0, -1 };
        static Queue<KeyValuePair<int, int>> Q = new Queue<KeyValuePair<int, int>>();

        static int year = 0;

        static void Main(string[] args)
        {
            string[] inputRowCol = Console.ReadLine().Split(" ");
            N = int.Parse(inputRowCol[0]);
            M = int.Parse(inputRowCol[1]);

            for (int i = 0; i < N; i++)
            {
                string[] inputValue = Console.ReadLine().Split(" ");
                for (int j = 0; j < M; j++)
                {
                    board[i, j] = int.Parse(inputValue[j]);
                }
            }
            
            BFS();

        }
        public static int area()
        {
            int count = 0;
            for (int i = 1; i < N - 1; i++)
            {
                for (int j = 1; j < M - 1; j++)
                {
                    if (vis[i, j] || board[i, j] <= 0)
                        continue;
                    Q.Clear();
                    count++;

                    if (count > 1)
                        return count;

                    Q.Enqueue(new KeyValuePair<int, int>(i, j));
                    vis[i, j] = true;

                    while (Q.Count != 0)
                    {
                        KeyValuePair<int, int> cur = Q.Peek();
                        Q.Dequeue();
                        for (int k = 0; k < 4; k++)
                        {
                            int nx = cur.Key + dx[k];
                            int ny = cur.Value + dy[k];

                            if (nx < 1 || ny < 1 || nx >= N - 1 || ny >= M - 1)
                                continue;
                            if (board[nx, ny] <= 0 || vis[nx,ny])
                                continue;
                            vis[nx, ny] = true;
                            Q.Enqueue(new KeyValuePair<int, int>(nx, ny));
                        }
                    }
                }
            }
            return count;
        }

        public static void BFS()
        {
            int num = 0;
            while (num < N*M)
            {
                int areacount = area();

                if (num == (N-2)*(M-2))
                {
                    Console.WriteLine(0);
                    return;
                }

                else if(areacount > 1 && num != 0 )
                {
                    Console.WriteLine(year);
                    return;
                }

                for (int i = 1; i < N - 1; i++)
                {
                    for (int j = 1; j < M - 1; j++)
                    {
                        int zerocount = 0;
                        if (board[i, j] <= 0)
                            continue;

                        Q.Enqueue(new KeyValuePair<int, int>(i, j));

                        KeyValuePair<int, int> cur = Q.Peek();
                        Q.Dequeue();
                        for (int k = 0; k < 4; k++)
                        {
                            int nx = cur.Key + dx[k];
                            int ny = cur.Value + dy[k];

                            if (board[nx, ny] > 0)
                                continue;
                            zerocount++;
                        }
                        subt[cur.Key, cur.Value] = zerocount;
                    }
                }
                for (int i = 1; i < N-1; i++)
                {
                    for (int j = 1; j < M-1; j++)
                    {
                        board[i, j] = board[i,j] - subt[i, j];
                        vis[i, j] = false;
                    }
                }
                year++;
                num++;
            }
        }
    }
}
