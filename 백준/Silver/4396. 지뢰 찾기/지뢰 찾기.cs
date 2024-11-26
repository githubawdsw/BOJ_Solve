// BOJ_4396


using System.Text;

StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());

char[,] board = new char[11, 11];
int[] dx = { 1, 0, -1, 0, 1, 1, -1, -1 };
int[] dy = { 0, 1, 0, -1, 1, -1, 1, -1 };
char[,] ans = new char[11, 11];
bool check = false;

for (int i = 0; i < n; i++)
{
	string inputInfo = Console.ReadLine();
	for (int j = 0; j < n; j++)
	{
		board[i, j] = inputInfo[j];
	}
}

for (int i = 0; i < n; i++)
{
	string safety = Console.ReadLine();
	for (int j = 0; j < n; j++)
	{
		if (safety[j] == 'x')
		{
			if (board[i, j] == '*')
				check = true;
			int count = 0;
			for (int k = 0; k < 8; k++)
			{
				int nx = i + dx[k];
				int ny = j + dy[k];

				if (nx < 0 || ny < 0 || nx >= n || ny >= n)
					continue;
				if (board[nx, ny] == '*')
					count++;
			}
			ans[i, j] = (char)(count + '0');
		}
		else
			ans[i, j] = '.';
	}
}

if (check)
	Fail();

for (int i = 0; i < n; i++)
{
	for (int j = 0; j < n; j++)
	{
		sb.Append(ans[i, j]);
	}
	sb.AppendLine();
}

Console.WriteLine(sb);


void Fail()
{
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < n; j++)
		{
			if (board[i, j] == '*')
				ans[i, j] = '*';
		}
	}
}