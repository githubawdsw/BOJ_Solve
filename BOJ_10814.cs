using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Sorting
{
    
    class BOJ_10814
    {
        static int n;
        static List<KeyValuePair<int, string>> inputArr = new List<KeyValuePair<int, string>>();
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            string[] narr = new string[2];
            for (int i = 0; i < n; i++)
            {
                narr = Console.ReadLine().Split(' ');
                inputArr.Add(new KeyValuePair<int, string>(int.Parse(narr[0]), narr[1]));
            }

            inputArr = inputArr.OrderBy
                (x => x.Key).ToList();

            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            for (int i = 0; i < n; i++)
            {
                sb.AppendLine($"{inputArr[i].Key} {inputArr[i].Value}");
            }
            sw.WriteLine(sb);
            sw.Close();
        }
    }

}
