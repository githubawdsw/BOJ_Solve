using System;

namespace GreedyAlgorithm
{
    
    class BOJ_2828
    {
        static void Main(string[] args)
        {
            string[] inputnm = Console.ReadLine().Split(' ');
            int n = int.Parse(inputnm[0]);
            int m = int.Parse(inputnm[1]);

            int left = 1;
            int right = m;
            int ans = 0;

            int j = int.Parse(Console.ReadLine());
            for (int i = 0; i < j; i++)
            {
                int inputval = int.Parse(Console.ReadLine());
                if (inputval <= right && inputval >= left)
                    continue;
                else if(inputval > right)
                {
                    int dis = inputval - right;
                    left += dis;
                    right += dis;
                    ans += dis;
                }
                else if(inputval < left)
                {
                    int dis = left - inputval;
                    left -= dis;
                    right -= dis;
                    ans += dis;
                }
            }

            Console.WriteLine(  ans );
        }
    }
    
}
