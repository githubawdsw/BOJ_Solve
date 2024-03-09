// BOJ_17144


int[] inputrc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int r = inputrc[0];
int c = inputrc[1];
int t = inputrc[2];

int[,] board = new int[r, c];
int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };
Queue<(int, int)> q = new Queue<(int, int)>();
(int, int) airCleanerPos = (0, 0);
for (int i = 0; i < r; i++)
{
    int[] inputAir = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
	for (int j = 0; j < c; j++)
	{
		board[i, j] = inputAir[j];
		if (inputAir[j] >= 5)
			q.Enqueue((i, j));
	}
}

for (int i = 0; i < r; i++)
{
    if (board[i,0] == -1)
    {
        airCleanerPos = (i, 0);
        break;
    }
}

while (t-- > 0)
{
    DustDiffusion();

    AirCleaner(airCleanerPos.Item1 , airCleanerPos.Item2, 1);
    AirCleaner(airCleanerPos.Item1 + 1, airCleanerPos.Item2, -1);

    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            if (board[i, j] >= 5)
                q.Enqueue((i, j));
        }
    }
}

int ans = 0;
for (int i = 0; i < r; i++)
{
    for (int j = 0; j < c; j++)
    {
        ans += board[i, j];
    }
}

Console.WriteLine(ans + 2);


void DustDiffusion()
{
    int[,] diffusion = new int[r, c];
    while (q.Count > 0)
    {
        var cur = q.Dequeue();
        int count = 0;
        int data = board[cur.Item1, cur.Item2] / 5;
        for (int i = 0; i < 4; i++)
        {
            int nx = cur.Item1 + dx[i];
            int ny = cur.Item2 + dy[i];

            if (nx < 0 || ny < 0 || nx >= r || ny >= c)
                continue;
            if (board[nx, ny] == -1)
                continue;
            diffusion[nx, ny] += data;
            count++;
        }

        board[cur.Item1, cur.Item2] -= data * count;
    }

    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            board[i, j] += diffusion[i, j];
        }
    }
}

void AirCleaner(int x, int y, int rot)
{
    if(rot > 0)
    {
        (int, int) dir = (-1, 0);
        (int, int) target = (x + dir.Item1, y + dir.Item2);
        while (board[target.Item1 + dir.Item1, target.Item2 + dir.Item2] != -1)
        {
            int nx = target.Item1 + dir.Item1;
            int ny = target.Item2 + dir.Item2;

            board[target.Item1, target.Item2] = board[nx, ny];
            target = (nx, ny);

            if (nx + dir.Item1 < 0)
                dir = (0, 1);
            else if (ny + dir.Item2 >= c)
                dir = (1, 0);
            else if (nx + dir.Item1 > x)
                dir = (0, -1);

        }
        board[x, 1] = 0;
    }

    if (rot < 0)
    {
        (int, int) dir = (1, 0);
        (int, int) target = (x + dir.Item1, y + dir.Item2);
        while (board[target.Item1 + dir.Item1, target.Item2 + dir.Item2] != -1)
        {
            int nx = target.Item1 + dir.Item1;
            int ny = target.Item2 + dir.Item2;

            board[target.Item1, target.Item2] = board[nx, ny];
            target = (nx, ny);

            if (nx + dir.Item1 >= r)
                dir = (0, 1);
            else if (ny + dir.Item2 >= c)
                dir = (-1, 0);
            else if (nx + dir.Item1 < x)
                dir = (0, -1);

        }
        board[x , 1] = 0;
    }
}
