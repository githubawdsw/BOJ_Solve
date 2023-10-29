// BOJ_5582


string baseStr = Console.ReadLine();
string compareStr = Console.ReadLine();

int[,] dp = new int[4005, 4005];
int ans = 0;
for (int i = 0; i < baseStr.Length; i++)
{
    for (int j = 0; j < compareStr.Length; j++)
    {
        if (baseStr[i] == compareStr[j])
        {
            dp[i + 1, j + 1] = dp[i, j] + 1;
            ans = Math.Max(dp[i + 1, j + 1], ans);
        }
    }
}
Console.WriteLine(  ans);
