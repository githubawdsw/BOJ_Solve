// BOJ_2548



int n = int.Parse(Console.ReadLine());
int[] inputinfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Array.Sort(inputinfo);

int target = inputinfo[0];
(int,int) before = new (0,int.MaxValue);
int ans = 0;
while (true)
{
    int sum = 0;
	for (int i = 0; i < n; i++)
		sum += Math.Abs(target - inputinfo[i]);
	if (sum < before.Item2)
		before = (target ,sum);
	else
	{
		ans = before.Item1;
		break;
	}
	target++;
}

Console.WriteLine(ans);