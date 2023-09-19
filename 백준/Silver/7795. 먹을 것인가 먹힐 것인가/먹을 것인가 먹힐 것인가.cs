using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace Sorting
{
    
    class BOJ_7795
    {
        static int N, M ,T;
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            T = int.Parse(Console.ReadLine());

            while(T>0)
            {
                T--;
                string[] inputNM = Console.ReadLine().Split(' ');
                N = int.Parse(inputNM[0]);
                M = int.Parse(inputNM[1]);
                string[] inputNarr = Console.ReadLine().Split(' ');
                string[] inputMarr = Console.ReadLine().Split(' ');

                List<KeyValuePair<int, int>> pairList = new List<KeyValuePair<int, int>>();
                for (int i = 0; i < N; i++)
                    pairList.Add(new KeyValuePair<int, int>(int.Parse(inputNarr[i]), 0));
                
                for (int i = 0; i < M; i++)
                    pairList.Add(new KeyValuePair<int, int>(int.Parse(inputMarr[i]), 1));

                pairList = pairList.OrderBy(x => x.Key).ThenBy(x=>x.Value).ToList();
                int count = 0;
                int ans = 0;
                for (int i = 0; i < N+M; i++)
                {
                    if (pairList[i].Value == 0)
                        ans += count;
                    else
                        count++;
                }
                sb.AppendLine(ans.ToString());
            }
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            sw.WriteLine(sb);
            sw.Close();
        }

    }
    
}