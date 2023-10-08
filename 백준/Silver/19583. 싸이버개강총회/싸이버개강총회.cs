using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace Hash
{
    
    class BOJ_19583
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder sb = new StringBuilder();

            string[] inputseq = sr.ReadLine().Split(' ');
            int stime = int.Parse( inputseq[0].Replace(":" , ""));
            int etime = int.Parse(inputseq[1].Replace(":", ""));
            int qtime = int.Parse(inputseq[2].Replace(":", ""));

            HashSet<string> hs = new HashSet<string>();
            int ans = 0;
            string inputchat;
            int inputtime;
            while (true)
            {
                inputchat = sr.ReadLine();
                if (inputchat == null)
                    break;
                string[] split = inputchat.Split(' ');

                inputtime = int.Parse(split[0].Replace(":", ""));
                if(inputtime <= stime)
                    hs.Add(split[1]);
                if (inputtime >= etime && inputtime <= qtime )
                {
                    if (hs.Contains(split[1]))
                    {
                        hs.Remove(split[1]);
                        ans++;
                    }
                }
            }
            sb.AppendLine(ans.ToString());
            sw.WriteLine(sb);
            sw.Close();
            
        }
    }
    
}
