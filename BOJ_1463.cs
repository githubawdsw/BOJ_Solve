using System;

namespace Dynamic
{
    
    class BOJ_1463
    {
        static int N;
        static int[] d = new int[1000001];
        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());
            d[1] = 0;
            for (int i = 2; i <=N; i++)
            {
                d[i] = d[i - 1] + 1;
                if (i % 2 == 0)
                    d[i] = Math.Min(d[i], d[i / 2] + 1);
                if (i%3 == 0)
                    d[i] = Math.Min(d[i], d[i / 3] + 1);
            }
            Console.WriteLine(d[N]);
        }
    }
    
}
