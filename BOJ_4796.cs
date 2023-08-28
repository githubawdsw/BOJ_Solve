using System;
namespace MathAlgorithm
{
    
    class BOJ_4796
    {
        static void Main(string[] args)
        {
            int l = 1, p = 1, v = 1;
            string[] inputarr;

            int count = 0;
            while (true)
            {
                count++;
                inputarr = Console.ReadLine().Split(' ');
                l = int.Parse(inputarr[0]);
                p = int.Parse(inputarr[1]);
                v = int.Parse(inputarr[2]);

                if (l == 0 && p == 0 && v == 0)
                    break;
                long share = v / p;
                long remain = v % p;

                Console.WriteLine($"Case {count}: {(share * l )+ ((remain > l) ? l : remain) }");
            }

        }
    }
    
}
