using System;
using System.Text;

namespace Dynamic
{
    
    class BOJ_9461
    {
        static int N , T;
        static long[] D = new long[ 105];
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            T = int.Parse(Console.ReadLine());
            while(T >0)
            {
                T--;

                N = int.Parse(Console.ReadLine());
                D[1] = 1;
                D[2] = 1;
                D[3] = 1;
                D[4] = 2;
                D[5] = 2;

                for (int i = 6; i <= N; i++)
                    D[i] = D[i - 1] + D[i - 5];

                sb.AppendLine(D[N].ToString());
            }

            Console.WriteLine(sb);

        }
    }
    
}
