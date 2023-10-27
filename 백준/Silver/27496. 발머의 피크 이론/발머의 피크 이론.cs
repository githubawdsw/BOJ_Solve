// BOJ_27496



int[] inputnl = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnl[0];
int l = inputnl[1];

double[] inputarr = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);

double[] dp = new double[1000005];
double sum = 0;
int ans = 0;
for (int i = 0; i < l; i++)
{
    sum += inputarr[i] * 0.001;
    dp[i] = sum;
    if (sum >= 0.129 && sum <= 0.138)
        ans++;
}

for (int i = l; i < n; i++)
{
    dp[i] = Math.Round(dp[i - 1] + (inputarr[i] - inputarr[i - l]) * 0.001 , 3);
    if (dp[i] >= 0.129 && dp[i] <= 0.138)
        ans++;
}

Console.WriteLine(ans);


