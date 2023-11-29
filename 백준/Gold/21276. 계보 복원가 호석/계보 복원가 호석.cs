using System;
using System.Collections.Generic;
using System.Text;
namespace Topological_Sort
{
    
    class BOJ_21276
    {
        static Dictionary<string, int> dict = new Dictionary<string, int>();
        static List<int>[] listArr = new List<int>[1005];
        static int[] degree = new int[1005];
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] inputfamily = Console.ReadLine().Split(' ');
            Array.Sort(inputfamily);
            for (int i = 1; i <= n; i++)
                dict[inputfamily[i - 1]] = i;

            int m = int.Parse(Console.ReadLine());
            while(m-- >0)
            {
                string[] relation = Console.ReadLine().Split(' ');
                string child = relation[0];
                string ancestor = relation[1];
                if (listArr[dict[ancestor]] == null)
                    listArr[dict[ancestor]] = new List<int>();
                listArr[dict[ancestor]].Add(dict[child]);
                degree[dict[child]]++;
            }
            List<int> first = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                if (degree[i] == 0)
                    first.Add(i);
            }
            sb.AppendLine(first.Count.ToString());
            foreach (var one in first)
                sb.Append($"{inputfamily[ one - 1]} ");
            sb.AppendLine();

            List<int>[] ch = new List<int>[1005];
            for (int i = 1; i <= n; i++)
            {
                if (listArr[i] == null)
                    continue;
                listArr[i].Sort();
                foreach (var one in listArr[i])
                    if (degree[one] - degree[i] == 1)
                    {
                        if (ch[i] == null)
                            ch[i] = new List<int>();
                        ch[i].Add(one);
                    }    
            }

            for (int i = 1; i <= n; i++)
            {
                if (ch[i] == null)
                {
                    sb.Append($"{inputfamily[i - 1]} {0} ");
                    sb.AppendLine();
                    continue;
                }
                int size = ch[i].Count;
                sb.Append($"{inputfamily[i - 1]} {size} ");
                foreach (var one in ch[i])
                    sb.Append($"{inputfamily[one - 1]} ");
                sb.AppendLine();
            }
            Console.WriteLine(sb);
        }
    }
    
}
