using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace Hash
{
    
    class BOJ_17219
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder sb = new StringBuilder();

            string[] inputnm = sr.ReadLine().Split(' ');
            int n = int.Parse(inputnm[0]);
            int m = int.Parse(inputnm[1]);
            Dictionary<string, string> dic = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = sr.ReadLine().Split(' ');
                dic.Add(input[0], input[1]);
            }
            for (int i = 0; i < m; i++)
                sb.AppendLine(dic[sr.ReadLine()]);
            
            sw.WriteLine(sb);
            sw.Close();
            
        }
    }
    
}
