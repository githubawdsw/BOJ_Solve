using System;

namespace MathAlgorithm
{
    
    class BOJ_1790
    {
        static void Main(string[] args)
        {
            string[] inputnk = Console.ReadLine().Split(' ');
            long n = long.Parse(inputnk[0]);
            long k = long.Parse(inputnk[1]);

            long len = 1;
            long sub = 1;
            while (k > 9 * len * sub)
            {
                k -= 9 * len * sub;
                sub *= 10;
                len++;
            }

            string ans = "";
            ans = (sub + (k - 1) / len).ToString();

            if(int.Parse(ans) > n)
                Console.WriteLine(-1);
            else
                Console.WriteLine(  ans [(int)((k-1) % len)]);


        }
    }
    
}
