// BOJ_1141



int n = int.Parse(Console.ReadLine());
List<string> strList = new List<string>();
for (int i = 0; i < n; i++)
    strList.Add(Console.ReadLine());

strList.Sort();

int ans = 1;

for (int i = 0; i < n; i++)
{
	string target = strList[i];
	bool check = true;
	for (int j = i + 1; j < n; j++)
	{
		string compare = strList[j];
		for (int k = 0; k < compare.Length && k < target.Length; k++)
		{
			if (compare[k] != target[k])
			{
				check = false;
				break;
			}
		}
		if (check)
			break;
	}
	if (!check)
		ans++;
}

Console.WriteLine(ans);
