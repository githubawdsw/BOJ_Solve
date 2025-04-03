// BOJ_3495


int[] inputhw = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int h = inputhw[0];
int w = inputhw[1];

int ans = 0;
for (int i = 0; i < h; i++)
{
	string shape = Console.ReadLine();
	bool check = false;
	int sum = 0;
	for (int j = 0; j < w; j++)
	{
		if (shape[j] != '.')
		{
			sum++;
			check = check == true ? false : true;
		}
		else if (check && shape[j] == '.')
		{
			sum += 2;
		}
	}
	ans += sum;
}

Console.WriteLine(ans / 2);