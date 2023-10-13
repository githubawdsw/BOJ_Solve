using System;
using System.Collections.Generic;
namespace BFS_DFS_Reculsive
{
    class Distance_Measuer
    {
        static string[,] board = new string[502, 502];
        static int[,] distan = new int[502, 502];

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
                string inputValString = Console.ReadLine();
                for (int j = 0; j < m; j++)
                {
                    board[i, j] = inputValString[j].ToString();
                    distan[i, j] = -1;
                }
            }
            
            
            BFSTest(n, m);
        }
        public static void BFSTest(int _n , int _m)
        {

            Queue<KeyValuePair<int, int>> Q =
                new Queue<KeyValuePair<int, int>>();


            Q.Enqueue(new KeyValuePair<int, int>(0, 0));

            distan[0, 0] = 0;
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
                    if (distan[nx, ny] >= 0 || board[nx, ny] != "1")
                        continue;
                    distan[nx, ny] = distan[cur.Key, cur.Value] + 1;
                    Q.Enqueue(new KeyValuePair<int, int>(nx, ny));
                }
            }

            Console.WriteLine(distan[n-1,m-1]+1);

        }
    }
}
