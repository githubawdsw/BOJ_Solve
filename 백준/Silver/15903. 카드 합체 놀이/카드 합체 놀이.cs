using System;
using System.Collections.Generic;
using System.Linq;
namespace GreedyAlgorithm
{
    
    class BOJ_15903
    {
        static int n , m;
        static List<long> inputlist = new List<long>();
        static void Main(string[] args)
        {
            string[] inputnm = Console.ReadLine().Split(' ');
            n = int.Parse(inputnm[0]);
            m = int.Parse(inputnm[1]);

            string[] inputarr = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
                inputlist.Add(long.Parse(inputarr[i]));
            inputlist.Sort();

            while(m > 0)
            {
                m--;
                long sum = inputlist[0] + inputlist[1];
                inputlist[0] = sum;
                inputlist[1] = sum;
                inputlist.Sort();
            }
            Console.WriteLine(inputlist.Sum());
        }
    }
    
}
