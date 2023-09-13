using System;
using System.Text;

namespace Dynamic
{
    
    class BOJ_1003
    {
        static int T , N;
        static int[,] fibo = new int[41,2];
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            T = int.Parse(Console.ReadLine());
            
            fibo[0,0] = 1;
            fibo[1,1] = 1;
            for (int i = 2; i <= 40; i++)
            {
                fibo[i, 0] = fibo[i - 1, 0] + fibo[i - 2, 0];
                fibo[i, 1] = fibo[i - 1, 1] + fibo[i - 2, 1];
            }

            while (T > 0)
            {
                T--;
                N = int.Parse(Console.ReadLine());

                sb.AppendLine($"{fibo[N, 0]} {fibo[N, 1]}");
            }

            Console.WriteLine(sb);
        }
    }

}
