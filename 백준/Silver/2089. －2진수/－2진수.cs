using System;
using System.Linq;

namespace MathAlgorithm
{
    
    class BOJ_2089
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string ans = "";

            if (n == 0)
                ans += "0";

            while (n!=0)
            {
                if(n < 0)
                {
                    if(-n % 2 == 0)
                    {
                        ans += "0";
                        n = -n / 2;
                    }
                    else
                    {
                        ans += "1";
                        n = -(n - 1) / 2;
                    }
                }
                else
                {
                    ans += (n %2).ToString();
                    n = -n / 2;
                }
            }
            char[] re = ans.Reverse().ToArray();
            Console.WriteLine(re);
        }
    }
    
}
