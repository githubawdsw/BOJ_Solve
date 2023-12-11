// BOJ_16918



using System.Text;

StringBuilder sb = new StringBuilder();

int[] inputrcn = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int r = inputrcn[0];
int c = inputrcn[1];
int n = inputrcn[2];

int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };
char[][,] board = new char[8][,];
Queue<Tuple<int, int>> q = new Queue<Tuple<int, int>>();
for (int i = 0; i < 8; i++)
	board[i] = new char[205, 205];

for (int i = 0; i < r; i++)
{
	string inputstr = Console.ReadLine();
	for (int j = 0; j < c; j++)
	{	
		board[0][i, j] = inputstr[j];
        board[1][i, j] = inputstr[j];

        board[2][i, j] = 'O';
        board[3][i, j] = 'O';
        board[4][i, j] = 'O';
        board[5][i, j] = 'O';

        if (inputstr[j] == 'O')
			q.Enqueue(new Tuple<int, int>(i, j));
    }
}

bfs(3);
for (int i = 0; i < r; i++)
{
    for (int j = 0; j < c; j++)
    {
        if (board[3][i,j] == 'O')
            q.Enqueue(new Tuple<int, int>(i, j));
    }
}

bfs(5);
if (n <= 5)
{
	for (int i = 0; i < r; i++)
	{
		for (int j = 0; j < c; j++)
			sb.Append(board[n][i, j]);
		sb.AppendLine();
	}
}
else
{
	if( n % 2 == 0)
	{
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
                sb.Append(board[n % 2 + 2][i, j]);
            sb.AppendLine();
        }
    }
	else
	{
		int count = n % 4 + 4;
		if (count == 7)
			count = 3;
        for (int i = 0; i < r; i++)
		{
			for (int j = 0; j < c; j++)
				sb.Append(board[count][i, j]);
			sb.AppendLine();
		}
	}
}

Console.WriteLine(sb);


void bfs(int count)
{
	while (q.Count > 0)
	{
		var cur = q.Dequeue();
		board[count][cur.Item1, cur.Item2] = '.';
		for (int i = 0; i < 4; i++)
		{
			int nx = dx[i] + cur.Item1;
			int ny = dy[i] + cur.Item2;

			if (nx < 0 || ny < 0 || nx >= r || ny >= c)
				continue;
			board[count][nx, ny] = '.';
		}
	}
}