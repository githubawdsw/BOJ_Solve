// BOJ_14502


string[] inputnm = Console.ReadLine().Split(' ');
int n = int.Parse(inputnm[0]);
int m = int.Parse(inputnm[1]);

int[,] board = new int[10, 10];
int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };
List<Tuple<int,int>> tupleList = new List<Tuple<int,int>>();
Queue<Tuple<int, int>> defaultQ = new Queue<Tuple<int, int>>();
for (int i = 0; i < n; i++)
{
	string[] arr = Console.ReadLine().Split(" ");
	for (int j = 0; j < m; j++)
	{
		board[i,j] = int.Parse(arr[j]);
		if (board[i, j] == 2)
			defaultQ.Enqueue(new Tuple<int, int>(i, j));
		else if (board[i, j] == 0)
			tupleList.Add(new Tuple<int, int>(i, j));
    }
}

bool[] idxvis = new bool[tupleList.Count];
int ans = 0;
backTracking(0);

Console.WriteLine(	ans);

void backTracking(int count)
{
	if(count == 3)
	{
		int[,] copy = new int[10,10];
		Array.Copy(board, copy, board.Length);
		int c = 0;
		for (int i = 0; i < idxvis.Length; i++)
		{
			if (c == 3)
				break;
			if (idxvis[i])
			{
				copy[tupleList[i].Item1, tupleList[i].Item2] = 1;
				c++;
			}
		}
		bfs( copy);
		return;
	}

	for (int i = 0; i < tupleList.Count; i++)
	{
		if (!idxvis[i])
		{
			idxvis[i] = true;
			backTracking(count + 1);
			idxvis[i] = false;
		}
	}

}

void bfs(int[,] copy)
{
	Queue<Tuple<int, int>> q = new Queue<Tuple<int, int>>(defaultQ);
	while (q.Count > 0)
	{
		var cur = q.Dequeue();
		for (int i = 0; i < 4; i++)
		{
			int nx = cur.Item1 + dx[i];
			int ny = cur.Item2 + dy[i];
			if (nx < 0 || ny < 0 || nx >= n || ny >= m)
				continue;
			if (copy[nx,ny] == 2 || copy[nx,ny] == 1)
				continue;
			copy[nx, ny] = 2;
			q.Enqueue(new Tuple<int, int>(nx, ny));
		}
	}

	int temp = 0;
	for (int i = 0; i < n; i++)
		for (int j = 0; j < m; j++)
			if (copy[i, j] == 0)
				temp++;
	ans = Math.Max(temp, ans);
}