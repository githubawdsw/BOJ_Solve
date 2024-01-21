// BOJ_2659


int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

SortedSet<int> ss = new SortedSet<int>();
for (int i = 1; i < 10; i++)
{
	for (int j = 1; j < 10; j++)
	{
		for (int x = 1; x < 10; x++)
		{
			for (int y = 1; y < 10; y++)
			{
				int min = int.MaxValue;
				min = Math.Min(min, i * 1000 + j * 100 + x * 10 + y);
				min = Math.Min(min, j * 1000 + x * 100 + y * 10 + i);
				min = Math.Min(min, x * 1000 + y * 100 + i * 10 + j);
				min = Math.Min(min, y * 1000 + i * 100 + j * 10 + x);
				ss.Add(min);
			}
		}
	}
}

int compare = int.MaxValue;
compare = Math.Min(compare, input[0] * 1000 + input[1] * 100 + input[2] * 10 + input[3]);
compare = Math.Min(compare, input[1] * 1000 + input[2] * 100 + input[3] * 10 + input[0]);
compare = Math.Min(compare, input[2] * 1000 + input[3] * 100 + input[0] * 10 + input[1]);
compare = Math.Min(compare, input[3] * 1000 + input[0] * 100 + input[1] * 10 + input[2]);
int count = 0;
foreach (var one in ss)
{
	count++;
	if(one == compare)
	{
        Console.WriteLine(count);
		return;
    }	
}