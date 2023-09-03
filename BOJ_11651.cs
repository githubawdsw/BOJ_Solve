using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting
{
    
    class BOJ_11651
    {
        static int N;
        static List<Tuple<int, int>> inputArr = new List<Tuple<int, int>>();
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string[] inputValue = Console.ReadLine().Split(' ');
                inputArr.Add(new Tuple<int, int>(int.Parse(inputValue[0]), int.Parse(inputValue[1])));
            }
                
            inputArr = inputArr.OrderBy(x => x.Item2).ThenBy(y => y.Item1).ToList();
            for (int i = 0; i < N; i++)
            {
                sb.AppendLine($"{inputArr[i].Item1} {inputArr[i].Item2}");
            }
            Console.WriteLine(sb);
            
        }
    }

}
