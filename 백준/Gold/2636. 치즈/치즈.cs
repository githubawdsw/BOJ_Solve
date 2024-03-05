// BOJ_17144


int[] inputrc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int r = inputrc[0];
int c = inputrc[1];

int[,] board = new int[r, c];
int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };
Queue<(int, int)> q = new Queue<(int, int)>();
Queue<(int, int)> temp = new Queue<(int, int)>();
List<(int, int)> list = new List<(int, int)>();
for (int i = 0; i < r; i++)
{
    int[] inputAir = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
	for (int j = 0; j < c; j++)
	{
		board[i, j] = inputAir[j];
		if (inputAir[j] == 1)
			list.Add((i, j));
	}
}

if(list.Count == 0)
{
    Console.WriteLine(0);
    Console.WriteLine(0);
    return;
}

for (int i = 0; i < r; i++)
{
	q.Enqueue((i, 0));
	q.Enqueue((i, c - 1));
}
for (int i = 0; i < c; i++)
{
    q.Enqueue((0, i));
    q.Enqueue((r - 1, i));
}

int count = 0;
int lastPiece = int.MaxValue;
while (list.Count > 0)
{
	bool[,] vis = new bool[r, c];
	list.Clear();

	temp = new Queue<(int, int)>(q);
	count++;
	while (temp.Count > 0)
	{
		var cur = temp.Dequeue();
		for (int i = 0; i < 4; i++)
		{
			int nx = cur.Item1 + dx[i];
			int ny = cur.Item2 + dy[i];

			if (nx < 0 || ny < 0 || nx >= r || ny >= c || vis[nx, ny])
				continue;

			vis[nx, ny] = true;
			if (board[nx, ny] == 0)
				temp.Enqueue((nx, ny));
			else
				list.Add((nx, ny));
		}
	}

	int sum = 0;
	foreach (var one in list)
	{
		board[one.Item1, one.Item2] = 0;
		sum++;
	}
	if(sum != 0)
		lastPiece = Math.Min(lastPiece, sum);
    
}

Console.WriteLine(count - 1);
Console.WriteLine(lastPiece);