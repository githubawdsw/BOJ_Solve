// BOJ_2458


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

bool[,] dp = new bool[505, 505];

for (int i = 0; i < m; i++)
{
    int[] inputab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int a = inputab[0];
    int b = inputab[1];
    dp[a, b] = true;
}


for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= n; j++)
    {
        for (int k = 1; k <= n; k++)
        {
            if (dp[j, i] && dp[i, k])
                dp[j, k] = true;
        }
    }
}

int ans = 0;
for (int i = 1; i <= n; i++)
{
    int count = 0;
    for (int j = 1; j <= n; j++)
    {
        if (dp[i, j] || dp[j, i])
            count++;
    }
    if (count == n - 1)
        ans++;
}

Console.WriteLine(ans);