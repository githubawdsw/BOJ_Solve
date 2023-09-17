using System;

namespace GreedyAlgorithm
{
    
    class BOJ_15904
    {
        static void Main(string[] args)
        {
            bool[] check = new bool[4];

            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'U')
                    check[0] = true;
                else if (input[i] == 'C' && !check[1] && check[0])
                    check[1] = true;
                else if (input[i] == 'P' && check[1] && check[0])
                    check[2] = true;
                else if (input[i] == 'C' && check[1] && check[2])
                    check[3] = true;
            }

            for (int i = 0; i < check.Length; i++)
                if (!check[i])
                {
                    Console.WriteLine("I hate UCPC");
                    return;
                }

            Console.WriteLine("I love UCPC");
        }
    }
}
