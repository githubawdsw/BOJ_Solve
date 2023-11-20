using System;
using System.Collections.Generic;

namespace GreedyAlgorithm
{
    
    class BOJ_16120
    {
        static Queue<char> q = new Queue<char>();
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int pcount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'P')
                    pcount++;
                else
                {
                    if (pcount >= 2 && i+1 < input.Length && input[i+1] == 'P')
                    {
                        pcount--;
                        i++;
                    }
                    else
                    {
                        Console.WriteLine(  "NP");
                        return;
                    }
                }
            }
            if (pcount == 1)
                Console.WriteLine("PPAP");
            else
                Console.WriteLine("NP");
        }
    }
    
}
