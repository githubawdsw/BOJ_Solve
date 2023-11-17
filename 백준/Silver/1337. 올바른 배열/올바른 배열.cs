// BOJ_1337


int n = int.Parse(Console.ReadLine());
List<int> list = new List<int>();
for (int i = 0; i < n; i++)
    list.Add(int.Parse(Console.ReadLine()));
list.Sort();

int ans = 5;
for (int i = 0; i < n; i++)
{
	int count = 0;
	for (int j = 1; j < 5; j++)
	{
		if (i + j >= list.Count)
			continue;
		if (list[i + j] - list[i] < 5)
			count++;
	}
	ans = Math.Min(ans, 4 - count);
}

Console.WriteLine(ans);
