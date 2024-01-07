// BOJ_16926


using System.Text;

StringBuilder sb = new StringBuilder();
int[] inputnmr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnmr[0];
int m = inputnmr[1];
int r = inputnmr[2];

int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };
int[,] board = new int[305, 305];
int[,] ans = new int[305, 305];
for (int i = 0; i < n; i++)
{
    int[] inputInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
	for (int j = 0; j < m; j++)
	{
		board[i, j] = inputInfo[j];
	}
}

int x = 0, y = 0;
while (x < n / 2 && y < m / 2)
{
	int nidx = 0;

    int nx = x;
    int ny = y;
    for (int i = 0; i < r; i++)
	{
        nx += dx[nidx];
        ny += dy[nidx];
		if ((nx, ny) == (n - x - 1, y) || (nx, ny) == (n - x - 1, m - y - 1) || (nx, ny) == (x, m - y - 1))
		{
			nidx++;
		}
		else if((nx, ny) == (x, y))
		{
			nidx = 0;
		}
	}

	int originx = x;
	int originy = y;
	int sidx = 0;
	int len = 2 * (n + m - 2 * (x + y)) - 4;
	while (len-- > 0)
	{
		ans[nx, ny] = board[originx, originy];

        originx += dx[sidx];
        originy += dy[sidx];
        if ((originx, originy) == (n - x - 1, y) || (originx, originy) == (n - x - 1, m - y - 1) || (originx, originy) == (x, m - y - 1))
            sidx++;
        else if ((originx, originy) == (x, y))
            sidx = 0;


        nx += dx[nidx];
        ny += dy[nidx];
        if ((nx, ny) == (n - x - 1, y) || (nx, ny) == (n - x - 1, m - y - 1) || (nx, ny) == (x, m - y -1))
            nidx++;
        else if ((nx, ny) == (x, y))
            nidx = 0;
    }

	if (x < n / 2)
		x++;
	if (y < m / 2) 
		y++;
}


for (int i = 0; i < n; i++)
{
	for (int j = 0; j < m; j++)
	{
		sb.Append($"{ans[i, j]} ");
	}
	sb.Append('\n');
}

Console.WriteLine(sb);
