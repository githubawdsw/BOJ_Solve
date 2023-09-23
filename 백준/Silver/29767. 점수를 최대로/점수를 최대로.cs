// BOJ_29767


string[] inputnk = Console.ReadLine().Split(' ');
int n = int.Parse(inputnk[0]);
int k = int.Parse(inputnk[1]);
string[] inputAn = Console.ReadLine().Split(" ");

long[] dp = new long[300005];
List<long> list = new List<long>();
for (int i = 1; i <= n; i++)
{
    dp[i] = dp[i - 1] + long.Parse(inputAn[i - 1]);
    list.Add(dp[i]);
}

list = list.OrderByDescending(x => x).ToList();
long ans = 0;
for (int i = 0; i < k; i++)
    ans += list[i];

Console.WriteLine(ans );