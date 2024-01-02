// BOJ_1660


int n = int.Parse(Console.ReadLine());

int[] triangle = new int[300005];
int[] dp = new int[300005];
for (int i = 1; i < 30005; i++)
{
    int value = triangle[i - 1] + (i * (i + 1) / 2);
    triangle[i] = value;
    if (value > n)
    {
		break;
    }
}

for (int i = 1; i <= n + 1; i++)
{
    dp[i] = i;
    for (int j = 1; j < triangle.Length; j++)
    {
        if (triangle[j] == i)
        {
            dp[i] = 1;
            break;
        }
        else if (triangle[j] > i)
            break;
        dp[i] = Math.Min(dp[i], 1 + dp[i - triangle[j]]);
    }
}

Console.WriteLine(dp[n]);