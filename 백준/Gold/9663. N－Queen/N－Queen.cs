using System;
using System.Text;
namespace Back_Tracking
{
    class N_Queen_9663
    {
        static int n;

        static bool[] isused1 = new bool[40];
        static bool[] isused2 = new bool[40];
        static bool[] isused3 = new bool[40];

        static StringBuilder sb = new StringBuilder();
        static int count = 0;

        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());

            reculsive(0);
            Console.WriteLine(count);
        }

        public static void reculsive(int k)
        {
            if (k == n)
            {
                count++;
                return;
            }

            for (int i = 0; i < n; i++)
            {
                if (isused1[i] || isused2[i + k] || isused3[k - i + n - 1])
                    continue;
                
                isused1[i] = true;
                isused2[i + k] = true;
                isused3[k - i + n - 1] = true;

                reculsive(k + 1);
                isused1[i] = false;
                isused2[i + k] = false;
                isused3[k - i + n - 1] = false;
            }
        }
    }
}
