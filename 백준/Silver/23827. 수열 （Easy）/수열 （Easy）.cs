// BOJ_23827



int n = int.Parse(Console.ReadLine());
long[] arr = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);

long[] dp = new long[500005];
dp[0] = arr[0];
for (int i = 1; i < n; i++)
    dp[i] = (dp[i - 1] + arr[i]);

long ans = 0;
for (int i = 1; i < n; i++)
    ans += (dp[i - 1] * arr[i]) % 1000000007;

Console.WriteLine(ans % 1000000007);

