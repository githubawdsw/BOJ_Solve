// BOJ_1120


string[] inputab = Console.ReadLine().Split(' ');
string a = inputab[0];
string b = inputab[1];

(int, int) minPos = (int.MaxValue, 0);
for (int i = 0; i <= b.Length - a.Length; i++)
{
	int count = 0;
	for (int j = 0; j < a.Length; j++)
	{
		if (a[j] != b[i + j])
			count++;
	}
	if (minPos.Item1 > count)
		minPos = (count, i);
}

Console.WriteLine(minPos.Item1);

