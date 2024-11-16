// BOJ_15993


using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());
int max = 0;
List<int> list = new List<int>();
for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine());
    list.Add(n);
    max = Math.Max(max, n);
}

long[,] dp = new long[100005, 3];
dp[1, 1] = 1;
dp[2, 0] = 1;
dp[2, 1] = 1;
dp[3, 0] = 2;
dp[3, 1] = 2;

for (int i = 4; i <= max; i++)
{
    dp[i, 0] += (dp[i - 1, 1] + dp[i - 2, 1] + dp[i - 3, 1]) % 1000000009;
    dp[i, 1] += (dp[i - 1, 0] + dp[i - 2, 0] + dp[i - 3, 0]) % 1000000009;
}

for(int i = 0; i < t; i++)
{
    var target = list[i];
    sb.AppendLine(dp[target, 1] + " " + dp[target, 0]);
}

Console.WriteLine(sb);