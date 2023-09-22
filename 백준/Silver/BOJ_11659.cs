using System;
using System.Text;

namespace Dynamic
{
    
    class BOJ_11659
    {
        static int N,M,i,j;
        static int[] D = new int[100001];

        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            string[] NM = Console.ReadLine().Split(' ');
            N = int.Parse(NM[0]);
            M = int.Parse(NM[1]);

            string[] inputNarr = Console.ReadLine().Split(' ');

            D[0] = 0;
            for (int a = 1; a <= N; a++)
            {
                D[a] = D[a - 1] + int.Parse(inputNarr[a - 1]);
            }
            for (int b = 0; b < M; b++)
            {
                string[] inputij = Console.ReadLine().Split(' ');
                i = int.Parse(inputij[0]);
                j = int.Parse(inputij[1]);

                sb.AppendLine((D[j] - D[i - 1]).ToString());
            }
            Console.WriteLine(sb);
        }
    }
    
}
