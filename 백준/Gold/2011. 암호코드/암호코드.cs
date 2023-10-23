using System;
using System.Collections.Generic;
namespace Dynamic
{
    
    class BOJ_2011
    {
        static int[] d = new int[5005];
        static void Main(string[] args)
        {
            string inputarr = Console.ReadLine();
            int[] arr = new int[5005];
            for (int i = 1; i <= inputarr.Length; i++)
                arr[i] = inputarr[i - 1] - '0';

            d[0] = 1;
            for (int i = 1; i <= inputarr.Length; i++)
            {
                if (arr[i] > 0)
                    d[i] =  d[i - 1] % 1000000;
                int x = arr[i - 1] * 10 + arr[i];
                if (x >= 10 && x <= 26)
                    d[i] = (d[i] + d[i - 2]) % 1000000;
            }
            Console.WriteLine(d[inputarr.Length]);
        }
    }
    
}
