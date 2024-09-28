// BOJ_2823


using System.Runtime.ConstrainedExecution;

int[] inputrc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int r = inputrc[0];
int c = inputrc[1];

int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };
char[,] board = new char[15, 15];
bool[,] vis = new bool[15, 15];
Queue<(int, int)> q = new Queue<(int, int)>();
for (int i = 0; i < r; i++)
{
    string inputRoad = Console.ReadLine();
	for (int j = 0; j < c; j++)
	{
		board[i, j] = inputRoad[j];
		if (board[i, j] == '.')
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

		if(nx < 0 || ny < 0 || nx >= r || ny >= c) 
			continue;
		if (board[nx, ny] == 'X' || vis[nx,ny])
			continue;

		vis[nx, ny] = true;

		if (!Check(nx, ny))
		{
            Console.WriteLine(1);
			return;
		}
		q.Enqueue((nx, ny));
	}
}
Console.WriteLine(0);

bool Check(int x, int y)
{
	int count = 0;
	for (int i = 0; i < 4; i++)
	{
        int nx = x + dx[i];
        int ny = y + dy[i];
        if (nx < 0 || ny < 0 || nx >= r || ny >= c)
            continue;
        if (board[nx, ny] == 'X')
            continue;

		count++;
    }
	if (count >= 2)
		return true;

	return false;
}