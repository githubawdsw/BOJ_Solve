using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Sorting
{
    
    class BOJ_2750
    {
        static int n;
        static int[] inputArr;
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            inputArr = new int[n];
            for (int i = 0; i < n; i++)
            {
                inputArr[i] = int.Parse(Console.ReadLine());
            }

            List<int> leftArr = new List<int>();
            List<int> rightArr = new List<int>();
            for (int i = 0; i < n/2; i++)
            {
                leftArr.Add(inputArr[i]);
            }
            for (int i = n/2; i < n; i++)
            {
                rightArr.Add(inputArr[i]);
            }
            leftArr.Sort();
            rightArr.Sort();

            List<int> mergelist = new List<int>();
            int l = 0, r = 0;
            while (l < leftArr.Count && r < rightArr.Count)
            {
                if(leftArr[l] < rightArr[r])
                {
                    mergelist.Add(leftArr[l]);
                    l++;
                }
                else
                {
                    mergelist.Add(rightArr[r]);
                    r++;
                }
            }
            while (l < leftArr.Count)
            {
                mergelist.Add(leftArr[l]);
                l++;
            }
            while ( r < rightArr.Count)
            {
                mergelist.Add(rightArr[r]);
                r++;
            }

            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            for (int i = 0; i < mergelist.Count; i++)
            {
                sb.AppendLine(mergelist[i].ToString());
            }
            sw.WriteLine(sb);
            sw.Close();
        }
    }

}
