using System;
using System.Collections.Generic;
using System.Text;

namespace GreedyAlgorithm
{
    
    class BOJ_1946
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
           int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                List<Tuple<int, int>> tupleList = new List<Tuple<int, int>>();

                for (int i = 0; i < n; i++)
                {
                    string[] inputinfo = Console.ReadLine().Split(' ');
                    int info1 = int.Parse(inputinfo[0]);
                    int info2 = int.Parse(inputinfo[1]);
                    tupleList.Add(new Tuple<int, int>(info1, info2));
                }
                tupleList.Sort();

                int count = 0;
                int compareVal = int.MaxValue;
                for (int i = 0; i < n; i++)
                {
                    if (tupleList[i].Item2 < compareVal)
                    {
                        count++;
                        compareVal = tupleList[i].Item2;
                    }
                }
                sb.AppendLine($"{count}");
            }
            Console.WriteLine(  sb );
        }
    }
    
}
