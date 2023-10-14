using System;
using System.Collections.Generic;
using System.Text;
namespace BFS_DFS_Reculsive
{
    
    class AreaDivide_2583
    {
        static string[,] board = new string[101, 101];
        static bool[,] vis = new bool[101, 101];

        static int[] dx = { 1, 0, -1, 0 };
        static int[] dy = { 0, 1, 0, -1 };

        static int m , n , k;
        static Queue<KeyValuePair<int, int>> Q = new Queue<KeyValuePair<int, int>>();
        
        static void Main(string[] args)
        {
            string[] InputValue = Console.ReadLine().Split(" ");
            m = int.Parse(InputValue[0]) ;
            n = int.Parse(InputValue[1]) ;
            k = int.Parse(InputValue[2]);

            for (int i = 0; i < k; i++)
            {
                string[] Inputcoor = Console.ReadLine().Split(" ");

                for (int j = int.Parse(Inputcoor[1]); j < int.Parse(Inputcoor[3]); j++)
                {
                    for (int h = int.Parse(Inputcoor[0]); h < int.Parse(Inputcoor[2]); h++) 
                    {
                        board[j, h] = "1";
                    }
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (board[i, j] != "1")
                        board[i, j] = "0";
                }
            }

            BFSTest();
        }
        public static void BFSTest()
        {
            List<int> sumlist = new List<int>();
            int num = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (board[i, j] == "1" || vis[i,j] )
                        continue;

                    Q.Enqueue(new KeyValuePair<int, int>(i, j));
                    vis[i, j]  = true;
                    int area = 0;
                    num++;
                    while (Q.Count != 0)
                    {
                        area++;
                        KeyValuePair<int, int> cur = Q.Peek();
                        Q.Dequeue();

                        for (int z = 0; z < 4; z++)
                        {
                             int nx = cur.Key + dx[z];
                            int ny = cur.Value + dy[z];
                            if (nx < 0 || ny < 0 || nx >= m || ny >= n)
                                continue;
                            if (vis[nx, ny] || board[nx,ny] == "1")
                                continue;
                            vis[nx, ny] = true;
                            Q.Enqueue(new KeyValuePair<int, int>(nx, ny));

                        }
                    }
                    sumlist.Add(area);

                }
            }
            
            Console.WriteLine(num);
            StringBuilder sb = new StringBuilder();
            sumlist.Sort();
            for (int i = 0; i < sumlist.Count; i++)
            {
                sb.Append(sumlist[i]);
                sb.Append(" ");
            }
            Console.WriteLine(sb.ToString());
        }
        
    }
}
