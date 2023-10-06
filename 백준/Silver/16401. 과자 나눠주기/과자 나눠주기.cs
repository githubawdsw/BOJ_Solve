using System;
using System.Collections.Generic;
namespace Binary_Search
{
    
    class BOJ_16401
    {
        static void Main(string[] args)
        {
            string[] mn = Console.ReadLine().Split(' ');
            int m = int.Parse(mn[0]);
            int n = int.Parse(mn[1]);
            string[] ninput = Console.ReadLine().Split(' ');
            List<int> snackbar = new List<int>();
            for (int i = 0; i < n; i++)
                snackbar.Add(int.Parse(ninput[i]));

            snackbar.Sort();
            int start = 1;
            int end = snackbar[ n-1];
            while (start <= end)
            {
                int mid = (start + end) / 2;
                long count = 0;
                for (int i = 0; i < n; i++)
                    count += snackbar[i] / mid;

                if (mid == 0 || count >= m)
                    start = mid + 1;
                else
                    end = mid - 1;
            }
            Console.WriteLine(end);
        }
    }
    
}
