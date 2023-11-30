using System;
using System.Collections.Generic;
namespace BFS_DFS_Reculsive
{

    class BreakTheWall2_16933
    {
        static string[,] board = new string[1001, 1001];
        static int[,,] distan = new int[1001, 1001,11];

        static int[] dx = { 0, 1, 0, -1 };
        static int[] dy = { 1, 0, -1, 0 };
        static int n, m, k;

        static Queue<Tuple<int, int, int, int>> Q =
                new Queue<Tuple<int, int, int, int>>();

        static void Main(string[] args)
        {
            string[] inputAmount = Console.ReadLine().Split(" ");
            n = int.Parse(inputAmount[0]);
            m = int.Parse(inputAmount[1]);
            k = int.Parse(inputAmount[2]);

            for (int i = 0; i < n; i++)
            {
                string inputValue = Console.ReadLine();
                for (int j = 0; j < m; j++)
                {
                    board[i, j] = inputValue[j].ToString();
                }
            }
            
            distan[0, 0, 0] = 1;

            Q.Enqueue(new Tuple<int, int, int, int>(0, 0, 0, 0));
            BFSTest();

        }

        public static void BFSTest()
        {
            while (Q.Count != 0)
            {
                Tuple<int, int, int, int> cur = Q.Dequeue();
                if (distan[n-1,m-1,cur.Item3] != 0)
                {
                    Console.WriteLine(distan[n - 1, m - 1, cur.Item3]);
                    return;
                }
                for (int i = 0; i < 4;  i++)
                {
                    int nx = cur.Item1 + dx[i];
                    int ny = cur.Item2 + dy[i];
                    if (nx < 0 || ny < 0 || nx >= n || ny >= m)
                        continue;

                    if (cur.Item4 == 0)
                    {
                        if (board[nx, ny] == "1"&& cur.Item3 < k && distan[nx, ny, cur.Item3 + 1] == 0 )
                        {
                            distan[nx, ny, cur.Item3 + 1] = distan[cur.Item1, cur.Item2, cur.Item3] + 1;
                            Q.Enqueue(new Tuple<int, int, int, int>(nx, ny, cur.Item3 + 1, cur.Item4 + 1 ));
                        }
                        if (board[nx, ny] == "0" && distan[nx, ny, cur.Item3] == 0)
                        {
                            distan[nx, ny, cur.Item3] = distan[cur.Item1, cur.Item2, cur.Item3] + 1;
                            Q.Enqueue(new Tuple<int, int, int, int>(nx, ny, cur.Item3, cur.Item4 + 1 ));
                        }
                    }
                    else
                    {
                        if (board[nx, ny] == "0" && distan[nx, ny, cur.Item3] == 0)
                        {
                            distan[nx, ny, cur.Item3] = distan[cur.Item1, cur.Item2, cur.Item3] + 1;
                            Q.Enqueue(new Tuple<int, int, int, int>(nx, ny, cur.Item3, cur.Item4 - 1));
                        }
                    }
                        
                }
                if (cur.Item3 < k && cur.Item4 == 1)
                {
                    distan[cur.Item1, cur.Item2, cur.Item3] += 1;
                    Q.Enqueue(new Tuple<int, int, int, int>(cur.Item1, cur.Item2, cur.Item3, cur.Item4 - 1));
                }
            }
            Console.WriteLine(-1);
        }
        
    }
}
