// BOJ_2799


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

char[,] board = new char[505, 505];
int[] countArr = new int[8];

for (int i = 0; i < 5 * n + 1; i++)
{
	string inputArr = Console.ReadLine();
	for (int j = 0; j < 5 * m + 1; j++)
	{
		board[i, j] = inputArr[j];
	}
}

for (int i = 0; i < n; i++)
{
	for (int j = 0; j < m; j++)
	{
		int count = 0;
		for (int k = 0; k < 4; k++)
		{
			if (board[5 * i + 1 + k, 5 * j + 1] == '*')
				count++;
			else
				break;
		}
		countArr[count]++;
	}
}

for (int i = 0; i < 5; i++)
{
    Console.Write(countArr[i] + " ");
}