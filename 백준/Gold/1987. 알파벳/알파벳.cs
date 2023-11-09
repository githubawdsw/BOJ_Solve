//BOJ_10808


string[] inputrc = Console.ReadLine().Split(' ');
int r = int.Parse(inputrc[0]);
int c = int.Parse(inputrc[1]);

int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };
int[] check = new int[30];
int[,] dis = new int[25, 25];
char[,] board = new char[25,25];
for (int i = 0; i < r; i++)
{
	string inputarr = Console.ReadLine();
	for (int j = 0; j < c; j++)
		board[i,j] = inputarr[j];
	
}
int ans = 0;
dis[0, 0] = 1;
check[board[0, 0] - 'A']++;
DFS(0, 0);

if (ans == 0)
	ans = 1;
Console.WriteLine(	ans);


void DFS(int x ,int y)
{
	for (int i = 0; i < 4; i++)
	{
		int nx = x + dx[i];
		int ny = y + dy[i];
		if (nx < 0 || ny < 0 || nx >= r || ny >= c)
			continue;
		if (check[board[nx, ny] - 'A'] > 0)
			continue;

		check[board[nx, ny] - 'A']++;
		dis[nx, ny] = dis[x, y] + 1;
		ans = Math.Max(ans, dis[nx, ny]);
        DFS(nx, ny);
        check[board[nx, ny] - 'A']--;
    }
}