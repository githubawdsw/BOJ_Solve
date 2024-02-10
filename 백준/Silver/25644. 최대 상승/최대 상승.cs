// BOJ_25644


int n = int.Parse(Console.ReadLine());
int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int ans = 0;
int min = inputArr[0];
for (int i = 1; i < n; i++)
{
	min = Math.Min(min, inputArr[i]);
	if (inputArr[i] - min > 0)
		ans = Math.Max(ans, inputArr[i] - min);
}

Console.WriteLine(ans);
