using System;
using System.Text;

namespace GreedyAlgorithm
{
    
    class BOJ_10162
    {
        static int t;
        static void Main(string[] args)
        {
            t = int.Parse(Console.ReadLine());

            int a = 300;
            int b = 60;
            int c = 10;
            StringBuilder sb = new StringBuilder();
            
            sb.Append($"{t/a} ");
            t = t % a;
            
            sb.Append($"{t / b} ");
            t = t % b;
            
            sb.Append($"{t / c} ");
            t = t % c;
            
            
            if(t > 0)
                Console.WriteLine(  -1);
            else
                Console.WriteLine(  sb);
        }
    }
    
}
