using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
    
    class BOJ_1932
    {
        static int N;
        static int[,] D = new int[ 502, 502];
        static int[,] board = new int[502, 502];
        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                string[] inputarr = Console.ReadLine().Split(' ');
                for (int j = 1; j <= i; j++)
                {
                    board[i, j] = int.Parse(inputarr[j - 1]);
                }
            }

            D[1, 1] = board[1, 1];
            for (int i = 2; i <= N; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    D[i, j] = Math.Max(D[i - 1, j - 1], D[i - 1, j]) + board[i,j];
                }
            }
            int ans = 0;
            
            for (int i = 1; i <= N; i++)
            {
                ans = Math.Max(D[N, i], ans);
            }
            Console.WriteLine(ans);
        }
    }
        
}
