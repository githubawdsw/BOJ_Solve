// BOJ_16719


using System.Text;

StringBuilder sb = new StringBuilder();
string str = Console.ReadLine();
bool[] vis = new bool[105];
for (int i = 0; i < str.Length; i++)
{
    List<Tuple<string, int>> list = new List<Tuple<string, int>>();
	for (int j = 0; j < str.Length; j++)
	{
		if (!vis[j])
		{
			string temp = "";
			for (int k = 0; k < str.Length; k++)
				if(j == k || vis[k])
					temp += str[k];
			list.Add(new Tuple<string, int>(temp, j));
		}
	}
	list.Sort();
	sb.AppendLine(list[0].Item1);
	vis[list[0].Item2] = true;
}
Console.WriteLine(	sb);

