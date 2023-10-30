using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace BFS_DFS_Reculsive
{
    
    class BuildingExit_6593
    {
        static string[,,] board = new string[40, 40, 40];
        static int[,,] vis = new int[40, 40, 40];
        static int L = 1, R = 1, C = 1;

        static int[] dx = { 1, -1, 0, 0, 0, 0 };
        static int[] dy = { 0, 0, 1, -1, 0, 0 };
        static int[] dz = { 0, 0, 0, 0, 1, -1 };

        static Queue<Tuple<int, int, int>> Q = new Queue<Tuple<int, int, int>>();

        static StringBuilder sr = new StringBuilder();

        static void Main(string[] args)
        {
            while (L != 0 && R != 0 && C != 0)
            {
                string[] inputValue = Console.ReadLine().Split(" ");

                L = int.Parse(inputValue[0]);
                R = int.Parse(inputValue[1]);
                C = int.Parse(inputValue[2]);
                if (L == 0 && R == 0 && C == 0)
                    continue;
                if (sr.Length != 0)
                    sr.AppendLine();
                for (int i = 0; i < L; i++)
                {
                    for (int j = 0; j < R; j++)
                    {
                        string inputStr = Console.ReadLine();
                        for (int k = 0; k < C; k++)
                        {
                            board[i, j, k] = inputStr[k].ToString();
                            vis[i, j, k] = 0;
                            if (board[i, j, k] == "S")
                            {
                                Q.Enqueue(new Tuple<int, int, int>(i, j, k));
                                vis[i, j, k] = 1;
                            }
                        }
                    }
                    Console.ReadLine();
                }
                BFS();
            }
            Console.WriteLine(sr.ToString());

        }
        public static void BFS()
        {
            while (Q.Count != 0)
            {
                Tuple<int, int, int> cur = Q.Peek(); // 높이 , 세로 ,가로
                Q.Dequeue();

                for (int i = 0; i < 6; i++)
                {
                    int nx = cur.Item2 + dx[i];
                    int ny = cur.Item3 + dy[i];
                    int nz = cur.Item1 + dz[i];
                    if (nx < 0 || ny < 0 || nz < 0 || nx >= R || ny >= C || nz >= L )
                        continue;
                    if (vis[nz, nx, ny] != 0 || board[nz, nx, ny] == "#")
                        continue;
                    if(board[nz, nx, ny] == "E")
                    {
                        Q.Clear();
                        sr.Append($"Escaped in {vis[cur.Item1, cur.Item2, cur.Item3]} minute(s).");
                        return;
                    }
                    vis[nz, nx, ny] = vis[cur.Item1, cur.Item2, cur.Item3]+ 1;
                    Q.Enqueue(new Tuple<int, int, int>(nz, nx, ny));
                }
            }
            sr.Append("Trapped!");
        }
        
    }
}
