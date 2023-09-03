using System;
namespace GreedyAlgorithm
{
    
    class BOJ_2864
    {
        static void Main(string[] args)
        {
            string[] inputab = Console.ReadLine().Split(' ');
            string a = inputab[0];
            string b = inputab[1];

            a = a.Replace('5', '6');
            b = b.Replace('5', '6');
            int max = int.Parse(a) + int.Parse(b);

            a = a.Replace('6', '5');
            b = b.Replace('6', '5');
            int min = int.Parse(a) + int.Parse(b);

            Console.WriteLine(  $"{min} {max}");
        }
    }
    
}
