using System;
using System.Text;

namespace Baekjoon2
{
    
    class BOJ_4095
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                string[] inputnm = Console.ReadLine().Split(' ');
                int n = int.Parse(inputnm[0]);
                int m = int.Parse(inputnm[1]);
                if (n == 0 && m == 0)
                    break;
                int[,] board = new int[1005, 1005];
                int[,] d = new int[1005,1005];
                for (int i = 1; i <= n; i++)
                {
                    string[] inputarr = Console.ReadLine().Split(' ');
                    for (int j = 1; j <= m; j++)
                        board[i, j] = int.Parse(inputarr[j - 1]);
                }
                int ans = 0;
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= m; j++)
                    {
                        if(board[i,j] == 1)
                        {
                            d[i, j] = Math.Min(d[i - 1, j], d[i, j - 1]) + 1;
                            d[i, j] = Math.Min(d[i - 1, j - 1] + 1, d[i, j]);
                            ans = Math.Max(d[i, j], ans);
                        }
                    }
                }
                sb.AppendLine(ans.ToString()); ;
            }
            Console.WriteLine(sb);
        }
    }
    
}
