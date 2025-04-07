// BOJ_3933


using System.Text;

StringBuilder sb = new StringBuilder();

int[,] dp = new int[33000,5];
for (int i = 1; i * i < dp.GetLength(0); i++)
{
    dp[i * i, 1] = 1;
    for (int j = i * i; j < dp.GetLength(0); j++)
    {
        dp[j, 2] += dp[j - i * i, 1];
        dp[j, 3] += dp[j - i * i, 2];
        dp[j, 4] += dp[j - i * i, 3];
    }
}
while (true)
{
    int input = int.Parse(Console.ReadLine());

    if (input == 0)
        break;

    int sum = 0;
    for (int i = 0; i < 4; i++)
    {
        sum += dp[input, i + 1];
    }
    sb.AppendLine(sum.ToString());
}

Console.WriteLine(sb);