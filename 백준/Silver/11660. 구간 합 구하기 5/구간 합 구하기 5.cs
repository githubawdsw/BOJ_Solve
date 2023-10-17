using System;
using System.Collections.Generic;
using System.Text;
namespace Dynamic
{
    
    class BOJ_11660
    {
        static int[,] board = new int[1050, 1050];
        static int[,] d= new int[1050, 1050];
        static int n, m;
        static void Main(string[] args)
        {
            string[] inputnm = Console.ReadLine().Split(' ');
            n = int.Parse(inputnm[0]);
            m = int.Parse(inputnm[1]);
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= n; i++)
            {
                string[] inputarr = Console.ReadLine().Split(' ');
                for (int j = 1; j <= n; j++)
                {
                    board[i, j] = int.Parse(inputarr[j - 1]);
                    d[i, j] = d[i - 1, j] + d[i, j - 1] - d[i - 1, j - 1] + board[i, j];
                }
            }
           

            for (int i = 0; i < m; i++)
            {
                string[] inputarr = Console.ReadLine().Split(' ');
                int x1 = int.Parse(inputarr[0]);
                int y1 = int.Parse(inputarr[1]);
                int x2 = int.Parse(inputarr[2]);
                int y2 = int.Parse(inputarr[3]);

                sb.AppendLine($"{d[x2, y2] - d[x1 - 1, y2] - d[x2, y1 - 1] + d[x1 - 1, y1 - 1]}");
            }
            
            Console.WriteLine(sb);
        }
    }
    
}
