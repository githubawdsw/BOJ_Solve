// BOJ_14499


using System.Text;

StringBuilder sb = new StringBuilder();

int[] inputnmxyk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnmxyk[0];
int m = inputnmxyk[1];
int x = inputnmxyk[2];
int y = inputnmxyk[3];  
int k = inputnmxyk[4];

int[,] board = new int[25, 25];
int[] dx = { 0, 0, -1, 1 };
int[] dy = { 1, -1, 0, 0 };
int[] dice = { 0, 0, 0, 0, 0, 0 };
for (int i = 0; i < n; i++)
{
    int[] mapInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    for (int j = 0; j < m; j++)
	{
        board[i, j] = mapInfo[j];
	}
}

int[] moveInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

Queue<(int, int)> q = new Queue<(int, int)>();
q.Enqueue((x, y));
int under = 0; int front = 4; int back = 1; int right = 2; int left = 3; int up = 5;
for (int i = 0; i < k; i++)
{
    var cur = q.Peek();
    (int, int) dir = (dx[moveInfo[i] - 1], dy[moveInfo[i] - 1]);
    int nx = cur.Item1 + dir.Item1;
    int ny = cur.Item2 + dir.Item2;

    if (nx < 0 || ny < 0 || nx >= n || ny >= m)
        continue;

    q.Dequeue();
    move(nx, ny, dir);
    q.Enqueue((nx, ny));
    sb.AppendLine(dice[up].ToString());
}

Console.WriteLine(sb);


void move(int nx, int ny, (int,int) dir)
{
    int temp = under;
    if (dir == (0, 1))
    {
        under = right;
        right = up;
        up = left;
        left = temp;
    }
    else if(dir == (0, -1))
    {
        under = left;
        left = up;
        up = right;
        right = temp;
    }
    else if (dir == (-1, 0))
    {
        under = back;
        back = up;
        up = front;
        front = temp;
    }
    else if (dir == (1, 0))
    {
        under = front;
        front = up;
        up = back;
        back = temp;
    }

    int ground = board[nx, ny];
    if (ground == 0)
        board[nx, ny] = dice[under];
    else
    {
        dice[under] = board[nx, ny];
        board[nx, ny] = 0;
    }
}