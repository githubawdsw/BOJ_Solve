// BOJ_13900


int n = int.Parse(Console.ReadLine());
string[] inputarr = Console.ReadLine().Split(' ');

long ans = 0;
long[] dp = new long[100005];

for (int i = n - 1; i > 0; i--)
	dp[i] = dp[i + 1] + long.Parse(inputarr[i]);

for (int i = 1; i < n; i++)
	ans += dp[i] * long.Parse(inputarr[i - 1]);


Console.WriteLine(	ans);
