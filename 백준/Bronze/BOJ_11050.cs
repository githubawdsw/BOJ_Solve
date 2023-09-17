using System;
namespace MathAlgorithm
{
    
    class BOJ_11050
    {
        static void Main(string[] args)
        {
            string[] inputnk = Console.ReadLine().Split(' ');
            int n = int.Parse(inputnk[0]);
            int k = int.Parse(inputnk[1]);

            int ans = 1;
            for (int i = k+1; i <= n; i++)
                ans *= i;
            for (int i = 1; i <= n - k; i++)
                ans /= i;
            Console.WriteLine(ans);
        }
    }
    
}
