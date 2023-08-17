using System;

namespace Baekjoon1
{
    
    class BOJ_25304
    {
        static void Main(string[] args)
        {
            long x = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            long sum = 0;
            for (int i = 0; i < n; i++)
            {
                string[] inputWorth = Console.ReadLine().Split(' ');
                sum += long.Parse(inputWorth[0]) * long.Parse(inputWorth[1]);
            }
            if(sum == x)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

        }
    }
    
}
