// BOJ_10830


using System.Text;

StringBuilder sb = new StringBuilder();
long[] inputnb = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
long n = inputnb[0];
long b = inputnb[1];

long[,] board = new long[7, 7];
long[,] ans = new long[7, 7];
for (int i = 0; i < n; i++)
{
    int[] inputInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
	for (int j = 0; j < n; j++)
	{
		board[i, j] = inputInfo[j];
		ans[i, j] = inputInfo[j];
	}
}

b--;
while (b > 0)
{
    long[,] temp = new long[7, 7];
	if (b % 2 == 1)
	{
		for (int x = 0; x < n; x++)
		{
			for (int y = 0; y < n; y++)
			{
				int idx = 0;
				while (idx < n)
				{
					temp[x, y] += (board[x, idx] * ans[idx, y]) % 1000;
					temp[x, y] %= 1000;
					idx++;
				}
			}
		}
		ans = temp;
    }

    temp = new long[7, 7];
    for (int x = 0; x < n; x++)
    {
        for (int y = 0; y < n; y++)
        {
			for (int z = 0; z < n; z++)
            {
                temp[x, y] += (board[x, z] * board[z, y]) % 1000;
                temp[x, y] %= 1000;
            }
        }
    }
	board = temp;
	b /= 2;
}

for (int i = 0; i < n; i++)
{
	for (int j = 0; j < n;  j++)
	{
		sb.Append($"{ans[i, j] % 1000} ");
	}
	sb.AppendLine();
}

Console.WriteLine(sb);
