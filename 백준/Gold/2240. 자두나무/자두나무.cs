using System;
using System.Text;
using System.Linq;

namespace Dynamic
{
    
    class BOJ_2240
    {
        static int W , T;
        static int[,,] D = new int[1005,35,3];
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            string[] TW = Console.ReadLine().Split(' ');
            T = int.Parse(TW[0]);
            W = int.Parse(TW[1]);
            for (int i = 1; i <= T; i++)
            {
                int fallingfruits = int.Parse(Console.ReadLine());
                D[i, 0, 1] = D[i - 1, 0, 1] + (fallingfruits == 1 ? 1 : 0);

                for (int j = 1; j <= W; j++)
                {
                    if (i < j)
                        break;
                    if(fallingfruits == 1)
                    {
                        D[i, j, 1] = Math.Max(D[i - 1, j - 1, 2], D[i - 1, j, 1] ) + 1;
                        D[i, j, 2] = Math.Max(D[i - 1, j - 1, 1], D[i - 1, j, 2]);
                    }
                    else
                    {
                        D[i, j, 1] = Math.Max(D[i - 1, j - 1, 2], D[i - 1, j, 1]);
                        D[i, j, 2] = Math.Max(D[i - 1, j - 1, 1], D[i - 1, j, 2] ) + 1;
                    }
                }

            }
            int ans = 0;
            for (int i = 0; i <= W; i++)
            {
                ans = Math.Max(ans, D[T, i, 1]);
                ans = Math.Max(ans, D[T, i, 2]);
            }
            Console.WriteLine(ans);
        }
    }
    
}
