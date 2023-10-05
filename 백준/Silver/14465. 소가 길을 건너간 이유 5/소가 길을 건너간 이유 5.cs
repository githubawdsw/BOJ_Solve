// BOJ_14465


string[] inputnkb = Console.ReadLine().Split(' ');  
int n  = int.Parse(inputnkb[0]);
int k = int.Parse(inputnkb[1]);
int b = int.Parse(inputnkb[2]);

int[] nArr = new int[ 100005];
int[] dp = new int[100005];

for (int i = 1; i <= n; i++)
    nArr[i] = 1;

for (int i = 0; i < b; i++)
{
    int inputError = int.Parse(Console.ReadLine());
    nArr[inputError] = 0;
}

for (int i = 1; i <= k; i++)
{
    if (nArr[i] == 1)
        dp[i] = 1;
    dp[i] += dp[i - 1];
}

for (int i = k + 1; i <= n; i++)
    dp[i] = dp[i - 1] + nArr[i] - nArr[i - k];

int ans = k - dp.Max();
Console.WriteLine(  ans );