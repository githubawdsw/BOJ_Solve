// BOJ_1027



int n = int.Parse(Console.ReadLine());
int[] inputlength = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int ans = 0;
for (int i = 0; i < n; i++)
{
	int count = 0;
	for (int j = 0; j < n; j++)
	{
		if (i == j)
			continue;
		if (check(inputlength[i], inputlength[j], i, j))
			count++;
	}
	ans = Math.Max(ans, count);
}

Console.WriteLine(ans);


bool check(double h1, double h2 , double x1, double x2)
{
	double height = int.MaxValue / 2;
	for (int i = 0; i < n; i++)
	{
		if (x1 == x2)
			continue;
		if ((i > x1 && i < x2) || (i > x2 && i < x1))
		{
            height = h1 + ((h2 - h1) * (i - x1) / (x2 - x1));
			if (inputlength[i] >= height)
				return false;
		}
	}
	return true;
}
