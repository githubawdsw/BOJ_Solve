using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting
{
    
    class BOJ_1181
    {
        static int N;
        static List<string> inputArr = new List<string>();
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string inputval = Console.ReadLine();
                inputArr.Add(inputval);
            }
            inputArr = inputArr.Distinct().ToList();
            inputArr = inputArr.OrderBy(x => x.Length).ThenBy(x => x).ToList();
            for (int i = 0; i < inputArr.Count; i++)
            {
                sb.AppendLine(inputArr[i]);
            }
            Console.WriteLine(sb);
        }
        
    }

}
