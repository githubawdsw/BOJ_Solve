using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
    
    class BOJ_12852
    {
        static int N;
        static int[] D = new int[1000003];
        static int[] vis = new int[1000003];
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());

            D[1] = 0;
            vis[1] = 0;

            for (int i = 2; i <= N; i++)
            {
                D[i] = D[i - 1] + 1;
                vis[i] = i - 1;
                if (i % 2 == 0 && D[i] > D[i/2] + 1)
                {
                    D[i] = Math.Min(D[i], D[i / 2] + 1);
                    vis[i] = i / 2;
                }
                if (i % 3 == 0 && D[i] > D[i/3] + 1)
                {
                    D[i] = Math.Min(D[i], D[i / 3] + 1);
                    vis[i] = i / 3;
                }
            }
            Console.WriteLine(D[N]);
            int cur = N;
            while (true)
            {
                sb.Append($"{cur} ");
                if (cur == 1)
                    break;
                cur = vis[cur];
            }
            Console.WriteLine(sb);
        }
    }
        
}
