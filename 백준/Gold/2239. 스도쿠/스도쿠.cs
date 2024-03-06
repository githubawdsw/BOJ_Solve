// BOJ_2239


using System.Text;

StringBuilder sb = new StringBuilder();
int[,] board = new int[9, 9];
List<(int, int)> list = new List<(int, int)>();
for (int i = 0; i < 9; i++)
{
    string inputData = Console.ReadLine();
	for (int j = 0; j < 9; j++)
	{
		board[i, j] = inputData[j] - '0';
		if (board[i, j] == 0)
			list.Add((i, j));
	}
}

Sudoku(0);


void Sudoku(int depth)
{
	if(depth == list.Count)
	{
		for (int i = 0; i < 9; i++)
		{
            for (int j = 0; j < 9; j++)
            {
                sb.Append(board[i, j].ToString());
            }
            sb.AppendLine();
        }
        Console.WriteLine(sb);
        Environment.Exit(0);
	}

    int x = list[depth].Item1;
    int y = list[depth].Item2;
    for (int i = 1; i <= 9; i++)
	{
		if (RowCheck(x, y, i) && ColCheck(x, y, i) && BoxCheck(x, y, i))
		{
			board[x, y] = i;
			Sudoku(depth + 1);
			board[x, y] = 0;
        }
	}
}

bool RowCheck(int x, int y, int data)
{
	for (int i = 0; i < 9; i++)
	{
		if (board[i, y] == data)
			return false;
	}
	return true;
}

bool ColCheck(int x, int y, int data)
{
    for (int i = 0; i < 9; i++)
    {
        if (board[x, i] == data)
            return false;
    }
    return true;
}

bool BoxCheck(int x ,int y, int data)
{
	for (int i = (x / 3) * 3; i < (x / 3 + 1) * 3; i++)
	{
		for (int j = (y / 3) * 3; j < (y / 3 + 1) * 3; j++)
		{
			if (board[i, j] == data)
				return false;
		}
	}
	return true;
}