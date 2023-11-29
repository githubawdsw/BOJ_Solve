// BOJ_2169



int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

int[,,] dp = new int[n+5, m+5 , 3];
int[,] board = new int[n+5, m+5];
bool[,] vis = new bool[n + 5, m + 5];
int[] dx = { 0, 0, 1 };
int[] dy = { 1, -1, 0 };


for (int i = 1; i <= n; i++)
{
	int[] inputinfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    for (int j = 1; j <= m; j++)
	{
		board[i, j] = inputinfo[j - 1];
		dp[i, j, 0] = int.MinValue / 2;
        dp[i, j, 1] = int.MinValue / 2;
        dp[i, j, 2] = int.MinValue / 2;
    }
}

Console.WriteLine(solve(1,1,0));


int solve(int x, int y ,int dir)
{
	if (x == n && y == m)
		return board[x, y];
	if (dp[x, y, dir] != int.MinValue / 2)
		return dp[x, y, dir];

	vis[x, y] = true;
	int max = int.MinValue / 2;
	for (int i = 0; i < 3; i++)
	{
		int nx = x + dx[i];
		int ny = y + dy[i];
		if(nx > 0 && ny > 0 && nx <= n && ny <= m)
		{
			if (!vis[nx, ny])
				max = Math.Max(max, solve(nx, ny, i));
		}
	}
	vis[x, y] = false;
	dp[x, y, dir] = board[x, y] + max;
	return dp[x, y, dir];
}