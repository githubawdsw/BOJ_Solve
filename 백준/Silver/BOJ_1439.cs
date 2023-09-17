using System;
namespace GreedyAlgorithm
{
    
    class BOJ_1439
    {
        static int n;
        static void Main(string[] args)
        {
            string inputarr = Console.ReadLine();

            int count = 0;
            for (int i = 1; i < inputarr.Length; i++)
            {
                if (inputarr[0] != inputarr[i])
                {
                    if (inputarr[i] != inputarr[i - 1])
                        count++;
                }
            }
            Console.WriteLine(count);
        }
    }
    
}
