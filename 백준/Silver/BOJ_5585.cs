using System;
namespace GreedyAlgorithm
{
    
    class BOJ_5585
    {
        static void Main(string[] args)
        {
            int count = 0;
            int cost = int.Parse(Console.ReadLine());
            cost = 1000 - cost;

            count += cost / 500;
            cost %= 500;
            count += cost / 100;
            cost %= 100;
            count += cost / 50;
            cost %= 50;
            count += cost / 10;
            cost %= 10;
            count += cost / 5;
            cost %= 5;
            count += cost;

            Console.WriteLine(  count );
        }
    }
    
}
