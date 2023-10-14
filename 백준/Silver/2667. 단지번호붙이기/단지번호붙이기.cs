using System;
using System.Collections.Generic;
using System.Text;

namespace BFS_DFS_Reculsive
{

    class Terminal_Nnumber_2667
    {
        static int N;
        static string[,] board = new string[30, 30];
        static bool[,] vis = new bool[30, 30];

        static int[] dx = { 1, 0, -1, 0 };
        static int[] dy = { 0, 1, 0, -1 };
        static Queue<KeyValuePair<int, int>> Q = new Queue<KeyValuePair<int, int>>();

        static List<int> ans = new List<int>();
        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string inputValue = Console.ReadLine();
                for (int j = 0; j < N; j++)
                {
                    board[i, j] = inputValue[j].ToString();
                }
            }

            int num = BFSTest();
           
            Console.WriteLine(num);
            ans.Sort();
            for (int i = 0; i < ans.Count; i++)
            {
                Console.WriteLine(ans[i]);
            }
        }
        public static int BFSTest()
        {
            int num = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (board[i, j] == "0" || vis[i, j] == true)
                        continue;

                    int area = 1;
                    num++;
                    vis[i, j] = true;
                    Q.Enqueue(new KeyValuePair<int, int>(i, j));
                    while (Q.Count != 0)
                    {
                        KeyValuePair<int, int> cur = Q.Peek();
                        Q.Dequeue();
                        for (int k = 0; k < 4; k++)
                        {
                            int nx = cur.Key + dx[k];
                            int ny = cur.Value + dy[k];
                            if (nx < 0 || ny < 0 || nx >= N || ny >= N)
                                continue;
                            if (board[nx, ny] == "0" || vis[nx, ny])
                                continue;
                            area++;
                            vis[nx, ny] = true;
                            Q.Enqueue(new KeyValuePair<int, int>(nx, ny));
                        }
                    }
                    ans.Add(area);
                }
            }
            return num;
        }
        
    }
}
