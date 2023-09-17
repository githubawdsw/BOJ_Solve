using System;
using System.Text;
namespace MathAlgorithm
{
    
    class BOJ_11653
    {
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int divide = 2;
            
            while (n != 1)
            {
                if (n % divide == 0)
                {
                    n /= divide;
                    sb.AppendLine(divide.ToString());
                }
                else
                    divide++;
                if (divide * divide > n)
                    break;
            }
            if(n != 1)
                sb.AppendLine(n.ToString());
            Console.WriteLine(sb);
        }
    }
    
}
