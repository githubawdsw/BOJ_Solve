using System;

namespace MathAlgorithm
{
    
    class BOJ_2839
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            while (n >= 0)
            {
                if (n % 5 == 0)
                {
                    count += n / 5;
                    Console.WriteLine(count);
                    return;
                }
                
                n -= 3;
                count++;
                
            }
            Console.WriteLine(-1);
            
        }
    }
    
}
