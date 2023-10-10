// BOJ_2018



int n = int.Parse(Console.ReadLine());

int left = 1;
int right = 2;
int count = 1;
while (left < right)
{
    int sum = 0;
	for (int i = left; i <= right; i++)
		sum += i;
	if (sum < n)
		right++;
	else if (sum > n)
		left++;
	else
	{
		count++;
		left++;
		right++;
	}
}

Console.WriteLine(	count );

