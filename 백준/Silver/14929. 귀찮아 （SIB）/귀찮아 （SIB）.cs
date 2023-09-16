// BOJ_14929


int n = int.Parse(Console.ReadLine());
string[] inputarr = Console.ReadLine().Split(' ');

long[] dp = new long[100005];
dp[0] = int.Parse(inputarr[0]);
for (int i = 1; i < n; i++)
    dp[i] = dp[i - 1] + int.Parse(inputarr[i]);

long ans = 0;
for (int i = 0; i < n-1; i++)
    ans += (dp[n - 1] - dp[i]) * int.Parse(inputarr[i]);

Console.WriteLine(  ans );
