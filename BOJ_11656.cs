using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting
{
    
    class BOJ_11656
    {
        static string S;
        static List<string> stringList = new List<string>();
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            S = Console.ReadLine();

            stringList.Add(S);
            for (int i = 1; i < S.Length; i++)
            {
                string suffix = S.Substring(i);
                stringList.Add(suffix);
            }
            stringList = stringList.OrderBy(x => x).ToList();
            for (int i = 0; i < stringList.Count; i++)
            {
                sb.AppendLine(stringList[i]);
            }
            Console.WriteLine(sb);
        }
    }
    
}