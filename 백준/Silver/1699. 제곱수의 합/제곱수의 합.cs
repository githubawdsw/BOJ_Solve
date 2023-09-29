using System;
namespace Dynamic
{
    
    class BOJ_1699
    {
        static int[] d = new int[100005];
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                d[i] = i;
                for (int j = 1; j * j <= i; j++)
                    d[i] = Math.Min(d[i], d[i - j * j] + 1);
            }
            Console.WriteLine(d[n]);
        }
    }
    
}
