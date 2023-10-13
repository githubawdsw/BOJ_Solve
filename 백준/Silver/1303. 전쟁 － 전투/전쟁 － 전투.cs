// BOJ_1303



string[] inputnm = Console.ReadLine().Split(' ');
int n = int.Parse(inputnm[0]);
int m = int.Parse(inputnm[1]);
char[,] board = new char[105, 105];
bool[,] vis = new bool[105, 105];
int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };

for (int i = 0; i < m; i++)
{
    string inputColor = Console.ReadLine();
	for (int j = 0; j < n; j++)
		board[i, j] = inputColor[j];
}

Queue<Tuple<int, int>> wq = new Queue<Tuple<int, int>>();
Queue<Tuple<int, int>> bq = new Queue<Tuple<int, int>>();
int wsum = 0;
int bsum = 0;
for (int i = 0;i < m; i++)
{
	for (int j = 0; j < n; j++)
	{
		if (vis[i, j])
			continue;
		vis[i, j] = true;
		if (board[i, j] == 'W')
		{
			wq.Enqueue(new Tuple<int, int>(i,j));
			bfs(wq);
		}
        else
        {
            bq.Enqueue(new Tuple<int, int>(i, j));
            bfs(bq);
        }
    }
}
Console.WriteLine("{0} {1}"	, wsum, bsum);

void bfs(Queue<Tuple<int, int>> q)
{
	int count = 1;
	var temp = q.Peek();
	char type = board[temp.Item1, temp.Item2];
	while (q.Count > 0)
	{
		var cur = q.Dequeue();
		for (int i = 0; i < 4; i++)
		{
			int nx = dx[i] + cur.Item1;
			int ny = dy[i] + cur.Item2;
			if (nx < 0 || ny < 0 || nx >= m || ny >= n)
				continue;
			if (vis[nx, ny] || board[nx, ny] != board[cur.Item1, cur.Item2])
				continue;
			vis[nx, ny] = true;
			count++;
			q.Enqueue(new Tuple<int, int>(nx, ny));
		}
	}
	if (type == 'W')
		wsum += count * count;
	else
		bsum += count * count;
}