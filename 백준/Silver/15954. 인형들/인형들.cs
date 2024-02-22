// BOJ_15954


int[] inputnk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnk[0];
int k = inputnk[1];

int[] preferInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
double ans = double.MaxValue;
for (int i = k; i <= n; i++)
{
	for (int j = 0; j <= n - i; j++)
	{
		double m = 0;
		for (int x = 0; x < i; x++)
		{
			m += preferInfo[j + x];
		}
		m /= i;

		double S = 0;
		for (int y = 0; y < i; y++)
		{
			double value = preferInfo[j + y];
			S += (value - m) * (value - m);
		}
		S /= i;
		ans = Math.Min(ans, Math.Sqrt(S));
	}
}

Console.WriteLine(ans);