// BOJ_9009


using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());

long[] dp = new long[500];
dp[1] = 1;
long idx = 2;
while (dp[idx - 2] + dp[idx - 1] <= 2000000000)
{
    dp[idx] = dp[idx - 2] + dp[idx - 1];
    idx++;
}

while (t-- > 0)
{
    long n = long.Parse(Console.ReadLine());

    SortedSet<long> ss = new SortedSet<long>();
    int pos = 0;
    while (dp[pos] <= n)
    {
        pos++;
    }

    ss.Add(dp[--pos]);
    n -= dp[pos];
    while (pos > 0)
    {
        if (dp[pos] <= n)
        {
            ss.Add(dp[pos]);
            n -= dp[pos];
        }
        pos--;
    }
    foreach (var one in ss)
    {
        sb.Append(one.ToString() + " ");
    }
    sb.AppendLine();
}

Console.WriteLine(sb);
