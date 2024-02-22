// BOJ_10166


int[] inputd = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int d1 = inputd[0];
int d2 = inputd[1];

HashSet<double> hs = new HashSet<double>();
for (int i = d1; i <= d2; i++)
{
	for (int j = 1; j <= i; j++)
	{
		hs.Add((double)j / i);
	}
}

Console.WriteLine(hs.Count);

