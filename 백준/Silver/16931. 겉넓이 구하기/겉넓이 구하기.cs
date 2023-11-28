// BOJ_16931


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];
int[,] board = new int[105, 105];

int frontCount = 0;
for (int i = 0; i < n; i++)
{
    int[] inputAmount = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
	int beforeAmount = inputAmount[0];
	for (int j = 0; j < m; j++)
	{
        board[i, j] = inputAmount[j];
		if(beforeAmount - board[i,j] > 0)
			frontCount += beforeAmount - board[i,j];
		beforeAmount = board[i, j];
	}
	frontCount += board[i,m - 1];
}

int sideCount = 0;
for (int i = 0; i < m; i++)
{
    int beforeAmount = board[0,i];
    for (int j = 0; j < n; j++)
    {
        if (beforeAmount - board[j, i] > 0)
            sideCount += beforeAmount - board[j,i];
        beforeAmount = board[j,i];
    }
    sideCount += board[n - 1, i];
}

int ans = frontCount + sideCount + (n * m);
Console.WriteLine(ans * 2);
