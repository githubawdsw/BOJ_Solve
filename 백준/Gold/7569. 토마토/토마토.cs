using System;
using System.Collections.Generic;
namespace BFS_DFS_Reculsive
{
    class Tomato_7569
    {
        static string[,,] board = new string[101, 101 , 101];
        static int[,,] distan = new int[101, 101, 101];

        static int[] dx = { 1, -1, 0, 0, 0, 0 };
        static int[] dy = { 0, 0, 1, -1, 0, 0 };
        static int[] dz = { 0, 0, 0, 0, 1, -1 };
        static int n, m, h;

        static Queue<Tuple<int, int,int>> Q =
                new Queue<Tuple<int, int, int>>();

        static void Main(string[] args)
        {
            string[] inputAmount = Console.ReadLine().Split(" ");
            n = int.Parse(inputAmount[1]);
            m = int.Parse(inputAmount[0]);
            h = int.Parse(inputAmount[2]);

            for (int k = 0; k < h; k++)
            {
                for (int i = 0; i < n; i++)
                {
                    string[] InputValue = Console.ReadLine().Split(" ");
                    for (int j = 0; j < m; j++)
                    {
                        board[i, j, k] = InputValue[j];
                        if (board[i, j,k] == "1")
                        {
                            distan[i, j,k] = 1;
                            Q.Enqueue(new Tuple<int, int, int> (i, j, k));
                        }
                        if (board[i, j, k] == "-1")
                            distan[i, j, k] = -1;
                    }
                }
            }

            BFSTest();

            int ans = 0;
            ans = answer(ans);
            if (ans > 1)
                ans--;
            Console.WriteLine(ans);
        }
        static int answer(int _ans)
        {
            for (int k = 0; k < h; k++)
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < m; j++)
                    {
                        if (distan[i, j, k] == 0)
                        {
                            _ans = -1;
                            return _ans;
                        }
                        if (distan[i, j, k] > 1)
                            _ans = Math.Max(distan[i, j, k], _ans);
                    }
            return _ans;
        }

        public static void BFSTest()
        {
            while (Q.Count != 0)
            {
                Tuple<int, int, int> cur = Q.Peek();
                Q.Dequeue();

                for (int i = 0; i < 6; i++)
                {
                    int nx = cur.Item1 + dx[i];
                    int ny = cur.Item2 + dy[i];
                    int nz = cur.Item3 + dz[i];

                    if (nx < 0 || ny < 0 || nz < 0 || nx >= n || ny >= m || nz >= h)
                        continue;
                    if (distan[nx, ny, nz] > 0 || distan[nx, ny, nz] == -1)
                        continue;
                    distan[nx, ny, nz] = distan[cur.Item1, cur.Item2, cur.Item3] + 1;
                    Q.Enqueue(new Tuple<int, int, int>(nx, ny, nz));
                }
            }
        }
        
    }
}
