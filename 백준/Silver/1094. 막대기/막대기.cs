using System;

namespace MathAlgorithm
{
    
    class BOJ_1094
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int stick = 64;
            int sum = 0;
            int count = 1;

            while (stick >= 1)
            {
                if(x == stick )
                {
                    Console.WriteLine(  1 );
                    return;
                }
                else if (x == sum)
                {
                    Console.WriteLine(  count - 1 );
                    return;
                }

                stick /= 2;
                if(sum + stick <= x)
                {
                    sum += stick;
                    count++;
                }
            }
            
        }
    }
    
}
