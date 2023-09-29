using System;
namespace GreedyAlgorithm
{
    
    class BOJ_1541
    {
        static void Main(string[] args)
        {
            string inputarr = Console.ReadLine();
            int ans = 0;
            int temp = 0;
            int sign = 1;
            foreach (var ch in inputarr)
            {
                if(ch == '+' || ch == '-')
                {
                    ans += temp * sign;
                    if (ch == '-')
                        sign = -1;
                    temp = 0;
                }
                else
                {
                    temp *= 10;
                    temp += ch - '0';
                }
            }
            ans += temp * sign;
            Console.WriteLine(ans);
        }
    }
    
}
