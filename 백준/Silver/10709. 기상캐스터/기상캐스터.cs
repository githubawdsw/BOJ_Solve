// BOJ_10709


using System.Text;

StringBuilder sb = new StringBuilder();
int[] inputhw = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int h = inputhw[0];
int w = inputhw[1];

int[,] ans = new int[105, 105];

for (int i = 0; i < h; i++)
{
	for (int j = 0; j < w; j++)
	{
		ans[i, j] = -1;
	}
}

for (int i = 0; i < h; i++)
{
	string inputInfo = Console.ReadLine();
	for (int j = 0; j < w; j++)
	{
		if (inputInfo[j] == 'c')
			MoveCloud(i, j);
	}
}

for (int i = 0; i < h; i++)
{
	for (int j = 0; j < w; j++)
	{
		sb.Append($"{ans[i, j]} ");
	}
	sb.AppendLine();
}

Console.WriteLine(sb);


void MoveCloud(int x , int y)
{
	ans[x, y] = 0;
	for (int i = y + 1; i < w; i++)
	{
		ans[x, i] = ans[x, i - 1] + 1;
	}
}