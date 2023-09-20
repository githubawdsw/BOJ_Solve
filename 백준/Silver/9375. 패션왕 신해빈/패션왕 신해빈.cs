using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace Hash
{
    
    class BOJ_9375
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder sb = new StringBuilder();

            int t = int.Parse(sr.ReadLine());
            while (t> 0)
            {
                t--;
                int n = int.Parse(sr.ReadLine());

                Dictionary<string, int> dic = new Dictionary<string, int>();
                int ans = 1;
                while (n> 0)
                {
                    string[] input = sr.ReadLine().Split(' ');
                    if(!dic.ContainsKey(input[1]))
                        dic.Add(input[1], 0);
                    dic[input[1]]++;
                    n--;
                }
                foreach (var one in dic)
                    ans *= one.Value + 1;

                sb.AppendLine((ans-1).ToString());
            }

            sw.WriteLine(sb);
            sw.Close();
            
        }
    }
    
}
