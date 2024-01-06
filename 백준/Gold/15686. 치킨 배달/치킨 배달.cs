// BOJ_15686


int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = input[0];
int m = input[1];

List<(int, int)> chicken = new List<(int, int)>();
List<(int, int)> house = new List<(int, int)>();
bool[] check = new bool[15];
for (int i = 0; i < n; i++)
{
	input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
	for (int j = 0; j < n; j++)
	{
		if (input[j] == 1)
			house.Add((i, j));
		else if (input[j] == 2)
			chicken.Add((i, j));
	}
}

int ans = int.MaxValue;
Dfs(0,0);

Console.WriteLine(ans);


void Dfs(int depth, int idx)
{
	if(depth == m)
	{
		int sum = 0;
		for (int i = 0; i < house.Count; i++)
		{
			var one = house[i];
			int dis = int.MaxValue;
			for (int j = 0; j < chicken.Count; j++)
			{
				if (check[j])
				{
					var cur = chicken[j];
					int temp = Math.Abs(one.Item1 - cur.Item1) + Math.Abs(one.Item2 - cur.Item2);
					if (dis > temp)
						dis = temp;
				}
			}
			sum += dis;
		}
		if (ans > sum)
			ans = sum;
		return;
	}

	for (int i = idx; i < chicken.Count; i++)
	{
		if (check[i])
			continue;
		check[i] = true;
		Dfs(depth + 1, i);
		check[i] = false;
	}
}
