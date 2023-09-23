using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
namespace Hash
{
    
    class BOJ_13414
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder sb = new StringBuilder();

            string[] inputkl = sr.ReadLine().Split(' ');
            int k = int.Parse(inputkl[0]);
            int l = int.Parse(inputkl[1]);
            Dictionary<string, int> dic = new Dictionary<string, int>();

            for (int i = 0; i < l; i++)
            {
                string input = sr.ReadLine();
                if (!dic.ContainsKey(input))
                    dic.Add(input, i);
                else
                {
                    dic.Remove(input );
                    dic.Add(input, i);
                }
            }

            var sort = dic.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            int count = 0;
            foreach (var one in sort)
            {
                sb.AppendLine(one.Key);
                count++;
                if (count == k)
                    break;
            }
            
            sw.WriteLine(sb);
            sw.Close();
            
        }
    }
    
}
