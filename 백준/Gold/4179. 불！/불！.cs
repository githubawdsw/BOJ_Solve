using System;
using System.Collections.Generic;
namespace BFS_DFS_Reculsive
{
    class Fire1
    {
        static string[,] board = new string[1000, 1000];
        static int[,] distanF = new int[1000, 1000];
        static int[,] distanJ = new int[1000, 1000];

        static int[] dx = { 1, 0, -1, 0 };
        static int[] dy = { 0, 1, 0, -1 };

        static int n, m;
        
        static void Main(string[] args)
        {
            string[] inputAmount = Console.ReadLine().Split(" ");
            n = int.Parse(inputAmount[0]);
            m = int.Parse(inputAmount[1]);

            BFSTest(n, m);
        }
        public static void BFSTest(int _n , int _m)
        {

            Queue<KeyValuePair<int, int>> F =
                new Queue<KeyValuePair<int, int>>();

            Queue<KeyValuePair<int, int>> J = 
                new Queue<KeyValuePair<int, int>>();

            for (int i = 0; i < n; i++)
            {
                string inputValString = Console.ReadLine();
                for (int j = 0; j < m; j++)
                {
                    board[i, j] = inputValString[j].ToString();

                    if (board[i, j] == "F")
                    {
                        F.Enqueue(new KeyValuePair<int, int>(i, j));
                    }
                    if (board[i, j] == "J")
                    {
                        J.Enqueue(new KeyValuePair<int, int>(i, j));
                    }
                    if (board[i, j] == "#")
                    {
                        distanF[i, j] = -2; distanJ[i, j] = -2; ;
                    }
                    if (board[i, j] == ".")
                    {
                        distanF[i, j] = -1; distanJ[i, j] = -1; 
                    }
                }
            }

            while (F.Count != 0)
            {
                KeyValuePair<int, int> curf = F.Peek();
                F.Dequeue();

                for (int i = 0; i < 4; i++)
                {
                    int nx = curf.Key + dx[i];
                    int ny = curf.Value + dy[i];
                    if (nx < 0 || nx >= _n || ny < 0 || ny >= _m)
                        continue;
                    if (distanF[nx, ny] >= 0 || board[nx, ny] == "#")
                        continue;
                    distanF[nx, ny] = distanF[curf.Key, curf.Value] + 1;
                    F.Enqueue(new KeyValuePair<int, int>(nx, ny));
                }
            } 
            while (J.Count != 0) 
            { 
                KeyValuePair<int, int> curj = J.Peek();
                J.Dequeue();

                for (int i = 0; i < 4; i++)
                {
                    int nx = curj.Key + dx[i];
                    int ny = curj.Value + dy[i];
                    if (nx < 0 || nx >= _n || ny < 0 || ny >= _m)
                    {
                        Console.WriteLine(distanJ[curj.Key, curj.Value] + 1);
                        return;
                    }
                        
                    if (distanJ[nx, ny] >= 0 || board[nx, ny] == "#")
                        continue;
                    if (distanF[nx,ny] != -1 && distanJ[curj.Key, curj.Value]+1 >= distanF[nx,ny])
                        continue;
                    distanJ[nx, ny] = distanJ[curj.Key, curj.Value] + 1;
                    J.Enqueue(new KeyValuePair<int, int>(nx, ny));
                }
            }
            Console.WriteLine("IMPOSSIBLE ");
        }
        
    }
}
