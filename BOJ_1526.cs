// BOJ_1526


int n = int.Parse(Console.ReadLine());

int ans = 0;
for (int i = 4; i <= n; i++)
{
    string num = i.ToString();
	bool check = true;
	for (int j = 0; j < num.Length; j++)
	{
		if (num[j] != '4' && num[j] != '7')
		{
			check = false;
			break;
		}
	}
    if (check)
		ans = i;
}
Console.WriteLine(	ans );

