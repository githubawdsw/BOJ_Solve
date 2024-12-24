// BOJ_9207


using System.Text;

StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());

int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };
int ans = 0;

while (n-- > 0)
{
	char[,] board = new char[10, 10];
	ans = 0;
    int count = 0;
    for (int i = 0; i < 5; i++)
	{
		string inputBoard= Console.ReadLine();
		for (int j = 0; j < 9; j++)
		{
			board[i,j] = inputBoard[j];
			if (inputBoard[j] == 'o')
				count++;
		}
	}
	if(n != 0)
		Console.ReadLine();

	Dfs(0, 0, board);
	sb.AppendLine((count - ans).ToString() + " " + ans.ToString());
}

Console.WriteLine(sb);


void Dfs(int depth, int move, char[,] board)
{
	for (int x = 0; x < 5; x++)
	{
		for (int y = 0; y < 9; y++)
		{
			if (board[x,y] == 'o')
			{
                for (int k = 0; k < 4; k++)
                {
                    int nx = x + dx[k];
                    int ny = y + dy[k];

                    if (nx < 0 || ny < 0 || nx >= 5 || ny >= 9 || board[nx,ny] == '#')
                        continue;

                    if (board[nx, ny] == 'o')
                    {
                        int nnx = nx + dx[k];
                        int nny = ny + dy[k];

                        if (nnx < 0 || nny < 0 || nnx >= 5 || nny >= 9 )
                            continue;

						if (board[nnx,nny] == '.')
						{
							board[nnx, nny] = 'o';
							board[nx, ny] = '.';
							board[x, y] = '.';

							Dfs(depth + 1, move + 1, board);

							board[nnx, nny] = '.';
							board[nx, ny] = 'o';
							board[x, y] = 'o';
						}
                    }
                }
            }
		}
	}
	ans = Math.Max(ans, move);

    return;
}