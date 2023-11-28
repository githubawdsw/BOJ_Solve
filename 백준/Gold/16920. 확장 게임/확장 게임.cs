using System;
using System.Collections.Generic;
using System.Text;
namespace BFS_DFS_Reculsive
{
    
    class Expansion_Game_16920
    {
        static string[,] board = new string[1001, 1001];

        static int[] dx = { 0, 1, 0, -1 };
        static int[] dy = { 1, 0, -1, 0 };
        static int n, m, p;
        static string[] sp;

        static List<Queue<Tuple<int, int, int>>> Q =
                new List<Queue<Tuple<int, int, int>>>();

        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            string[] inputAmount = Console.ReadLine().Split(" ");
            n = int.Parse(inputAmount[0]);
            m = int.Parse(inputAmount[1]);
            p = int.Parse(inputAmount[2]);

            sp = Console.ReadLine().Split(" ");

            for (int i = 0; i < n; i++)
            {
                string inputValue = Console.ReadLine();
                for (int j = 0; j < m; j++)
                {
                    board[i, j] = inputValue[j].ToString();
                }
            }
            for (int k = 1; k <= p; k++)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (board[i, j] == k.ToString())
                        {
                            Q.Add(new Queue<Tuple<int, int, int>>());
                            Q[k-1].Enqueue(new Tuple<int, int, int>(i, j, 0));

                        }
                    }
                }
            }



            BFSTest();
            

            int[] count = new int[p+1];
            for (int i = 1; i <= p; i++)
            {
                for (int a = 0; a < n; a++)
                {
                    for (int b = 0; b < m; b++)
                    {
                        if (board[a, b] == i.ToString())
                            count[i]++;
                    }
                }
            }
            for (int i = 1; i <= p; i++)
            {
                sb.Append(count[i]);
                sb.Append(" ");
            }
            Console.WriteLine(sb);
        }

        public static void BFSTest()
        {
            while (true)
            {
                bool isExtend = false;

                for (int i = 1; i <= p; i++)
                {
                    Queue<Tuple<int, int, int>> nextQ =
                            new Queue<Tuple<int, int, int>>();
                    while (Q[i-1].Count != 0)
                    {
                        Tuple<int, int, int> cur = Q[i-1].Dequeue();

                        if (cur.Item3 == int.Parse(sp[i-1]))
                        {
                            nextQ.Enqueue(new Tuple<int, int, int>( cur.Item1, cur.Item2, 0));
                            continue;
                        }

                        for (int j = 0; j < 4; j++)
                        {
                            int nx = cur.Item1 + dx[j];
                            int ny = cur.Item2 + dy[j];
                            if (nx < 0 || ny < 0 || nx >= n || ny >= m)
                                continue;
                            if (board[nx, ny] != ".")
                                continue;
                            Q[i-1].Enqueue(new Tuple<int, int, int>(nx, ny, cur.Item3 + 1));
                            board[nx, ny] = board[cur.Item1, cur.Item2];
                            isExtend = true;
                        }
                    }
                    Q[i-1] = nextQ;
                }
                if (!isExtend)
                    break;
            }
            
        }
        
    }
}
