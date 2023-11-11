//BOJ_2580


using System.Text;

int[,] board = new int[10, 10];
List<Tuple<int,int>> blank = new List<Tuple<int,int>>();
bool success = false;
for (int i = 0; i < 9; i++)
{
	string[] inputarr = Console.ReadLine().Split(' ');
	for (int j = 0; j < 9; j++)
	{
		board[i,j] = int.Parse(inputarr[j]);
		if (board[i, j] == 0)
            blank.Add(new Tuple<int, int>(i, j));
	}
}
int count = blank.Count;
StringBuilder sb = new StringBuilder();
sudoku(0);
Console.WriteLine(	sb)
	
	;
void sudoku(int n)
{
	if(n == count)
	{
		for (int i = 0; i < 9; i++)
		{
			for (int j = 0; j < 9; j++)
				sb.Append($"{board[i, j]} ");
			sb.Append("\n");
		}
		success = true;
		return;
	}

	for (int i = 1; i <= 9; i++)
	{
		board[blank[n].Item1, blank[n].Item2] = i;
		if (check(blank[n]))
			sudoku(n + 1);
		if (success)
			return;
	}
	board[blank[n].Item1, blank[n].Item2] = 0;
	return;
}

bool check(Tuple<int,int> t)
{
	int x = t.Item1;
	int y = t.Item2;
	for (int i = 0; i < 9; i++)
	{
		if (board[x, i] == board[x, y] && i != y)
			return false;
		if (board[i, y] == board[x, y] && i != x)
			return false;
	}
	x /= 3;
	y /= 3;
	for (int i = x * 3; i < x * 3 + 3; i++)
        for (int j = y * 3; j < y * 3 + 3; j++)
			if (board[i, j] == board[t.Item1, t.Item2] && i != t.Item1 && j != t.Item2)
				return false;

	return true;
}