// BOJ_18290


int[] inputnmk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnmk[0];
int m = inputnmk[1];
int k = inputnmk[2];

int[,] board = new int[11, 11];
int[,] vis = new int[11, 11];
for (int i = 0; i < n; i++)
{
    int[] inputInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    for (int j = 0; j < m; j++)
	{
        board[i, j] = inputInfo[j];
	}
}

int ans = -40001;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Dfs(1, board[i, j], i, j);

        vis[i, j]--;
        if (i - 1 >= 0)
            vis[i - 1, j]--;
        if (i + 1 < n)
            vis[i + 1, j]--;
        if (j - 1 >= 0)
            vis[i, j - 1]--;
        if (j + 1 < m)
            vis[i, j + 1]--;
    }
}
Console.WriteLine(ans);


void Dfs(int depth, int sum, int x, int y)
{
    vis[x, y]++;
    if (x - 1 >= 0)
        vis[x - 1, y]++;
    if (x + 1 < n)
        vis[x + 1, y]++;
    if (y - 1 >= 0)
        vis[x, y - 1]++;
    if (y + 1 < m)
        vis[x, y + 1]++;

    if(depth == k)
    {
        ans = Math.Max(ans, sum);
        return;
    }

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            if (vis[i, j] == 0)
            {
                Dfs(depth + 1, sum + board[i, j], i, j);

                vis[i, j]--;
                if (i - 1 >= 0)
                    vis[i - 1, j]--;
                if (i + 1 < n)
                    vis[i + 1, j]--;
                if (j - 1 >= 0)
                    vis[i, j - 1]--;
                if (j + 1 < m)
                    vis[i, j + 1]--;
            }
        }
    }
}