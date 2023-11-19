// BOJ_14497



int[] inputnm = Array.ConvertAll(Console.ReadLine().Split( ), int.Parse);
int n = inputnm[0];
int m = inputnm[1];
int[] pos = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int jux = pos[0] - 1;
int juy = pos[1] - 1;
int thiefx = pos[2] - 1;
int thiefy = pos[3] - 1;

char[,] board = new char[305, 305];
int[,] number = new int[305, 305];
bool[,] vis;
int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };
Queue<Tuple<int,int>> q= new Queue<Tuple<int,int>>();
for (int i = 0; i < n; i++)
{
	string input = Console.ReadLine();
	for (int j = 0; j < m; j++)
		board[i,j] = input[j];
}

int count = 1;
while (count <= 600)
{
	q.Enqueue(new Tuple<int, int>(jux, juy));
	vis = new bool[305, 305];
    while (q.Count > 0)
	{
		var cur = q.Dequeue();
		for (int i = 0; i < 4; i++)
		{
			int nx = dx[i] + cur.Item1;
			int ny = dy[i] + cur.Item2;
			if (nx < 0 || ny < 0 || nx >= n || ny >= m || vis[nx,ny])
				continue;
			if (board[nx, ny] == '0')
			{
				vis[nx, ny] = true;
				q.Enqueue(new Tuple<int, int>(nx, ny));
			}
			else
				number[nx, ny] = count;
		}
	}

	for (int i = 0; i < n; i++)
		for (int j = 0; j < m; j++)
			if (number[i, j] != 0)
				board[i, j] = '0';

    if (number[thiefx, thiefy] != 0)
		break;
	count++;
}

Console.WriteLine(number[thiefx,thiefy]);
