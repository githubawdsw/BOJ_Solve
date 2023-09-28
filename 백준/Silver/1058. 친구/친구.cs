// BOJ_1058


int n = int.Parse(Console.ReadLine());

int[][] dp = new int[55][];	
for (int i = 0;i < n; i++)
{
	dp[i] = new int[55];
    Array.Fill(dp[i], int.MaxValue / 2);
    dp[i][i] = 0;
}

for (int i = 0; i < n; i++)
{
    string inputrel = Console.ReadLine();
    for (int j = 0; j < n; j++)
        if (inputrel[j] == 'Y')
            dp[i][j] = 1;
}


for (int i = 0; i < n; i++)
    for (int j = 0; j < n; j++)
        for (int k = 0; k < n; k++)
            if (dp[j][k] > dp[j][i] + dp[i][k])
                dp[j][k] = dp[j][i] + dp[i][k];


int ans = 0;

for (int i = 0; i < n; i++)
{
    int count = 0;
    for (int j = 0; j < n; j++)
    {
        if (i != j && dp[i][j] <= 2)
            count++;
    }
    ans = Math.Max(count , ans);
}


Console.WriteLine(  ans );

