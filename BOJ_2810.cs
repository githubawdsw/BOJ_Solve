using System;
namespace GreedyAlgorithm
{
    
    class BOJ_2810
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();

            int count = 0;
            for (int i = 0; i < n; i++)
                if (str[i] == 'L')
                {
                    count++;
                    i++;
                }

            if(count == 0)
                Console.WriteLine(n);
            else
                Console.WriteLine( n - count + 1 );
        }
    }
    
}
