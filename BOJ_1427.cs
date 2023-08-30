using System;
using System.Linq;

namespace Sorting
{
    
    class BOJ_1427
    {
        static void Main(string[] args)
        {
            string N = Console.ReadLine();
            N = new string(N.OrderByDescending(x => x).ToArray());
            Console.WriteLine( N );
        }
    }
    
}