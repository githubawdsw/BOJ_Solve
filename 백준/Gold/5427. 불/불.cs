using System;
using System.Collections.Generic;
namespace BFS_DFS_Reculsive
{
    class Fire2_5427
    {
        static string[,] board = new string[1001, 1001];
        static int[,] distanC = new int[1001, 1001];
        static int[,] distanF = new int[1001, 1001];

        static int[] dx = { 1, 0, -1, 0 };
        static int[] dy = { 0, 1, 0, -1 };

        static string n, m, l;

        static void Main(string[] args)
        {
            n = Console.ReadLine();

            string[] ans = new string[int.Parse(n)];
            Queue<KeyValuePair<int, int>> F =
                new Queue<KeyValuePair<int, int>>();

            Queue<KeyValuePair<int, int>> C =
                new Queue<KeyValuePair<int, int>>();

            for (int i = 0; i < int.Parse(n); i++)
            {
                string[] InputCoordinate = Console.ReadLine().Split(" ");
                m = InputCoordinate[1];
                l = InputCoordinate[0];

                F.Clear();
                C.Clear();
                for (int j = 0; j < int.Parse(m); j++)
                    for (int k = 0; k < int.Parse(l); k++)
                    {
                        distanC[j, k] = 0;
                        distanF[j, k] = 0;
                    }
                for (int j = 0; j < int.Parse(m); j++)
                {
                    string Inputstr = Console.ReadLine();
                    for (int k = 0; k < int.Parse(l); k++)
                    {
                        board[j, k] = Inputstr[k].ToString();
                        if (board[j, k] == "*")
                        {
                            distanF[j, k] = 1;
                            F.Enqueue(new KeyValuePair<int, int>(j, k));
                        }
                        if (board[j, k] == "@")
                        {
                            distanC[j, k] = 1;
                            C.Enqueue(new KeyValuePair<int, int>(j, k));
                        }
                    }
                }

                ans[i] = BFSTest(F, C);
            }

            foreach (string one in ans)
            {
                Console.WriteLine(one);
            }


        }
        public static string BFSTest(
            Queue<KeyValuePair<int, int>> _f, Queue<KeyValuePair<int, int>> _c)
        {
            while (_f.Count != 0)
            {
                KeyValuePair<int, int> cur = _f.Peek();
                _f.Dequeue();
                for (int i = 0; i < 4; i++)
                {
                    int nx = cur.Key + dx[i];
                    int ny = cur.Value + dy[i];
                    if (nx < 0 || ny < 0 || nx >= int.Parse(m) || ny >= int.Parse(l))
                        continue;
                    if (board[nx, ny] == "#" || board[nx, ny] == null || distanF[nx, ny] >= 1)
                        continue;
                    distanF[nx, ny] = distanF[cur.Key, cur.Value] + 1;
                    _f.Enqueue(new KeyValuePair<int, int>(nx, ny));
                }
            }


            while (_c.Count != 0)
            {
                KeyValuePair<int, int> cur = _c.Peek();
                _c.Dequeue();
                for (int i = 0; i < 4; i++)
                {
                    int nx = cur.Key + dx[i];
                    int ny = cur.Value + dy[i];
                    if (nx < 0 || ny < 0 || nx >= int.Parse(m) || ny >= int.Parse(l))
                        return distanC[cur.Key, cur.Value].ToString();
                    if (board[nx, ny] == "#" || distanC[nx,ny] > 0 ||
                        (distanF[nx, ny] <= distanC[cur.Key, cur.Value] + 1) && distanF[nx, ny] != 0)
                        continue;
                    distanC[nx, ny] = distanC[cur.Key, cur.Value] + 1;

                    _c.Enqueue(new KeyValuePair<int, int>(nx, ny));
                }
            }
            return "IMPOSSIBLE";
        }

    }
}
