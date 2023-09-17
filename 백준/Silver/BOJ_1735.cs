using System;
namespace MathAlgorithm
{
    
    class BOJ_1735
    {
        static void Main(string[] args)
        {
            string[] inputAB = Console.ReadLine().Split(' ');
            int A = int.Parse(inputAB[0]);
            int B = int.Parse(inputAB[1]);

            string[] inputXY = Console.ReadLine().Split(' ');
            int X = int.Parse(inputXY[0]);
            int Y = int.Parse(inputXY[1]);

            long LCM = B * Y / GCD(B, Y);
            long numerator = (A * LCM / B) + (X * LCM / Y);

            long ansGCD = GCD(LCM, numerator);
            Console.WriteLine($"{numerator / ansGCD} {LCM / ansGCD}");
        }

        static long GCD(long a, long b)
        {
            if (b == 0)
                return a;
            return GCD(b, a % b);
        }
    }
    
}
