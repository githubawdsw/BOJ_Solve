// BOJ_9421


using System.Text;

StringBuilder sb = new StringBuilder();
string n = Console.ReadLine();

bool[] notPrimeNum = new bool[1000005];
bool[] sanggeunNum = new bool[1000005];
sanggeunNum[4] = true;
for (int i = 2; i * i <= 1000000; i++)
{
	if (notPrimeNum[i])
		continue;
	for (int j = i * i; j <= 1000000; j += i)
	{
		notPrimeNum[j] = true;
	}
}

for (int i = 2; i < int.Parse(n); i++)
{
	if (notPrimeNum[i])
		continue;
	List<int> list = new List<int>();
	bool check = SangGeun(i, list);
	if (!check)
	{
		for (int j = 0; j < list.Count; j++)
		{
			sanggeunNum[list[j]] = true;
		}
	}
	else
		sb.AppendLine(i.ToString());
}

Console.WriteLine(sb);


bool SangGeun(int x, List<int> list)
{
	if (sanggeunNum[x])
		return false;
	if (x == 1)
		return true;

	list.Add(x);
	string target = x.ToString();
	int sum = 0;
	for (int i = 0; i < target.Length; i++)
	{
		sum += (target[i] - '0') * (target[i] - '0');
	}
	return SangGeun(sum, list);
}