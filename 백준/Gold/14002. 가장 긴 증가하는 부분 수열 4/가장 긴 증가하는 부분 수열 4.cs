using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Dynamic
{
    
    class BOJ_14002
    {
        static int n;
        static int[] D = new int[1005];
        static List<List<string>> list = new List<List<string>>();
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            string[] inputarr = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                list.Add(new List<string>());
                D[i] = 1;
            }
            for (int i = 0; i < n; i++)
            {
                list[i].Add(inputarr[i]);
                for (int j = 0; j < i; j++)
                {
                    if (int.Parse(inputarr[j]) < int.Parse(inputarr[i]) && D[i] < D[j] + 1)
                    {
                        D[i] = D[j] + 1;
                        list[i] = list[j].ToList();
                        if ( !list[i].Contains(inputarr[i]) )
                            list[i].Add(inputarr[i]);
                    }
                }
            }

            int max = D.Max();
            sb.AppendLine(max.ToString());

            int index = Array.IndexOf(D, max);

            for (int i = 0; i < list[index].Count; i++)
            {
                sb.Append($"{list[index][i]} ");
            }
            Console.WriteLine(sb);
        }
    }
    
}
