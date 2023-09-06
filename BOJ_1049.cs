using System;

namespace GreedyAlgorithm
{
    
    class BOJ_1049
    {
        static void Main(string[] args)
        {
            string[] inputnm = Console.ReadLine().Split(' ');
            int n = int.Parse(inputnm[0]);
            int m = int.Parse(inputnm[1]);

            int minp = int.MaxValue;
            int mine = int.MaxValue;
            int cost = 0;

            for (int i = 0; i < m; i++)
            {
                string[] inputcost = Console.ReadLine().Split(' ');
                int package = int.Parse(inputcost[0]);
                int each = int.Parse(inputcost[1]);
                minp = Math.Min(minp, package);
                mine = Math.Min(mine, each);
            }

            if(n > 6)
            {
                if (minp < mine * 6)
                    cost += minp * (n / 6);
                else
                    cost += mine * 6 * (n / 6);
                n %= 6;
            }
            if (mine * n > minp)
                cost += minp;
            else
                cost += mine * n;
            Console.WriteLine(  cost);
        }
    }
    
}
