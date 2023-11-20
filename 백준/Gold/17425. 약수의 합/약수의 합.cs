// BOJ_17425



using System.Text;

StringBuilder sb= new StringBuilder();
int t = int.Parse(Console.ReadLine());

long[] dp = new long[1000005];
for (int i = 1; i <= 1000000; i++)
{
    for (int j = i; j <= 1000000; j += i)
        dp[j] += i;
    dp[i] += dp[i - 1];
}

for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine());
    sb.AppendLine(dp[n].ToString());
}

Console.WriteLine(sb);

