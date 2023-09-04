using System;
namespace GreedyAlgorithm
{
    
    class BOJ_1789
    {
        static void Main(string[] args)
        {
            long s = long.Parse(Console.ReadLine());
            long temp = s;
            int n = 0;
            for (long i = 1; i <= s; i++)
            {
                if (temp - i < 0)
                    break;
                temp -= i;
                n++;
            }

            Console.WriteLine(  n);

        }
    }
    
}
