// BOJ_18427


int[] inputnmh = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnmh[0];
int m = inputnmh[1];
int h = inputnmh[2];

Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
int[,] dp = new int[55, 1005];

for (int i = 0; i < n; i++)
{
    int[] inputBlock = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    dict.Add(i + 1, new List<int>());
    for (int j = 0; j < inputBlock.Length; j++)
    {
        dict[i + 1].Add(inputBlock[j]);
    }
    dp[i + 1, 0] = 1;
}

dp[0, 0] = 1;
for(int i = 1; i <= dict.Count; i++)
{
    for (int j = 1; j <= h; j++)
    {
        for (int k = 0; k < dict[i].Count; k++)
        {
            if (dict[i][k] <= j)
                dp[i, j] = (dp[i, j] + dp[i - 1, j - dict[i][k]]) % 10007;
        }
        dp[i, j] = (dp[i, j] + dp[i - 1, j]) % 10007;
    }
}


Console.WriteLine(dp[n, h]);