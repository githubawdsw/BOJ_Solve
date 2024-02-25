// BOJ_14719


int[] inputhw = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int h = inputhw[0];
int w = inputhw[1];

int[] inputBlock = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

// left
int left = 0;
int ans = 0;

while (left < w)
{
	int sum = 0;
	bool check = false;
	for (int i = left + 1; i < w; i++)
	{
		if (inputBlock[i] >= inputBlock[left])
		{
			check = true;
			left = i;
			break;
		}
		else
			sum += inputBlock[left] - inputBlock[i];
    }
    if (check)
        ans += sum;
    else
        break;
}

int right = w - 1;
while (right >= 0)
{
    int sum = 0;
    bool check = false;
    for (int i = right - 1; i >= 0; i--)
    {
        if (inputBlock[i] > inputBlock[right])
        {
            check = true;
            right = i;
            break;
        }
        else
            sum += inputBlock[right] - inputBlock[i];
    }
    if (check)
        ans += sum;
    else
        break;
}

Console.WriteLine(ans);