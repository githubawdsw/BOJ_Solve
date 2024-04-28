// BOJ_3151


int n = int.Parse(Console.ReadLine());
int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

Array.Sort(inputArr);

Console.WriteLine(Find());

long Find()
{
    long count = 0;

	for (int i = 0; i < n - 2; i++)
	{
		for (int j = i + 1; j < n - 1; j++)
		{
			int target = -(inputArr[i] + inputArr[j]);
			int start = j + 1;
			int end = n - 1;
			int idx1 = int.MaxValue;

			while (start <= end)
			{
				int mid = (start + end) / 2;
				if (inputArr[mid] >= target)
				{
					idx1 = mid;
					end = mid - 1;
				}
				else
					start = mid + 1;
			}

			int idx2 = int.MaxValue;
			start = j + 1;
			end = n - 1;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (inputArr[mid] <= target)
                {
                    idx2 = mid;
                    start = mid + 1;
                }
                else
                    end = mid - 1;
            }

			if (idx1 != int.MaxValue && idx2 != int.MaxValue)
				count += idx2 - idx1 + 1;
        }
	}

	return count;
}