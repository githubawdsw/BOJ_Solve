using System;
using System.IO;
using System.Text;

namespace Sorting
{
    
    class BOJ_15688
    {
        static int n;
        static int[] inputArr;
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            inputArr = new int[2000001];
            for (int i = 0; i < n; i++)
                inputArr[int.Parse(Console.ReadLine()) + 1000000]++;
            for (int i = 0; i <= 2000000; i++)
                while(inputArr[i] != 0)
                {
                    sb.AppendLine($"{i - 1000000}");
                    inputArr[i]--;
                }
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            sw.WriteLine(sb);
            sw.Close();
        }
    }

}
