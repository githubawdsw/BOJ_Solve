// BOJ_21317


int n = int.Parse(Console.ReadLine());
List<(int, int)> list = new();
list.Add((0, 0));
for (int i = 0; i < n - 1; i++)
{
    int[] inputJumpEnerge = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int smallJump = inputJumpEnerge[0];
    int bigJump = inputJumpEnerge[1];
    list.Add((smallJump, bigJump));
}
int k = int.Parse(Console.ReadLine());

int[,] dp = new int[25, 2];
if(n > 1)
{
    dp[2, 0] = list[1].Item1;
    dp[2, 1] = int.MaxValue / 2;
    if(n > 2)
    {
        dp[3, 0] = Math.Min(list[1].Item2, dp[2, 0] + list[2].Item1);
        dp[3, 1] = int.MaxValue / 2;
    }

}
for (int i = 4; i <= n; i++)
{
    dp[i, 0] = Math.Min( dp[i - 2, 0] + list[i - 2].Item2, dp[i - 1, 0] + list[i - 1].Item1);
    dp[i, 1] = Math.Min(dp[i - 3, 0] + k, dp[i - 2, 1] + list[i - 2].Item2);
    dp[i, 1] = Math.Min(dp[i, 1], dp[i - 1, 1] + list[i - 1].Item1);

   
}

Console.WriteLine(Math.Min(dp[n, 0], dp[n, 1]));
