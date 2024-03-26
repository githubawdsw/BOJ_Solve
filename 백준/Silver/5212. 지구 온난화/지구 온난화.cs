// BOJ_5212


using System.Text;

StringBuilder sb = new StringBuilder();
int[] inputrc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int r = inputrc[0];
int c = inputrc[1];

char[,] board = new char[15, 15];
bool[,] ground = new bool[15, 15];
int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };
Queue<(int, int)> q = new Queue<(int, int)>();
for (int i = 0; i < r; i++)
{
	string inputInfo = Console.ReadLine();
	for (int j = 0; j < c; j++)
	{
		board[i, j] = inputInfo[j];
		if (inputInfo[j] == 'X')
			q.Enqueue((i, j));
	}
}

while (q.Count > 0)
{
	var cur = q.Dequeue();
	int count = 0;
	for (int i = 0; i < 4; i++)
	{
		int nx = cur.Item1 + dx[i];
		int ny = cur.Item2 + dy[i];

		if (nx < 0 || ny < 0 || nx >= r || ny >= c)
			continue;
		if (board[nx, ny] == '.')
			continue;

		count++;
	}
	if (count > 1)
		ground[cur.Item1, cur.Item2] = true;
}

int minx = 20; int miny = 20;
int maxx = 0; int maxy = 0;
for (int i = 0; i < r; i++)
{
	for (int j = 0; j < c; j++)
	{
		if (ground[i, j])
		{
			minx = Math.Min(i, minx);
			miny = Math.Min(j, miny);
			maxx = Math.Max(i, maxx);
			maxy = Math.Max(j, maxy);
		}
	}
}

for (int i = minx; i <= maxx; i++)
{
	for (int j = miny; j <= maxy; j++)
	{
		if (ground[i, j])
			sb.Append("X");
		else
			sb.Append(".");
	}
	sb.AppendLine();
}

Console.WriteLine(sb);