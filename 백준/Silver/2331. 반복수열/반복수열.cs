// BOJ_2331


string[] inputap = Console.ReadLine().Split(' ');
string a = inputap[0];
int p = int.Parse(inputap[1]);

int[] check = new int[500000];

int ans = 1;
check[int.Parse(a)] = 1;
while (true)
{
	int sum = 0;
	for (int i = 0; i < a.Length; i++)
	{
		sum += (int)Math.Pow(a[i] - '0', p);
	}

	if (check[sum] > 0)
	{
		ans = check[sum] - 1;
		break;
	}

	check[sum] = ++ans;
	a = sum.ToString();
}

Console.WriteLine(ans);