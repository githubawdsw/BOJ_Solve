using System;
using System.IO;

namespace Sorting
{
    class BOJ_10989
    {
        static int n;
        static int[] inputArr;
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            inputArr = new int[10001];
            int num = 0;
            for (int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());
                inputArr[num]++;
            }

            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            for (int i = 1; i <= 10000; i++)
            {
                while (inputArr[i] != 0)
                {
                    sw.Write(i.ToString() + "\n");
                    inputArr[i]--;
                }
            }
           
            sw.Close();
        }
    }
}
