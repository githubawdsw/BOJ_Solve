// BOJ_10159


using System.Text;

StringBuilder sb= new StringBuilder();

int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());

bool[,] dp = new bool[105, 105];

for (int i = 0; i < m; i++)
{
    int[] inputRel = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int heavier = inputRel[0];
    int lighter = inputRel[1];

    dp[lighter, heavier] = true;
}

for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= n; j++)
    {
        for (int k = 1; k <= n; k++)
        {
            if (dp[j, i] && dp[i, k])
                dp[j, k] = true;
        }
    }
}

for (int i = 1; i <= n; i++)
{
    int count = 0;
    for (int j = 1; j <= n; j++)
    {
        if (!dp[i, j] && !dp[j, i])
            count++;
    }
    sb.AppendLine((count - 1).ToString());
}

Console.WriteLine(sb);

