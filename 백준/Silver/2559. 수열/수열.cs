using System;
using System.Linq;

namespace Dynamic
{
    
    class BOJ_2559
    {
        static void Main(string[] args)
        {
            string[] inputnk = Console.ReadLine().Split(' ');
            int n = int.Parse(inputnk[0]);
            int k = int.Parse(inputnk[1]);
            string[] inputarr = Console.ReadLine().Split(' ');

            int sum = 0;
            for (int i = 0; i < k; i++)
                sum += int.Parse(inputarr[i]);

            int ans = sum;
            int start = 0;
            int end = k - 1;
            while (start < n && end < n - 1)
            {
                end++;
                sum += int.Parse(inputarr[end]) - int.Parse(inputarr[start]);
                start++;
                ans = Math.Max(ans , sum);

            }

            Console.WriteLine(  ans);
        }
    }
}
