using System;

namespace MathAlgorithm
{
    
    class BOJ_1145
    {
        static void Main(string[] args)
        {
            string[] inputarr = Console.ReadLine().Split(' ');

            int num = 1;
            while (true)
            {
                int count = 0;
                for (int i = 0; i < inputarr.Length; i++)
                {
                    if (num >= int.Parse(inputarr[i]) && num % int.Parse(inputarr[i]) == 0)
                        count++;
                }
                if (count >= 3)
                {
                    Console.WriteLine(  num);
                    break;
                }
                num++;
            }
        }

    }
    
}
