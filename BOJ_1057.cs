using System;

namespace MathAlgorithm
{
    
    class BOJ_1057
    {
        static void Main(string[] args)
        {
            string[] inputval = Console.ReadLine().Split(' ');
            int n = int.Parse(inputval[0]);
            int k = int.Parse(inputval[1]);
            int l = int.Parse(inputval[2]);

            int count = 0;
            while (k != l)
            {
                k = (k + 1) / 2;
                l = (l + 1) / 2;
                count++;
            }
            Console.WriteLine(count);
        }
    }
    
}
