using System;
using System.Linq;
using System.Text;
namespace Floyd_Warshall
{

    class BOJ_14588
    {
        static int n, l,r;
        static Tuple<int, int>[] rel = new Tuple<int, int>[305];
        static int[][] d = new int[305][];
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                d[i] = new int[305];
                string[] inputmt = Console.ReadLine().Split(' ');
                l = int.Parse(inputmt[0]);
                r = int.Parse(inputmt[1]);
                rel[i] = new Tuple<int, int>(l , r);
            }

            for (int i = 1; i <= n; i++)
                for (int j = i + 1; j <= n; j++)
                {
                    if (i == j)
                        continue;
                    int a = i;
                    int b = j;
                    if ((Math.Abs( rel[i].Item2 - rel[i].Item1 ) < Math.Abs( rel[j].Item2 - rel[j].Item1)))
                    {
                        a = j;
                        b = i;
                    }

                    if ((rel[a].Item1 <= rel[b].Item1 && rel[a].Item2 >= rel[b].Item1 )||
                        ( rel[a].Item1 <= rel[b].Item2 && rel[a].Item2 >= rel[b].Item2))
                    {
                        d[a][b] = 1;
                        d[b][a] = 1;
                    }
                }

            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= n; j++)
                {
                    if (i == j)
                        continue;
                    if (d[i][j] == 0)
                        d[i][j] = int.MaxValue / 2;
                }
            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= n; j++)
                    for (int k = 1; k <= n; k++)
                        if (d[j][k] > d[j][i] + d[i][k])
                            d[j][k] = d[j][i] + d[i][k];

            StringBuilder sb = new StringBuilder();
            
            int q = int.Parse(Console.ReadLine());
            for (int i = 0; i < q; i++)
            {
                string[] inputab = Console.ReadLine().Split(' ');
                int a = int.Parse(inputab[0]);
                int b = int.Parse(inputab[1]);
                if (d[a][b] == int.MaxValue / 2)
                    sb.AppendLine("-1");
                else
                    sb.AppendLine(d[a][b].ToString());
            }
            Console.WriteLine(sb);
        }
    }
}
