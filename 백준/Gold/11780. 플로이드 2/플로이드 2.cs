using System;
using System.Text;
using System.Collections.Generic;
namespace Floyd_Warshall
{

    class BOJ_11780
    {
        static void Main(string[] args)
        {
            int[][] d = new int[105][];
            int[][] nextVer = new int[105][];
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                d[i] = new int[n + 2];
                nextVer[i] = new int[n + 2];
                Array.Fill(d[i], int.MaxValue / 2);
            }

            for (int i = 0; i < m; i++)
            {
                string[] inputcost = Console.ReadLine().Split(' ');
                int start = int.Parse(inputcost[0]);
                int end = int.Parse(inputcost[1]);
                int cost = int.Parse(inputcost[2]);
                d[start][end] = Math.Min( cost , d[start][end]);
                nextVer[start][end] = end;
            }

            for (int i = 1; i <= n; i++)
                d[i][i] = 0;

            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= n; j++)
                    for (int k = 1; k <= n; k++)
                        if (d[j][k] > d[j][i] + d[i][k])
                        {
                            d[j][k] = d[j][i] + d[i][k];
                            nextVer[j][k] = nextVer[j][i];
                        }

            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (d[i][j] == int.MaxValue / 2)
                        d[i][j] = 0;
                    sb.Append($"{d[i][j]} ");
                }
                sb.AppendLine();
            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if(d[i][j] == 0)
                    {
                        sb.AppendLine("0");
                        continue;
                    }
                    
                    List<int> route = new List<int>();
                    int idx = i;
                    while ( idx != j)
                    {
                        route.Add(idx);
                        idx = nextVer[idx][j];
                    }
                    route.Add(idx);
                    sb.Append($"{route.Count} ");
                    foreach (var one in route)
                        sb.Append($"{one} ");
                    sb.AppendLine();
                }
            }
            Console.WriteLine(sb);
        }
    }
}
