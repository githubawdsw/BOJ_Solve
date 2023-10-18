// BOJ_14940



using System.Text;

StringBuilder sb = new StringBuilder();

string[] inputnm = Console.ReadLine().Split(' ');
int n = int.Parse(inputnm[0]);
int m = int.Parse(inputnm[1]);

int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };
int[,] board = new int[1005,1005];
int[,] dis = new int[1005, 1005];
Queue<Tuple<int, int>> q = new Queue<Tuple<int, int>>();

for (int i = 0; i < n; i++)
{
    string[] inputArr = Console.ReadLine().Split(" ");
	for (int j = 0; j < m; j++)
	{
		board[i,j] = int.Parse(inputArr[j]);
		if (board[i, j] == 2)
		{
			q.Enqueue(new Tuple<int, int>(i, j));
			dis[i, j] = 1;
		}
	}
}

while (q.Count > 0)
{
	var cur = q.Dequeue();
	for (int i = 0; i < 4; i++)
	{
		int nx = dx[i] + cur.Item1;
		int ny = dy[i] + cur.Item2;
		if (nx < 0 || ny < 0 || nx >= n || ny >= m)
			continue;
		if (board[nx, ny] == 0 || dis[nx,ny] > 0)
			continue;
		dis[nx, ny] = dis[cur.Item1, cur.Item2] + 1;
		q.Enqueue(new Tuple<int, int>(nx, ny));
	}
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
	{
		if (board[i, j] == 1 && dis[i, j] == 0)
			sb.Append($"{-1} ");
		else if (dis[i,j] != 0)
	        sb.Append($"{dis[i, j] - 1} ");
		else
			sb.Append($"{dis[i, j]} ");
    }
	sb.AppendLine();
}

Console.WriteLine(	sb );
