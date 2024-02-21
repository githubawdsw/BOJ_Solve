// BOJ_6987


using System.Text;

StringBuilder sb = new StringBuilder();
List<(int, int, int)> list = new List<(int, int, int)>();
int ans;
for (int i = 0; i < 4; i++)
{
    int[] inputInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
	list.Clear();
	ans = 0;
	for (int j = 0; j < 18; j += 3)
	{
		list.Add((inputInfo[j], inputInfo[j + 1], inputInfo[j + 2]));
	}
	dfs(0, 1);
	sb.Append(ans.ToString() + " ");
}

Console.WriteLine(sb);


void dfs(int t1, int t2)
{
	if(t2 == 6)
	{
		t1 += 1;
		t2 = t1 + 1;
	}
	if(t1 == 5)
	{
		ans = 1;
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].Item1 != 0 || list[i].Item2 != 0 || list[i].Item3 != 0)
			{
				ans = 0;
				break;
			}
		}
		return;
	}

	var temp1 = list[t1];
	var temp2 = list[t2];
	if (list[t1].Item1 > 0 && list[t2].Item3 > 0)
	{
		temp1.Item1--;
		temp2.Item3--;
		list[t1] = temp1;
		list[t2] = temp2;

		dfs(t1, t2 + 1);

        temp1.Item1++;
        temp2.Item3++;
        list[t1] = temp1;
        list[t2] = temp2;
    }

    if (list[t1].Item3 > 0 && list[t2].Item1 > 0)
    {
        temp1.Item3--;
        temp2.Item1--;
        list[t1] = temp1;
        list[t2] = temp2;

        dfs(t1, t2 + 1);

        temp1.Item3++;
        temp2.Item1++;
        list[t1] = temp1;
        list[t2] = temp2;
    }
    if (list[t1].Item2 > 0 && list[t2].Item2 > 0)
    {
        temp1.Item2--;
        temp2.Item2--;
        list[t1] = temp1;
        list[t2] = temp2;

        dfs(t1, t2 + 1);

        temp1.Item2++;
        temp2.Item2++;
        list[t1] = temp1;
        list[t2] = temp2;
    }
}