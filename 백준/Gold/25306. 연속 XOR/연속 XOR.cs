using System;
namespace Baekjoon1
{

    class BOJ_25306
    {
        static void Main(string[] args)
        {
            string[] inputAB = Console.ReadLine().Split(' ');
            long A = long.Parse(inputAB[0]);
            long B = long.Parse(inputAB[1]);

            if ((A - 1) % 4 == 0)
                A = A - 1;
            else if ((A - 1) % 4 == 1)
                A = 1;
            else if ((A - 1) % 4 == 3)
                A = 0;

            if (B % 4 == 1)
                B = 1;
            else if (B % 4 == 2)
                B = B + 1;
            else if (B % 4 == 3)
                B = 0;
            Console.WriteLine(A ^ B);
        }
    }

}
