// BOJ_1411


int n = int.Parse(Console.ReadLine());

List<string> list = new List<string>();
for (int i = 0; i < n; i++)
{
    list.Add(Console.ReadLine());
}

int ans = 0;

for (int i = 0; i < n; i++)
{
	for (int j = i + 1; j < n; j++)
	{
		var target1 = list[i];
		var target2 = list[j];

		int length = target1.Length;

		int[] vis1 = new int[30];
		int[] vis2 = new int[30];
		bool check = true;

		for (int k = 0; k < length; k++)
		{
			if (vis1[target1[k] - 'a' + 1] == 0 && vis2[target2[k] - 'a' + 1] == 0)
			{
				vis1[target1[k] - 'a' + 1] = target2[k] - 'a' + 1;
				vis2[target2[k] - 'a' + 1] = target1[k] - 'a' + 1;
			}
			else if (vis1[target1[k] - 'a' + 1] == target2[k] - 'a' + 1)
				continue;
			else
			{
				check = false;
				break;
			}
		}
		if (check)
			ans++;
	}
}

Console.WriteLine(ans);