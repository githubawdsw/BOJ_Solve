using System;
using System.Collections.Generic;
using System.Text;
namespace BFS_DFS_Reculsive
{
    class Recursion_1074
    {
        static int N , r, c;
       
        static void Main(string[] args)
        {
            string[] inputValue = Console.ReadLine().Split(" ");
            N = int.Parse(inputValue[0]);
            r = int.Parse(inputValue[1]);
            c = int.Parse(inputValue[2]);
            
            int ans = reculsion(N,r,c);
            Console.WriteLine(ans);
        }
        static int reculsion(int n, int r, int c)
        {
            if(n == 0)
                return 0;
            int k = 1;
            for (int i = 0; i < n-1; i++)
                k *= 2;
            if (r < k && c < k)
                return reculsion(n - 1, r, c);
            if (r < k && c >= k)
                return k*k + reculsion(n - 1, r, c - k);
            if (r >= k && c < k)
                return 2*k*k +reculsion(n - 1, r - k, c);
            return 3 * k * k + reculsion(n - 1, r - k, c - k);
        }
    }
}
