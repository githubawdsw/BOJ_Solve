using System;
using System.Collections.Generic;
using System.Linq;
namespace GreedyAlgorithm
{
    
    class BOJ_8980
    {
        static int n ,c;
        static void Main(string[] args)
        {
            string[] inputnc = Console.ReadLine().Split(' ');
            n = int.Parse(inputnc[0]);
            c = int.Parse(inputnc[1]);
            int m = int.Parse(Console.ReadLine());

            List<Tuple<int, int, int>> tupleList = new List<Tuple<int, int,int>>();
            int[] truck = new int[2002];

            for (int i = 0; i < m; i++)
            {
                string[] inputinfo = Console.ReadLine().Split(' ');
                int start = int.Parse(inputinfo[0]);
                tupleList.Add(new Tuple< int, int, int>(start ,int.Parse(inputinfo[1]),int.Parse(inputinfo[2])));
            }
            tupleList = tupleList.OrderBy(x => x.Item2).ToList();

            int ans = 0;
            foreach (var one in tupleList)
            {
                int baggage = one.Item3;
                bool loadable = true;
                for (int i = one.Item1; i < one.Item2; i++)
                {
                    baggage = Math.Min(baggage, c - truck[i]);
                    if(baggage <=0)
                    {
                        loadable = false;
                        break;
                    }
                }
                if(loadable)
                {
                    ans += baggage;
                    for (int i = one.Item1; i < one.Item2; i++)
                        truck[i] += baggage;
                }
            }
            Console.WriteLine(  ans);
        }
    }
    
}
