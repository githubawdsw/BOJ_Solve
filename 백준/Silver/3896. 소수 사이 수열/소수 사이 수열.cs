// BOJ_3896


using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());

bool[] notPrimeNum = new bool[1300001];
for (int i = 2; i <= 1300000; i++)
{
	if (notPrimeNum[i])
		continue;
	for (int j = i + i; j <= 1300000; j += i)
	{
		notPrimeNum[j] = true;
	}
}
while (t-- > 0)
{
    int k = int.Parse(Console.ReadLine());
	if (!notPrimeNum[k])
		sb.AppendLine("0");
	else
	{
		int idx = k;
		while (notPrimeNum[idx])
		{
			idx++;
		}
        while (notPrimeNum[k])
        {
            k--;
        }
		sb.AppendLine($"{idx - k}");
    }
}

Console.WriteLine(sb);
