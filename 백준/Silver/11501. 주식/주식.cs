using System;

namespace GreedyAlgorithm
{
    
    class BOJ_11501
    {
        static int n, t;
        static void Main(string[] args)
        {
            t = int.Parse(Console.ReadLine());
            while (t> 0)
            {
                t--;
                n = int.Parse(Console.ReadLine());

                string[] inputarr = Console.ReadLine().Split(' ');
                int maxval = int.Parse(inputarr[n - 1]);
                long ans = 0;
                for (int i = n - 2; i >= 0; i--)
                {
                    if (int.Parse(inputarr[i]) > maxval)
                        maxval = int.Parse(inputarr[i]);
                    ans += maxval - int.Parse(inputarr[i]);
                }
                Console.WriteLine(ans);
            }
           
        }
    }
    
}
