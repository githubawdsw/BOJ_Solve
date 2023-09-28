using System;
using System.Text;
namespace Back_Tracking
{
    class Sum_Of_Subsequence_1182
    {
        static int n, s;
        static int count = 0;
        static int[] convert = new int[21];

        static void Main(string[] args)
        {
            string[] inputvalue = Console.ReadLine().Split(" ");
            n = int.Parse(inputvalue[0]);
            s = int.Parse(inputvalue[1]);

            string[]  intvalue = Console.ReadLine().Split(" ");
            for (int i = 0; i < n; i++)
            {
                convert[i] = int.Parse(intvalue[i]);
            }

            reculsive(0 , 0);

            if (s == 0)
                count--;
            
            Console.WriteLine(count);
        }

        public static void reculsive(int _reci, int sum)
        {
            if (_reci == n)
            {
                if(sum == s)
                    count++;

                return;
            }
            reculsive(_reci + 1, sum);
            reculsive(_reci + 1, sum + convert[_reci]);
        }
    }
}
