using System;
namespace Dynamic
{
    
    class BOJ_9657
    {
        static int[,] d = new int[1005, 3];
        static int n;
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            d[1, 0] = 1;
            d[2, 1] = 1;
            d[3, 0] = 1;
            d[4, 0] = 1;
            for (int i = 5; i <= n; i++)
            {
                int middle = Math.Max(d[i - 3, 1], d[i - 4, 1]);
                d[i, 0] = (Math.Max(middle, d[i - 1, 1]) == 1) ? 1 : 0;
                if (d[i, 0] == 0)
                    d[i, 1] = 1;
            }
            if (d[n, 0] == 1)
                Console.WriteLine("SK");
            else
                Console.WriteLine("CY");
        }
    }
    
}
