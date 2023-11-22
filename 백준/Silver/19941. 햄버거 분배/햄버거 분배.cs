// BOJ_19941


int[] inputnk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnk[0];
int k = inputnk[1];

string arr = Console.ReadLine();
bool[] check = new bool[n + 5];
int ans = 0;
for (int i = 0; i < arr.Length; i++)
{
	if (arr[i] == 'P')
	{
		for (int j = i - k; j <= i + k; j++)
		{
			if (j < 0)
				j = 0;
			if (j >= n)
				break;

			if (arr[j] == 'H' && !check[j])
			{
				check[j] = true;
				ans++;
				break;
			}
		}
	}
}
Console.WriteLine(ans);