// BOJ_14503


using System.Runtime.ConstrainedExecution;

int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];
int[] startInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int[,] board = new int[55, 55];
bool[,] vis = new bool[55, 55];
int[] dx = { -1, 0, 1, 0 };
int[] dy = { 0, 1, 0, -1 };
bool finish = false;

(int, int, int) robot = (startInfo[0], startInfo[1], startInfo[2]);

for (int i = 0; i < n; i++)
{
	int[] inputInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    for (int j = 0; j < m; j++)
	{
		board[i,j] = inputInfo[j];
	}
}

int ans = 0;
while (!finish)
{
	var cur = robot;
	if(!vis[cur.Item1, cur.Item2])
	{
		vis[cur.Item1, cur.Item2] = true;
		ans++;
	}

	if (scan(cur))
	{
		for (int i = 0; i < 4; i++)
		{
			cur.Item3 = cur.Item3 - 1;
			if (cur.Item3 < 0)
				cur.Item3 += 4;
			int nx = cur.Item1 + dx[cur.Item3];
			int ny = cur.Item2 + dy[cur.Item3];
			if (board[nx, ny] == 0 && !vis[nx,ny])
			{
				robot = (nx, ny, cur.Item3);
				break;
			}
		}
	}
	else
	{
		int back = cur.Item3 - 2;
		if (back < 0)
			back += 4;
		int nx = cur.Item1 + dx[back];
		int ny = cur.Item2 + dy[back];
		if (nx < 0 || ny < 0 || nx >=n || ny >= m || board[nx, ny] == 1)
            finish = true;
		robot = (nx , ny , cur.Item3);
    }
}

Console.WriteLine(ans);


bool scan((int,int,int) cur)
{
	bool check = false;
	for (int i = 0; i < 4; i++)
	{
		int nx = dx[i] + cur.Item1;
		int ny = dy[i] + cur.Item2;
		if (nx < 0 || ny < 0 || nx >= n || ny >= m)
			continue;
		if (board[nx, ny] == 0 && !vis[nx, ny])
			check = true;
	}
	return check;

}