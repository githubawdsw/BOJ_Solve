using System;
using System.Text;
using System.Collections.Generic;
namespace Dynamic
{
    
    class BOJ_15988
    {
        static int N , T;
        static long[] D = new long[ 1000005];
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            T = int.Parse(Console.ReadLine());
            while (T > 0)
            {
                T--;
                N = int.Parse(Console.ReadLine());

                D[1] = 1;
                D[2] = 2;
                D[3] = 4;
                for (int i = 4; i <= N; i++)
                {
                    D[i] = (D[i - 1] + D[i - 2] + D[i - 3]) % 1000000009;
                }

                sb.AppendLine(D[N].ToString());
            }
            Console.WriteLine(sb);
        }
    }
    
}
