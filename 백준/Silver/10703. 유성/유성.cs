// BOJ_10703


using System.Text;

StringBuilder sb = new StringBuilder();
int[] inputrs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int r = inputrs[0];
int s = inputrs[1];

char[,] board = new char[3005, 3005];
int[] meteorlower = new int[3005];
int[] landtop = new int[3005];

Array.Fill(meteorlower, -1);
Array.Fill(landtop, r);
for (int i = 0; i < r; i++)
{
	string shape = Console.ReadLine();
	for (int j = 0; j < s; j++)
	{
		board[i, j] = shape[j];
		if (shape[j] == 'X')
			meteorlower[j] = Math.Max(meteorlower[j], i);
		if (shape[j] == '#')
			landtop[j] = Math.Min(landtop[j], i);
	}
}

int depth = 3000;
for (int i = 0; i < s; i++)
{
	if (meteorlower[i] != -1)
		depth = Math.Min(depth, landtop[i] - meteorlower[i] - 1);
}

for (int i = r - 1; i >= 0; i--)
{
    for (int j = 0; j < s; j++)
    {
		if (board[i,j] == 'X')
		{
			board[i + depth, j] = 'X';
			board[i, j] = '.';
		}
    }
}

for (int i = 0; i < r; i++)
{
	for (int j = 0; j < s; j++)
	{
		sb.Append(board[i, j]);
	}
	sb.AppendLine();
}

Console.WriteLine(sb);