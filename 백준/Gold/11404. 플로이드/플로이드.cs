using System;
using System.Text;
namespace Floyd_Warshall
{
    class BOJ_11404
    {
        static void Main(string[] args)
        {
            int[][] d = new int[105][];
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                d[i] = new int[n + 2];
                Array.Fill(d[i],int.MaxValue / 2);
            }

            for (int i = 0; i < m; i++)
            {
                string[] inputcost = Console.ReadLine().Split(' ');
                int p1 = int.Parse(inputcost[0]);
                int p2 = int.Parse(inputcost[1]);
                int cost = int.Parse(inputcost[2]);
                d[p1 ][p2 ] = Math.Min( cost , d[p1][p2]);
            }
            for (int i = 1; i <= n; i++)
                d[i][i] = 0;

            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= n; j++)
                    for (int k = 1; k <= n; k++)
                        if (d[j][k] > d[j][i] + d[i][k])
                            d[j][k] = d[j][i] + d[i][k];

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
            Console.WriteLine(sb);
        }
    }
}
