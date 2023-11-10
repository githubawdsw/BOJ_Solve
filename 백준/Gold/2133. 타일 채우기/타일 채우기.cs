using System;
namespace Dynamic
{
    
    class BOJ_2133
    {
        static int[] d = new int[35];
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            d[2] = 3;
            for (int i = 4; i <= n; i+=2)
            {
                d[i] += d[i - 2] * 3;
                for (int j = 6; j <= i; j+=2)
                {
                    d[i] += d[j - 4] * 2;
                }
                d[i] += 2;
            }
            
            Console.WriteLine(d[n]);
        }
    }
    
}
