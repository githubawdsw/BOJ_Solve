using System;

namespace MathAlgorithm
{
    
    class BOJ_1978
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] inputarr = Console.ReadLine().Split(' ');

            int ans = 0;
            for (int i = 0; i < inputarr.Length; i++)
            {
                if (int.Parse(inputarr[i]) == 1)
                    continue;
                bool check = false;
                for (int j = 2; j*j < int.Parse(inputarr[i]); j++)
                {
                    if (int.Parse(inputarr[i]) % j == 0)
                        check = true;
                }
                if (!check)
                    ans++;
            }
            Console.WriteLine(ans);
        }
    }
    
}
