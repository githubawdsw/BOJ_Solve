using System;
using System.Collections.Generic;
using System.Linq;
namespace BFS_DFS_Reculsive
{
    
    class SafeZone_2468
    {
        static int N;
        static int[,] board = new int [1000, 1000];
        static bool[,] IsFlooding = new bool [1000,1000];
        static Queue<KeyValuePair<int, int>> Q = new Queue<KeyValuePair<int, int>>();
        static int[] dx = { 1, 0, -1, 0 };
        static int[] dy = { 0, 1, 0, -1 };


        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());
            int height = 1;
            int max = 0;
            for (int i = 0; i < N; i++)
            {
                string[] inputValue = Console.ReadLine().Split(" ");
                for (int j = 0; j < N; j++)
                {
                    board[i, j] = int.Parse(inputValue[j]);
                    max = (int)MathF.Max(max, board[i, j]);
                }
            }
            BFS(height, max);

        }
        public static void BFS(int _h, int max)
        {
            int area = 1;
            int num;
            for (int p = 0; p < max; p++ )
            {
                num = 0;
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                        IsFlooding[i, j] = false;
                }
                for (int j = 0; j < N; j++)
                {
                    for (int k = 0; k < N; k++)
                    {
                        if (board[j, k] <= _h || IsFlooding[j,k])
                            continue;

                        IsFlooding[j,k] = true;
                        Q.Enqueue(new KeyValuePair<int, int>(j, k));
                        num++;

                        while (Q.Count != 0)
                        {
                            KeyValuePair<int, int> cur = Q.Peek();
                            Q.Dequeue();

                            for (int i = 0; i < 4; i++)
                            {
                                int nx = dx[i] + cur.Key;
                                int ny = dy[i] + cur.Value;
                                if (nx < 0 || ny < 0 || nx > N || ny > N)
                                    continue;
                                if (!IsFlooding[nx, ny] && board[nx, ny] > _h)
                                {
                                    IsFlooding[nx, ny] = true;
                                    Q.Enqueue(new KeyValuePair<int, int>(nx, ny));
                                }
                                    
                            }
                        }
                    }

                }
                area = (int)MathF.Max(area, num);
                _h++;
            }
            Console.WriteLine(area);
        }
        
    }
}
