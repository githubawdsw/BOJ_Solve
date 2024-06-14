// BOJ_20300


int n = int.Parse(Console.ReadLine());
long[] inputLoss = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);

Array.Sort(inputLoss);

long min;
if(n % 2 == 1)
{
	int left = 0;
	int right = n - 2;

	min = inputLoss[n - 1];
	while (left < right)
	{
		min = Math.Max(inputLoss[left] + inputLoss[right], min);
        left++;
        right--;
	}
}
else
{
    int left = 0;
    int right = n - 1;

    min = 0;
    while (left < right)
    {
        min = Math.Max(inputLoss[left] + inputLoss[right], min);
        left++;
        right--;
    }
}

Console.WriteLine(min);