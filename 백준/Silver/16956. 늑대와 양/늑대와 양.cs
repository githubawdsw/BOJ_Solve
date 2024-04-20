// BOJ_16956


using System.Text;

StringBuilder sb = new StringBuilder();
int[] inputrc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int r = inputrc[0];
int c = inputrc[1];
char[,] board = new char[505, 505];
int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };
Queue<(int, int)> q = new Queue<(int, int)>();
for (int i = 0; i < r; i++)
{
	string inputInfo = Console.ReadLine();
	for (int j = 0; j < c; j++)
	{
		board[i, j] = inputInfo[j];
		if (inputInfo[j] == 'S')
			q.Enqueue((i, j));
	}
}

while (q.Count > 0)
{
	var cur = q.Dequeue();
	for (int i = 0; i < 4; i++)
	{
		int nx = cur.Item1 + dx[i];
		int ny = cur.Item2 + dy[i];
		if (nx < 0 || ny < 0 || nx >= r || ny >= c)
			continue;
		if (board[nx, ny] == 'W')
		{
			Console.WriteLine(0);
			return;
		}
	}
}

sb.AppendLine("1");
for (int i = 0; i < r; i++)
{
	for (int j = 0; j < c; j++)
	{
		if (board[i, j] == '.')
			board[i, j] = 'D';
		sb.Append(board[i, j]);
	}
	sb.AppendLine();
}

Console.WriteLine(sb);
