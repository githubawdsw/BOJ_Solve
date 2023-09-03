using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Sorting
{
    
    class BOJ_11931
    {
        static int n;
        static int[] inputArr;
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            inputArr = new int[n];
            for (int i = 0; i < n; i++)
                inputArr[i] = int.Parse(Console.ReadLine());

            List<int> leftlist = new List<int>();
            List<int> rightlist = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (i < n / 2)
                    leftlist.Add(inputArr[i]);
                else
                    rightlist.Add(inputArr[i]);
            }

            leftlist =  leftlist.OrderByDescending(i => i).ToList();
            rightlist =  rightlist.OrderByDescending(i => i).ToList();

            int a = 0, b = 0;

            while(a < leftlist.Count && b < rightlist.Count)
            {
                if (leftlist[a] > rightlist[b])
                {
                    sb.Append(leftlist[a]);
                    sb.Append("\n");
                    a++;
                }    
                else
                {
                    sb.Append(rightlist[b]);
                    sb.Append("\n");
                    b++;
                }
            }
            while (a < leftlist.Count)
            {
                sb.Append(leftlist[a]);
                sb.Append("\n");
                a++;
            }
            while (b < rightlist.Count)
            {
                sb.Append(rightlist[b]);
                sb.Append("\n");
                b++;
            }

            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            sw.WriteLine(sb);
            sw.Close();
        }
    }

}
