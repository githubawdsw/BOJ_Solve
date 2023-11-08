using System;
using System.Collections.Generic;
namespace Floyd_Warshall
{
    
    class BOJ_1956
    {
        static int v, e;
        static long ans;
        static long[][] d = new long[405][];
        static void Main(string[] args)
        {
            string[] inputve = Console.ReadLine().Split(' ');
            v = int.Parse(inputve[0]);
            e = int.Parse(inputve[1]);

            int INF = 400 * (400 - 1) * 10002;
            ans = INF;

            for (int i = 1; i <= v; i++)
            {
                d[i] = new long[405];
                Array.Fill(d[i], INF);
                d[i][i] = 0;
            }

            for (int i = 0; i < e; i++)
            {
                string[] inputabc = Console.ReadLine().Split(' ');
                int a = int.Parse(inputabc[0]);
                int b = int.Parse(inputabc[1]);
                int c = int.Parse(inputabc[2]);
                d[a][b] = c;
            }
            for (int i = 1; i <= v; i++)
                for (int j = 1; j <= v; j++)
                    for (int k = 1; k <= v; k++)
                        if (d[j][k] > d[j][i] + d[i][k])
                            d[j][k] = d[j][i] + d[i][k];

            for (int i = 1; i <= v; i++)
                for (int j = i + 1; j <= v; j++)
                    ans = Math.Min(ans, d[i][j] + d[j][i]);

            if (ans == INF)
                ans = -1;
            Console.WriteLine(ans);
        }
    }
    
}
