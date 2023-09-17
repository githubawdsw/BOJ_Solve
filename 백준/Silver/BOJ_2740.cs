using System;
using System.Text;

namespace MathAlgorithm
{
    
    class BOJ_2740
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string[] inputnm = Console.ReadLine().Split(' ');
            int n = int.Parse(inputnm[0]);
            int m = int.Parse(inputnm[1]);

            int[,] aMatrix = new int[105, 105];
            int[,] bMatrix = new int[105, 105];
            int[,] ans = new int[105, 105];
            for (int i = 0; i < n; i++)
            {
                string[] inputA = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                    aMatrix[i, j] = int.Parse(inputA[j]);
            }
            string[] inputmk = Console.ReadLine().Split(' ');
            int k = int.Parse(inputmk[1]);
            for (int i = 0; i < m; i++)
            {
                string[] inputB = Console.ReadLine().Split(' ');
                for (int j = 0; j < k; j++)
                    bMatrix[i, j] = int.Parse(inputB[j]);
            }
            for (int i = 0; i < n; i++)
                for (int h = 0; h < k; h++)
                {
                    int sum = 0;
                    for (int j = 0; j < m; j++)
                        sum += aMatrix[i, j] * bMatrix[j, h];
                    ans[i, h] = sum;
                }
            for (int i = 0; i < n; i++)
            {
                for (int j  = 0; j < k; j++)
                    sb.Append($"{ans[i,j]} " );
                sb.Append('\n');
            }

            Console.WriteLine(  sb);
        }
    }
    
}
