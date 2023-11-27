using System;
using System.Collections.Generic;
using System.IO;
namespace Binary_Search
{
    
    class BOJ_7453
    {
        static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        static void Main(string[] args)
        {
            int n = int.Parse(sr.ReadLine());
            List<long> A = new List<long>();
            List<long> B = new List<long>();
            List<long> C = new List<long>();
            List<long> D = new List<long>();
            for (int i = 0; i < n; i++)
            {
                string[] inputfour = sr.ReadLine().Split(' ');
                A.Add(int.Parse(inputfour[0]));
                B.Add(int.Parse(inputfour[1]));
                C.Add(int.Parse(inputfour[2]));
                D.Add(int.Parse(inputfour[3]));
            }
            List<long> ABsum = new List<long>();
            List<long> CDsum = new List<long>();

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    ABsum.Add(A[i] + B[j]);
                    CDsum.Add(C[i] + D[j]);
                }
            ABsum.Sort();
            CDsum.Sort();
            int start = 0;
            int end = CDsum.Count - 1;
            long count = 0;
            while (start <ABsum.Count && end >= 0)
            {
                if (ABsum[start] + CDsum[end] == 0)
                {
                    long abcount = 1;
                    long cdcount = 1;
                    while(start + 1 < ABsum.Count && ABsum[start + 1] == ABsum[start])
                    {
                        abcount++;
                        start++;
                    }
                    while (end - 1 >= 0 && CDsum[end - 1] == CDsum[end])
                    {
                        cdcount++;
                        end--;
                    }
                    count += abcount * cdcount;
                }
                if (ABsum[start] + CDsum[end] >= 0 )
                    end--;
                else 
                    start++;
            }

            Console.WriteLine(count);
        }
    }    
    
}
