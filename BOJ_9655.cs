using System;
namespace Dynamic
{
    
    class BOJ_9655
    {
        static int[,] d = new int[1005, 5];
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if(n % 2 == 1)
                Console.WriteLine("SK");
            else
                Console.WriteLine("CY");
        }
    }
    
}
