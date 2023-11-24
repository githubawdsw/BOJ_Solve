using System;
using System.Text;
namespace Floyd_Warshall
{
    
    class BOJ_1507
    {
        static int n;
        static int[][] d = new int[25][];
        static bool[,] vis = new bool[25, 25];
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                d[i] = new int[25];
                string[] inputarr = Console.ReadLine().Split(' ');
                for (int j = 1; j <= n; j++)
                    d[i][j] = int.Parse(inputarr[j - 1]);
            }

            for(int i = 1; i <= n; i++)
                for (int j = 1; j <= n; j++)
                {
                    bool isunit = true;
                    for (int k = 1; k <= n; k++)
                    {
                        if (k == i || k == j)
                            continue;
                        int temp = d[i][k] + d[k][j];
                        if (temp < d[i][j])
                        {
                            Console.WriteLine(-1);
                            return;
                        }
                        else if (temp == d[i][j])
                            isunit = false;
                    }
                    if (isunit)
                        vis[i, j] = vis[j, i] = true;
                }

            int ans = 0;
            for (int i = 1; i <= n; i++)
                for (int j = i; j <= n; j++)
                    if(vis[i,j])
                        ans += d[i][j];

            Console.WriteLine(ans);
        }
    }
    
}
