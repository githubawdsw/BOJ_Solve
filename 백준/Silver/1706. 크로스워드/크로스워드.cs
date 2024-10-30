// BOJ_1706


int[] inputrc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int r = inputrc[0];
int c = inputrc[1];

SortedSet<string> ss = new SortedSet<string>();
char[,] board = new char[25, 25];
for (int i = 0; i < r; i++)
{
	string input = Console.ReadLine();
	for (int j = 0; j < c; j++)
	{
		board[i, j] = input[j];
	}
}

for (int i = 0; i < r; i++)
{
	if (board[i, 0] != '#')
		Colum(i, 0);
}
for (int i = 0; i < r; i++)
{
	for (int j = 1; j < c; j++)
	{
		if (board[i, j] != '#' && board[i, j - 1] == '#')
		{
			Colum(i, j);
		}
    }
}
for (int i = 0; i < c; i++)
{
    if (board[0, i] != '#')
        Row(0, i);
}
for (int i = 1; i < r; i++)
{
    for (int j = 0; j < c; j++)
    {
        if (board[i, j] != '#' && board[i - 1, j] == '#')
        {
            Row(i, j);
        }
    }
}

Console.WriteLine(ss.First());

void Colum(int x, int y)
{
	string str = "";
	for (int i = y; i < c; i++)
	{
		if (board[x,i] == '#')
			break;

		str += board[x, i];
	}
	if(str.Length > 1)
		ss.Add(str);
}

void Row(int x , int y)
{
    string str = "";
    for (int i = x; i < r; i++)
    {
        if (board[i, y] == '#')
            break;

        str += board[i, y];
    }
    if (str.Length > 1)
        ss.Add(str);
}