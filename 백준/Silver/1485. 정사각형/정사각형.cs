// BOJ_1485


using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
	List<Tuple<int,int>> listxy = new List<Tuple<int,int>>();
	List<long> length = new List<long>();
	for (int i = 0; i < 4; i++)
	{
		int[] inputxy = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
		int x = inputxy[0];
		int y = inputxy[1];
		listxy.Add(new Tuple<int, int>(x, y));
	}

	for (int i = 0; i < listxy.Count; i++)
	{
		var target = listxy[i];
		for (int j = i + 1; j < listxy.Count; j++)
			length.Add( ((target.Item1 - listxy[j].Item1) * (target.Item1 - listxy[j].Item1)) + ((target.Item2 - listxy[j].Item2) * (target.Item2 - listxy[j].Item2)));
	}

	length.Sort();
	if (length[0] == length[1] && length[1] == length[2] && length[2] == length[3] && length[3] == length[0] && length[4] == length[5])
		sb.AppendLine("1");
	else
		sb.AppendLine("0");
}

Console.WriteLine(sb);
