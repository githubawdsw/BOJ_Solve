using System;

namespace GreedyAlgorithm
{
    
    class BOJ_13305
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] roaddist = Console.ReadLine().Split(' ');
            string[] fuelCost = Console.ReadLine().Split(' ');

            long min = int.MaxValue;
            long ans = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if (long.Parse(fuelCost[i]) < min)
                    min = long.Parse(fuelCost[i]);
                ans += min * long.Parse(roaddist[i]);
            }
            Console.WriteLine(  ans);
        }
    }
    
}
