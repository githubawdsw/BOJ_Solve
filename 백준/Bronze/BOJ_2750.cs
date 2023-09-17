using System;
using System.Text;

namespace Sorting
{
    
    class BOJ_2750
    {
        static int n;
        static int[] inputArr;
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            inputArr = new int[n];
            for (int i = 0; i < n; i++)
            {
                inputArr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n-1; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if(inputArr[j] < inputArr[i])
                    {
                        int temp = inputArr[i];
                        inputArr[i] = inputArr[j];
                        inputArr[j] = temp;
                    }    
                }
            }
            for (int i = 0; i < n; i++)
            {
                sb.AppendLine(inputArr[i].ToString());
            }
            Console.WriteLine(sb);
        }
    }

}
