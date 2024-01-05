// BOJ_2615


using System.Text;

StringBuilder sb = new StringBuilder();
int[,] board = new int[20, 20];
int[] dx = { 1, -1, 0, 0, 1, -1, 1, -1 };
int[] dy = { 0, 0, 1, -1, 1, -1, -1, 1 };
for (int i = 0; i < 19; i++)
{
	int[] inputInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
	for (int j = 0; j < 19; j++)
	{
		board[i, j] = inputInfo[j];
	}
}

for (int i = 0; i < 19; i++)
{
    for (int j = 0; j < 19; j++)
    {
		if (board[i, j] == 1 || board[i, j] == 2)
		{
			Solve(board[i, j], i, j);
			if(sb.Length > 0)
			{
                Console.WriteLine(sb);
                return;
			}
		}
    }
}

Console.WriteLine(0);


void Solve(int goStoneType, int x ,int y)
{
	for (int i = 0; i < 8; i++)
	{
		int nx = dx[i] + x;
		int ny = dy[i] + y;
		int count = 1;

		int minrow = x;
		int mincol = y;
		for (int j = 0; j < 6; j++)
		{
			if (nx < 0 || ny < 0 || nx >= 19 || ny >= 19)
				break;
			if (board[nx, ny] != goStoneType)
				break;

			count++;

            if (ny < mincol)
            {
                minrow = nx;
                mincol = ny;
            }

			nx += dx[i];
			ny += dy[i];
        }

		i++;
        nx = dx[i] + x;
        ny = dy[i] + y;
        for (int j = 0; j < 6; j++)
        {
            if (nx < 0 || ny < 0 || nx >= 19 || ny >= 19)
                break;
            if (board[nx, ny] != goStoneType)
                break;

            count++;

			if(ny < mincol)
			{
				minrow = nx;
				mincol = ny;
			}

            nx += dx[i];
            ny += dy[i];
        }

        if (count == 5)
		{
			sb.AppendLine(goStoneType.ToString());
			sb.AppendLine($"{minrow + 1} {mincol + 1}");
			break;
		}
	}
}
