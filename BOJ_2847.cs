using System;
namespace GreedyAlgorithm
{
    
    class BOJ_2847
    {
        static int n;
        static int[] level = new int[105];
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
                level[i] = int.Parse(Console.ReadLine());

            int count = 0;
            for (int i = n-1; i > 0; i--)
            {
                int beforelevel = i + 1;
                while (level[beforelevel] <= level[i])
                {
                    level[i]--;
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
    
}
