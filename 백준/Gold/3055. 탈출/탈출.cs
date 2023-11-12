// BOJ_3055



string[] inputrc = Console.ReadLine().Split(' ');
int r = int.Parse(inputrc[0]);
int c = int.Parse(inputrc[1]);

char[,] board = new char[55, 55];
int[,] dis = new int[55, 55];
bool[,] water = new bool[55, 55];
int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };
Queue<Tuple<int, int>> h = new Queue<Tuple<int, int>>();
Queue<Tuple<int, int>> w = new Queue<Tuple<int, int>>();
Tuple<int, int> end = new Tuple<int, int>(0,0);
for (int i = 0; i < r; i++)
{
    string inputmap = Console.ReadLine();
	for (int j = 0; j < c; j++)
	{
		board[i,j] = inputmap[j];
		if (board[i, j] == 'S')
		{
			h.Enqueue(new Tuple<int, int>(i, j));
			dis[i, j] = 1;
		}
		else if (board[i, j] == '*')
		{
            w.Enqueue(new Tuple<int, int>(i, j));
			water[i, j] = true;
		}
		if (board[i, j] == 'D')
			end = new Tuple<int, int>(i, j);
    }
}

while (h.Count != 0 || w.Count != 0)
{
    floodfill();
    moving();
}


if (dis[end.Item1,end.Item2] == 0)
    Console.WriteLine("KAKTUS");
else
	Console.WriteLine(dis[end.Item1, end.Item2] - 1);

void moving()
{
    Queue<Tuple<int, int>> temp = new Queue<Tuple<int, int>>();
    while (h.Count > 0)
    {
        var hpos = h.Dequeue();
        for (int i = 0; i < 4; i++)
        {
            int nx = dx[i] + hpos.Item1;
            int ny = dy[i] + hpos.Item2;
            if (nx < 0 || ny < 0 || nx >= r || ny >= c)
                continue;
            if (dis[nx, ny] > 0 || board[nx, ny] == 'X' || water[nx, ny])
                continue;
            dis[nx, ny] = dis[hpos.Item1, hpos.Item2] + 1;
            temp.Enqueue(new Tuple<int, int>(nx, ny));
        }
    }
    h = new Queue<Tuple<int, int>>(temp);
}

void floodfill()
{
	Queue<Tuple<int, int>> temp = new Queue<Tuple<int, int>>();

	while (w.Count > 0)
	{
		var cur = w.Dequeue();
		for (int i = 0; i < 4; i++)
		{
            int nx = dx[i] + cur.Item1;
            int ny = dy[i] + cur.Item2;
            if (nx < 0 || ny < 0 || nx >= r || ny >= c)
                continue;
            if (water[nx, ny] || board[nx, ny] == 'X' || board[nx, ny] == 'D')
                continue;
			water[nx, ny] = true;
			temp.Enqueue(new Tuple<int, int>(nx, ny));
        }
	}
	w = new Queue<Tuple<int, int>>(temp);
}