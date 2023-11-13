// BOJ_17829


int n = int.Parse(Console.ReadLine());

int[,] board = new int[1050, 1050];
for (int i = 0; i < n; i++)
{
	string[] inputarr = Console.ReadLine().Split(' ');
	for (int j = 0; j < n; j++)
		board[i, j] = int.Parse(inputarr[j]);
}

int ans = Recursion(n , board);
Console.WriteLine(ans);


int Recursion(int size , int[,] matrix)
{
	if (size == 1)
		return matrix[0,0];

	int[,] newMatrix = new int[1050, 1050];
	for (int i = 0; i < size / 2; i++)
	{
		for (int j = 0; j < size / 2; j++)
		{
			List<int> list = new List<int>
			{
				matrix[2 * i, 2 * j],
				matrix[2 * i, 2 * j + 1],
				matrix[2 * i + 1, 2 * j],
				matrix[2 * i + 1, 2 * j + 1]
			};
			list.Sort();
			newMatrix[i, j] = list[2];
        }
	}

	return Recursion(size / 2, newMatrix);
}