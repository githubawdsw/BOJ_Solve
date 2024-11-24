// BOJ_3967


using System.Text;

StringBuilder sb = new StringBuilder();

char[,] board = new char[6, 10];
bool[] use = new bool[13];
List<(int, int)> posList = new List<(int, int)>();
bool end = false;
for (int i = 0; i < 5; i++)
{
    string inputLine = Console.ReadLine();
	for (int j = 0; j < inputLine.Length; j++)
	{
		board[i, j] = inputLine[j];
		if (board[i, j] == 'x')
			posList.Add((i, j));
		else if (board[i, j] != '.')
			use[inputLine[j] - 'A'] = true;
	}
}

Solve(0);
for (int i = 0; i < 5; i++)
{
	for (int j = 0; j < 9; j++)
	{
		sb.Append(board[i, j]);
	}
	sb.AppendLine();
}

Console.WriteLine(sb);


void Solve(int depth )
{
	if(depth == posList.Count)
	{
		if (board[0, 4] + board[1, 3] + board[2, 2] + board[3, 1] - 'A' * 4 != 22)
			return;
        if (board[0, 4] + board[1, 5] + board[2, 6] + board[3, 7] - 'A' * 4 != 22)
            return;
        if (board[3, 1] + board[3, 3] + board[3, 5] + board[3, 7] - 'A' * 4 != 22)
            return;
        if (board[1, 1] + board[1, 3] + board[1, 5] + board[1, 7] - 'A' * 4 != 22)
            return;
        if (board[1, 1] + board[2, 2] + board[3, 3] + board[4, 4] - 'A' * 4 != 22)
            return;
        if (board[4, 4] + board[3, 5] + board[2, 6] + board[1, 7] - 'A' * 4 != 22)
            return;

        end = true;
        return;
	}

	for (int i = 0; i < 12; i++)
	{
		if (end)
			return;
		if (use[i])
			continue;

		board[posList[depth].Item1, posList[depth].Item2] = (char)('A' + i);
		use[i] = true;
		Solve(depth + 1);
		use[i] = false;
	}
}
