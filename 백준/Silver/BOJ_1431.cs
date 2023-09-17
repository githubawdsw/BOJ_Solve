using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    
    class BOJ_1431
    {
        static int N;
        static List<string> inputArr = new List<string>();
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string inputValue = Console.ReadLine();
                inputArr.Add(inputValue);
            }
            inputArr.Sort(comparesort);


            for (int i = 0; i < N; i++)
                sb.AppendLine(inputArr[i]);
            
            Console.Write(sb);
        }

        static int comparesort(string x, string y)
        {
            int xlen = x.Length;
            int ylen = y.Length;
            int xsum = 0;
            int ysum = 0;
            if (xlen != ylen)
                return xlen.CompareTo(ylen);
            for (int i = 0; i < xlen; i++)
            {
                if (x[i] >= '0' && x[i] <= '9')
                    xsum += x[i] - '0';
                if (y[i] >= '0' && y[i] <= '9')
                    ysum += y[i] - '0';
            }
            if (xsum != ysum)
                return xsum.CompareTo(ysum);
            return x.CompareTo(y);
        }
    }
    
}
