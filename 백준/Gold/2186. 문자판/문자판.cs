// BOJ_2186


int[] inputnmk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnmk[0];
int m = inputnmk[1];
int k = inputnmk[2];

char[,] board = new char[105, 105];
int[,,] dp = new int[105, 105, 85];
int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };
int ans = 0;

for (int i = 0; i < n; i++)
{
	string inputWord = Console.ReadLine();
	for (int j = 0; j < m; j++)
	{
		board[i, j] = inputWord[j];
		for (int l = 0; l <= 80; l++)
		{
			dp[i, j, l] = -1;
		}
	}
}

string str = Console.ReadLine();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
		if (str[0] == board[i, j])
			ans += Dfs(i, j, 0);
    }
}

Console.WriteLine(ans);


int Dfs(int x, int y , int length)
{
	if(length == str.Length - 1)
	{
		return 1;
	}

	if (dp[x, y, length] != -1)
		return dp[x, y, length];

    dp[x, y, length] = 0;

	for (int i = 0; i < 4; i++)
	{
		for (int j = 1; j <= k; j++)
		{
			int nx = x + dx[i] * j;
			int ny = y + dy[i] * j;
			if (nx < 0 || ny < 0 || nx >= n || ny >= m)
				continue;

			if (board[nx, ny] == str[length + 1])
				dp[x, y, length] += Dfs(nx, ny, length + 1);
		}
	}
	return dp[x, y, length];
}
