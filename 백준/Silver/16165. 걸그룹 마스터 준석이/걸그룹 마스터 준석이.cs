using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace Hash
{
    
    class BOJ_16165
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder sb = new StringBuilder();

            string[] inputnm = sr.ReadLine().Split(' ');
            int n = int.Parse(inputnm[0]);
            int m = int.Parse(inputnm[1]);

            Dictionary<string, string> group = new Dictionary<string, string>();
            Dictionary<string, List<string>> team = new Dictionary<string, List<string>>();
            int index = 0;
            while (index < n)
            {
                string groupname = sr.ReadLine();
                int grouppersonnel = int.Parse(sr.ReadLine());
                team.Add(groupname, new List<string>());
                while (grouppersonnel > 0)
                {
                    string name = sr.ReadLine();
                    group.Add(name, groupname);
                    team[groupname].Add(name);
                    grouppersonnel--;
                }
                team[groupname].Sort();
                index++;
            }
            while (m >0)
            {
                m--;
                string name = sr.ReadLine();
                int nameorgroup = int.Parse(sr.ReadLine());
                if (nameorgroup == 1)
                    sb.AppendLine(group[name]);
                else
                    foreach (var one in team[name])
                        sb.AppendLine(one);
                
            }

            sw.WriteLine(sb);
            sw.Close();
            
        }
    }
    
}
