using System;
using System.Collections.Generic;
using System.Linq;
namespace GreedyAlgorithm
{
    
    class BOJ_2170
    {
        static int n ;
        static List<Tuple<int, int>> inputlist = new List<Tuple<int, int>>();
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] inputline = Console.ReadLine().Split(' ');
                inputlist.Add(new Tuple<int, int>
                    (Math.Min(int.Parse(inputline[0]), int.Parse(inputline[1]))
                    , Math.Max(int.Parse(inputline[0]), int.Parse(inputline[1]))));
            }

            inputlist = inputlist.OrderBy(x => x.Item1).ThenBy(x => x.Item2).ToList();
            
            int ans = inputlist[0].Item2 - inputlist[0].Item1;
            int first = inputlist[0].Item1;
            int second = inputlist[0].Item2;

            for (int i = 1; i < n; i++)
            {
                if (inputlist[i].Item1 <= second && inputlist[i].Item2 > second)
                { 
                    ans += inputlist[i].Item2 - second;
                    second = inputlist[i].Item2;
                }
                else if (inputlist[i].Item1 > second)
                {
                    first = inputlist[i].Item1;
                    second = inputlist[i].Item2;
                    ans += second - first;
                }
            }
            Console.WriteLine( ans);

        }
    }
    
}
