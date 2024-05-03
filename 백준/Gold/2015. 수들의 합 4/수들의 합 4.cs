// BOJ_2015



int[] inputnk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnk[0];
int k = inputnk[1];

long[] inputArr = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
long[] dp = new long[200005];
dp[0] = inputArr[0];
long ans = 0;
Dictionary<long, long> dict = new Dictionary<long, long>();
for (int i = 1; i < n; i++)
{
    dp[i] = dp[i - 1] + inputArr[i];
}

for (int i = 0; i < n; i++)
{
    if (dp[i] == k)
        ans++;

    ans += dict.GetValueOrDefault(dp[i] - k);

    if (!dict.ContainsKey(dp[i]))
        dict.Add(dp[i], 1);
    else
        dict[dp[i]]++;
}

Console.WriteLine(ans);