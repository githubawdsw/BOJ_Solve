using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting
{
    
    class BOJ_10825
    {
        static int N;
        static List<Tuple<string, int, int, int>> stringList = 
            new List<Tuple<string, int, int, int>>();
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] inputArr = Console.ReadLine().Split(' ');
                stringList.Add(new Tuple<string, int, int, int>
                    ( inputArr[0] , int.Parse(inputArr[1]) , int.Parse(inputArr[2]) , int.Parse(inputArr[3])));
            }
            List<Tuple<string, int, int, int>> ans = stringList.OrderByDescending
                (x => x.Item2).ThenBy(x=>x.Item3).ThenByDescending(x=>x.Item4)
                .ThenBy(x=>x.Item1).ToList();
            for (int i = 0; i < N; i++)
            {
                sb.AppendLine(ans[i].Item1);
            }
            Console.WriteLine(sb);
        }
    }
    
}