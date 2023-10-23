using System;

namespace Dynamic
{
    
    class BOJ_2096
    {
        static void Main(string[] args)
        {
            int[,] dp1 = new int[3,100005];
            int[,] dp2 = new int[3, 100005];
            int n = int.Parse(Console.ReadLine());

            string[] inputnum = Console.ReadLine().Split(' ');
            dp1[0, 0] = int.Parse(inputnum[0]);
            dp1[1, 0] = int.Parse(inputnum[1]);
            dp1[2, 0] = int.Parse(inputnum[2]);

            dp2[0, 0] = int.Parse(inputnum[0]);
            dp2[1, 0] = int.Parse(inputnum[1]);
            dp2[2, 0] = int.Parse(inputnum[2]);
            for (int i = 1; i < n; i++)
            {
                inputnum = Console.ReadLine().Split(' ');
                
                dp1[0, i] = Math.Max(dp1[0, i - 1] , dp1[1, i - 1] ) + +int.Parse(inputnum[0]);
                dp1[1, i] = Math.Max(dp1[0, i - 1] , dp1[1, i - 1] ) + int.Parse(inputnum[1]);
                dp1[1, i] = Math.Max(dp1[2, i - 1] + int.Parse(inputnum[1]), dp1[1, i]);
                dp1[2, i] = Math.Max(dp1[1, i - 1] , dp1[2, i - 1] ) + int.Parse(inputnum[2]);

                dp2[0, i] = Math.Min(dp2[0, i - 1] , dp2[1, i - 1] ) + int.Parse(inputnum[0]);
                dp2[1, i] = Math.Min(dp2[0, i - 1], dp2[1, i - 1]) + int.Parse(inputnum[1]);
                dp2[1, i] = Math.Min(dp2[2, i - 1] + int.Parse(inputnum[1]), dp2[1, i]);
                dp2[2, i] = Math.Min(dp2[1, i - 1], dp2[2, i - 1]) + int.Parse(inputnum[2]);
            }

            int max = 0; int min = int.MaxValue;
            for (int i = 0; i < 3; i++)
            {
                max = Math.Max(dp1[i, n - 1] ,  max);
                min = Math.Min(dp2[i, n - 1], min);
            }
            Console.WriteLine($"{max} {min}");
        }
    }
    
}
