using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon2
{
    
    class BOJ_2589
    {
        static string[,] board = new string[52, 52];
        static int[,] vis = new int[52, 52];
        static int r, c;
        static int[] dx = { 1, 0, -1, 0 };
        static int[] dy = { 0, 1, 0, -1 };
        static Queue<KeyValuePair<int, int>> Q = new Queue<KeyValuePair<int, int>>();
        static Queue<KeyValuePair<int, int>> startQ = new Queue<KeyValuePair<int, int>>();
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            string[] inputrc = Console.ReadLine().Split(' ');
            r = int.Parse(inputrc[0]);
            c = int.Parse(inputrc[1]);

            for (int i = 0; i < r; i++)
            {
                string inputLW = Console.ReadLine();
                for (int j = 0; j < c; j++)
                {
                    board[i, j] = inputLW[j].ToString();
                }
            }

            startcheck();

            bfs();

            Console.WriteLine(sb);
        }
        static void startcheck()
        {
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                   if (board[i, j] == "W")
                        continue;
                    int roadcount = 0;
                    for (int k = 0;k < 4; k++)
                    {
                        int nx = i + dx[k];
                        int ny = j + dy[k];
                        if (nx < 0 || ny < 0 || nx >= r || ny >= c)
                            continue;
                        if (board[nx,ny] == "W")
                            continue;
                        roadcount++;
                    }
                    if (roadcount >= 1)
                    {
                        startQ.Enqueue(new KeyValuePair<int, int>(i, j));
                    }
                }
            }
        }

        static void bfs()
        {
            int max = 0;
            while (startQ.Count!= 0)
            {
                Q.Enqueue(startQ.Dequeue());
                for (int i = 0; i < r; i++)
                {
                    for (int j = 0; j < c; j++)
                    {
                        vis[i, j] = 0;
                    }
                }
                KeyValuePair<int, int> cur = Q.Peek();
                vis[cur.Key,cur.Value] = 1;
                while (Q.Count != 0)
                {
                    cur = Q.Dequeue();
                    for (int k = 0; k < 4; k++)
                    {
                        int nx = cur.Key + dx[k];
                        int ny = cur.Value + dy[k];
                        if (nx < 0 || ny < 0 || nx >= r || ny >= c)
                            continue;
                        if (board[nx, ny] == "W" || vis[nx, ny] > 0)
                            continue;
                        Q.Enqueue(new KeyValuePair<int, int>(nx, ny));
                        vis[nx, ny] = vis[cur.Key, cur.Value] + 1;
                        max = Math.Max(max, vis[nx, ny]);
                    }
                }
            }
            if (max != 0)
                sb.Append(max - 1);
            else
                sb.Append(max);
        }
    }
    
}
