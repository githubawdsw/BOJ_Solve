using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace Hash
{
    
    class BOJ_1620
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder sb = new StringBuilder();

            string[] inputnm = sr.ReadLine().Split(' ');
            int n = int.Parse(inputnm[0]);
            int m = int.Parse(inputnm[1]);
            string[] key = new string[100005];
            Dictionary<string, int> dic = new Dictionary<string, int>();
            for (int i = 1; i <= n; i++)
            {
                string input = sr.ReadLine();
                dic.Add(input , i);
                key[i] = input;
            }

            for (int i = 0; i < m; i++)
            {
                string val = sr.ReadLine();
                if (int.TryParse(val, out _))
                    sb.AppendLine(key[int.Parse(val)]);
                else
                    sb.AppendLine(dic[val].ToString());
            }
            sw.WriteLine(sb);
            sw.Close();
        }
    }
    
}
