// BOJ_10025



string[] inputnk = Console.ReadLine().Split(' ');
int n = int.Parse(inputnk[0]);
int k = int.Parse(inputnk[1]);

int[] info = new int[1000005];
for (int i = 0; i < n; i++)
{
    string[] inputgx = Console.ReadLine().Split(' ');
    int g = int.Parse(inputgx[0]);
    int x = int.Parse(inputgx[1]);
    info[x] = g;
}

long[] dp = new long[1000005];
dp[0] = info[0];
for (int i = 1; i <= 1000000; i++)
    dp[i] = dp[i - 1] + info[i];

if (2 * k > info.Length)
{
    Console.WriteLine(  dp.Max());
    return;
}

long ans = dp[2 * k];
for (int i = 2 * k + 1; i < info.Length; i++)
    ans = Math.Max(ans, dp[i] - dp[i - (2 * k + 1)]);

Console.WriteLine(ans);

