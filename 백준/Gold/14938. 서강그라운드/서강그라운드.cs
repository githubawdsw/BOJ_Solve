using System;
using System.Text;
using System.Collections.Generic;
namespace Floyd_Warshall
{

    class BOJ_14938
    {
        static void Main(string[] args)
        {
            int[][] d = new int[105][];
            int[][] nextVer = new int[105][];
            string[] inputnmr = Console.ReadLine().Split(' ');
            int n = int.Parse(inputnmr[0]);
            int m = int.Parse(inputnmr[1]);
            int r = int.Parse(inputnmr[2]);
            string[] inputItem = Console.ReadLine().Split(' ');

            for (int i = 1; i <= n; i++)
            {
                d[i] = new int[n + 2];
                nextVer[i] = new int[n + 2];
                Array.Fill(d[i], int.MaxValue / 2);
                d[i][i] = 0;
            }
            for (int i = 0; i < r; i++)
            {
                string[] inputroad = Console.ReadLine().Split(' ');
                int a = int.Parse(inputroad[0]);
                int b = int.Parse(inputroad[1]);
                int len = int.Parse(inputroad[2]);
                if(len <= m)
                {
                    d[a][b] = len;
                    d[b][a] = len;
                    nextVer[a][b] = b;
                    nextVer[b][a] = a;
                }
            }

            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= n; j++)
                    for (int k = 1; k <= n; k++)
                        if (d[j][k] > d[j][i] + d[i][k])
                        {
                            d[j][k] = d[j][i] + d[i][k];
                            nextVer[j][k] = nextVer[j][i];
                        }

            bool[] vis;
            int ans = 0;
            for (int i = 1; i <= n; i++)
            {
                int max = 0;
                vis = new bool[n + 1];
                for (int j = 1; j <= n; j++)
                {
                    if (d[i][j] > m )
                        continue;

                    int idx = i;
                    while (idx != j)
                    {
                        vis[idx] = true;
                        idx = nextVer[idx][j];
                    }
                    vis[idx] = true;
                }
                for (int j = 1; j <= n; j++)
                    if (vis[j])
                        max += int.Parse(inputItem[j - 1]);
                
                ans = Math.Max(ans, max);
            }
            Console.WriteLine(ans);
        }
    }
}
