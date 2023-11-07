using System;
using System.Collections.Generic;
using System.Linq;
namespace GreedyAlgorithm
{

    class BOJ_1744
    {
        static int n;
        static List<long> plist = new List<long>();
        static List<long> mlist = new List<long>();
        static List<long> anslist = new List<long>();
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                int val = int.Parse(Console.ReadLine());
                if (val > 0)
                    plist.Add(val);
                else
                    mlist.Add(val);
            }
            plist = plist.OrderByDescending(x => x).ToList();
            mlist.Sort();

            sumlist(plist);
            sumlist(mlist);

            Console.WriteLine(anslist.Sum());
        }
        static void sumlist(List<long> inpulist)
        {
            for (int i = 0; i < inpulist.Count; i++)
            {
                if (inpulist[i] == 1)
                    anslist.Add(inpulist[i]);
                else if (inpulist.Count <= i + 1)
                    anslist.Add(inpulist[i]);
                else
                {
                    anslist.Add(Math.Max(inpulist[i] * inpulist[i + 1], inpulist[i] + inpulist[i + 1]));
                    i++;
                }
            }
        }
    }
    
}
