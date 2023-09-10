using System;

namespace MathAlgorithm
{
    
    class BOJ_10610
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();

            char[] c = n.ToCharArray();
            Array.Sort(c);

            if (c[0] != '0')
            {
                Console.WriteLine(-1);
                return;
            }

            int checkthree = 0;
            for (int i = 1; i < c.Length; i++)
                checkthree += c[i] - '0';
            if(checkthree % 3 != 0)
            {
                Console.WriteLine(-1);
                return;
            }
            Array.Reverse(c);
            Console.WriteLine(c);
        }
    }
    
}
