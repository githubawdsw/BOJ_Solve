using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
namespace Hash
{
    
    class BOJ_7785
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            int n = int.Parse(sr.ReadLine());
            HashSet<string> h = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string[] inputarr = sr.ReadLine().Split(' ');
                if (inputarr[1] == "enter")
                    h.Add(inputarr[0]);
                else
                    h.Remove(inputarr[0]);
            }

            List<string> htolist = h.ToList();
            htolist = htolist.OrderByDescending(x=>x).ToList();
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder sb = new StringBuilder();
            foreach (var one in htolist)
                sb.AppendLine( one);

            sw.WriteLine(sb);
            sw.Close();
        }
    }
    
}
