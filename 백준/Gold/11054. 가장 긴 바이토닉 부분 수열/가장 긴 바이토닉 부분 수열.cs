using System;

namespace Dynamic
{
    
    class BOJ_11054
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] inputseq = Console.ReadLine().Split(' ');
            int[] dp1 = new int[1005];
            int[] dp2 = new int[1005];
            for (int i = 0; i < n; i++)
                dp1[i] = 1;
            for (int i = 0; i < inputseq.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    int standard = int.Parse(inputseq[i]);
                    int compare = int.Parse(inputseq[j]);
                    if (compare < standard)
                        dp1[i] = Math.Max(dp1[i], dp1[j] + 1);
                }
            }

            for (int i = inputseq.Length - 1; i >= 0; i--)
            {
                for (int j = inputseq.Length - 1; j >= i; j--)
                {
                    int standard = int.Parse(inputseq[i]);
                    int compare = int.Parse(inputseq[j]);
                    if (compare < standard)
                        dp2[i] = Math.Max(dp2[i], dp2[j] + 1);
                }
            }

            int ans = 0;
            for (int i = 0; i < inputseq.Length; i++)
                ans = Math.Max(dp1[i] + dp2[i], ans);

            Console.WriteLine( ans );
        }
    }
    
}
