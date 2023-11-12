// BOJ_5800


using System.Text;

StringBuilder sb= new StringBuilder();
int k = int.Parse(Console.ReadLine());
for (int i = 0; i < k; i++)
{
    int[] inputnArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int n = inputnArr[0];
    Array.Sort(inputnArr, 1, n);

    int sub = 0;
    for (int j = 2; j <= n; j++)
    {
        sub = Math.Max(inputnArr[j] - inputnArr[j - 1], sub);
    }
    sb.AppendLine($"Class {i + 1}");
    sb.AppendLine($"Max {inputnArr[n]}, Min {inputnArr[1]}, Largest gap {sub}");
}

Console.WriteLine(sb);
