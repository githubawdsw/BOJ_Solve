// BOJ_18430


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

int[,] board = new int[7, 7];
bool[,] vis = new bool[7, 7];
int[] wingx = { 1, 0, -1, 0, 1 };
int[] wingy = { 0, 1, 0, -1, 0 };
int ans = 0;

for (int i = 0; i < n; i++)
{
	int[] inputInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
	for (int j = 0; j < m; j++)
	{
		board[i, j] = inputInfo[j];
	}
}

if (n == 1 || m == 1)
{
	Console.WriteLine(0);
	return;
}

for (int i = 0; i < n; i++)
{
	for (int j = 0; j < m; j++)
	{
		Dfs(i, j, 0);
	}
}

Console.WriteLine(ans);


void Dfs(int x, int y, int sum)
{
	if (vis[x, y])
	{
		ans = Math.Max(sum, ans);
		return;
	}

	if (x == n - 1 && y == m - 1)
	{
		if (vis[x - 1, y] || vis[x, y - 1])
            ans = Math.Max(sum, ans);
		else
			ans = Math.Max(ans, sum + (2 * board[x, y]) + board[x - 1, y] + board[x, y - 1]);
		return;
    }

	for (int i = 0; i < 4; i++)
	{
		int temp = 2 * board[x, y];
		if (x + wingx[i] < 0 || y + wingy[i] < 0 || x + wingx[i] >= n || y + wingy[i] >= m)
			continue;
        if (x + wingx[i + 1] < 0 || y + wingy[i + 1] < 0 || x + wingx[i + 1] >= n || y + wingy[i + 1] >= m)
            continue;

        if (vis[x + wingx[i], y + wingy[i]] || vis[x + wingx[i + 1], y + wingy[i + 1]])
			continue;

		temp += board[x + wingx[i], y + wingy[i]] + board[x + wingx[i + 1], y + wingy[i + 1]];
		vis[x, y] = true;
		vis[x + wingx[i], y + wingy[i]] = true;
		vis[x + wingx[i + 1], y + wingy[i + 1]] = true;

		for (int j = x; j < n; j++)
		{
			for (int k = 0; k < m; k++)
			{
				if (!vis[j,k])
					Dfs(j, k, sum + temp);
                else
                    ans = Math.Max(sum + temp, ans);
            }
		}

		vis[x, y] = false;
        vis[x + wingx[i], y + wingy[i]] = false;
        vis[x + wingx[i + 1], y + wingy[i + 1]] = false;
    }
}
