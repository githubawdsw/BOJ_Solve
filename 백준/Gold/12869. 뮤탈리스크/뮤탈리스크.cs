// BOJ_12869


int n = int.Parse(Console.ReadLine());
int[] inputHealth = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int[,,] dp = new int[80, 80, 80];
int[] abc = { 0, 0, 0 };
for (int i = 0; i < n; i++)
{
    abc[i] = inputHealth[i];
}

for (int i = 0; i < 61; i++)
{
    for (int j = 0; j < 61; j++)
    {
        for (int k = 0; k < 61; k++)
        {
            dp[i, j, k] = -1;
        }
    }
}

dp[0, 0, 0] = 0;

Console.WriteLine(Solve(abc[0], abc[1], abc[2]));



int Solve(int a, int b, int c)
{
    a = Math.Max(a, 0);
    b = Math.Max(b, 0);
    c = Math.Max(c, 0);

    if (dp[a, b, c] != -1)
        return dp[a, b, c];

    dp[a, b, c] = Math.Min(Solve(a - 9, b - 3, c - 1), Solve(a - 9, b - 1, c - 3)) + 1;
    dp[a, b, c] = Math.Min(dp[a, b, c], Solve(a - 3, b - 9, c - 1) + 1);
    dp[a, b, c] = Math.Min(dp[a, b, c], Solve(a - 3, b - 1, c - 9) + 1);
    dp[a, b, c] = Math.Min(dp[a, b, c], Solve(a - 1, b - 3, c - 9) + 1);
    dp[a, b, c] = Math.Min(dp[a, b, c], Solve(a - 1, b - 9, c - 3) + 1);
            
    return dp[a, b, c];
}