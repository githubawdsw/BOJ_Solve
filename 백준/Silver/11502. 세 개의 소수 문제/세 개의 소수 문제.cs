// BOJ_11502


using System.Text;

StringBuilder sb = new StringBuilder();

bool[] primeNumCheck = new bool[1005];
for (int i = 2; i * i < 1000; i++)
{
	if (primeNumCheck[i])
		continue;
	for (int j = i * i; j < 1000; j += i)
	{
		primeNumCheck[j] = true;
	}
}

int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int k = int.Parse(Console.ReadLine());

	bool isBreak = false;
	for (int a = 2; a < k; a++)
	{
		if (primeNumCheck[a])
			continue;
		for (int b = 2; b < k; b++)
		{
			if (primeNumCheck[b])
				continue;
			for (int c = 2; c < k; c++)
			{
				if (primeNumCheck[c])
					continue;

				if(a + b + c == k)
				{
					sb.AppendLine($"{a} {b} {c}");
					isBreak = true;
					break;
				}
			}
			if (isBreak)
				break;
		}
		if (isBreak)
			break;
	}

}

Console.WriteLine(sb);