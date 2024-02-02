// BOJ_2670


int n = int.Parse(Console.ReadLine());
List<double> list = new List<double>();
double[] dp = new double[10005];
for (int i = 0; i < n; i++)
{
    double inputValue = double.Parse(Console.ReadLine());
    list.Add(inputValue);
    dp[i] = list[i];
}

for (int i = 1; i < n; i++)
{
    dp[i] = Math.Max(dp[i - 1] * list[i], dp[i]);
}

double ans = 0;
for (int i = 0; i < n; i++)
{
    ans = Math.Max(ans, dp[i]);
}

Console.WriteLine(ans.ToString("0.000"));
