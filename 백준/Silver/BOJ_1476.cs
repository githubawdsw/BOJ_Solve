using System;
namespace MathAlgorithm
{
    
    class BOJ_1476
    {
        static void Main(string[] args)
        {
            string[] inputESM = Console.ReadLine().Split(' ');
            int E = int.Parse(inputESM[0]);
            int S = int.Parse(inputESM[1]);
            int M = int.Parse(inputESM[2]);

            int ans = 1;
            while (true)
            {
                if ((ans - E) % 15 == 0 && (ans - S) % 28 == 0 && (ans - M) % 19 == 0)
                    break;
                ans++;
            }
            Console.WriteLine(ans);
        }
    }
    
}
