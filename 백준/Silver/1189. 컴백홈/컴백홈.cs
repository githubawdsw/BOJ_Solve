// BOJ_1189


int[] inputrck = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int r = inputrck[0];
int c = inputrck[1];
int k = inputrck[2];

char[,] board = new char[8,8];
bool[,] vis = new bool[8, 8];
int[] dx = { 0, 1, 0, -1 };
int[] dy = { 1, 0, -1, 0 };
int ans = 0;
for (int i = 0; i < r; i++)
{
	string inputinfo = Console.ReadLine();
	for (int j = 0; j < c; j++)
		board[i, j] = inputinfo[j];
}

vis[r - 1, 0] = true;
dfs(1, r - 1, 0);

Console.WriteLine(ans);


void dfs(int dis, int x, int y)
{
	if(dis == k)
	{
		if(x == 0 && y == c - 1 )
			ans++;
		return;
	}
	for (int i = 0; i < 4; i++)
	{
		int nx = dx[i] + x;
		int ny = dy[i] + y;
		if (nx < 0 || ny < 0 || nx >= r || ny >= c)
			continue;
		if (vis[nx, ny] || board[nx,ny] == 'T')
			continue;
		vis[nx, ny] = true;
		dfs(dis + 1, nx, ny);
		vis[nx, ny] = false;
	}
}