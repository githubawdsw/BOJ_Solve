// BOJ_1034


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

string[] board = new string[55];
for (int i = 0; i < n; i++)
	board[i] = Console.ReadLine();

int k = int.Parse(Console.ReadLine());

int ans = 0;
for (int i = 0; i < n; i++)
{
	int zeroCount = 0;
	for (int j = 0; j < m; j++)
	{
		if (board[i][j] == '0')
			zeroCount++;
	}

	if (zeroCount > k || zeroCount % 2 != k % 2)
		continue;

	int sameRowCount = 0;
	for (int j = 0; j < n; j++)
	{
		if (board[i] == board[j])
			sameRowCount++;
	}

	ans = Math.Max(ans, sameRowCount);
}

Console.WriteLine(ans);