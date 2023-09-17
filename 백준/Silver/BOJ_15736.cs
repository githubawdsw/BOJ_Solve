using System;

namespace MathAlgorithm
{
    
    class BOJ_15736
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int idx = 1;
            int count = 1;
            int ans = 0;
            while (idx <= n)
            {
                count += 2;
                idx += count;
                ans++;
            }
            Console.WriteLine(  ans);
        }
    }
    
}
