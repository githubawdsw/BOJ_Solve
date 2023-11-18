// BOJ_13424



using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
	int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
	int n = inputnm[0];
	int m = inputnm[1];

	List<Tuple<int, int>>[] relList = new List<Tuple<int, int>>[105];
	for (int i = 0; i < m; i++)
	{
		int[] inputabc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
		int a = inputabc[0];
		int b = inputabc[1];
		int c = inputabc[2];

		if (relList[a] == null)
			relList[a] = new List<Tuple<int, int>>();
		relList[a].Add(new Tuple<int, int>(b, c));
		if (relList[b] == null)
			relList[b] = new List<Tuple<int, int>>();
		relList[b].Add(new Tuple<int, int>(a, c));
	}

	int k = int.Parse(Console.ReadLine());
	int[] pos = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
	int[] dp;
	Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();

	for (int i = 0; i < pos.Length; i++)
	{
		dp = new int[105];
		Array.Fill(dp, int.MaxValue / 2);
		dp[pos[i]] = 0;
		PriorityQueue<Tuple<int, int>, int> pq = new PriorityQueue<Tuple<int, int>, int>();
		pq.Enqueue(new Tuple<int, int>(pos[i], 0), 0);

		while (pq.Count> 0)
		{
			var cur = pq.Dequeue();
			if (dp[cur.Item1] != cur.Item2)
				continue;
			if (relList[cur.Item1] == null)
				continue;
			foreach (var one in relList[cur.Item1])
			{
				if (dp[one.Item1] > one.Item2 + dp[cur.Item1])
				{
					dp[one.Item1] = one.Item2 + dp[cur.Item1];
					pq.Enqueue(new Tuple<int, int>(one.Item1, dp[one.Item1]), dp[one.Item1]);
                }
			}
		}

		for (int j = 1; j <= n; j++)
		{
			if (!dict.ContainsKey(j))
				dict[j] = new List<int>();
			dict[j].Add(dp[j]);
		}
    }

	int min = int.MaxValue;
	int ans = 0;
	foreach (var one in dict)
	{
		int sum = one.Value.Sum();
		if (sum < min)
		{
			min = sum;
			ans = one.Key;
		}
	}
	sb.AppendLine(ans.ToString());
}

Console.WriteLine(	sb );