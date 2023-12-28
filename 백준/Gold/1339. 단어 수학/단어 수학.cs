// BOJ_1339


using System.Text;

StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());
List<string> list = new List<string>();
Dictionary<char, int> dictAssign = new Dictionary<char, int>();
Dictionary<char, int> dictValue = new Dictionary<char, int>(); 
int value = 9;
for (int i = 0; i < n; i++)
{
    string inputstr = Console.ReadLine();
    list.Add(inputstr);
	for (int j = 0; j < inputstr.Length; j++)
	{
		if (!dictAssign.ContainsKey(inputstr[j]))
            dictAssign[inputstr[j]] = (int)Math.Pow(10, inputstr.Length - j);
		else
            dictAssign[inputstr[j]] += (int)Math.Pow(10, inputstr.Length - j);
    }
}

dictAssign = dictAssign.OrderByDescending(x=>x.Value).ToDictionary(x => x.Key, x => x.Value);
foreach (var one in dictAssign)
{
    dictValue[one.Key] = value--;
}


int ans = 0;
for (int i = 0; i < list.Count; i++)
{
    sb.Clear();
    for (int j = 0; j < list[i].Length; j++)
    {
        sb.Append(dictValue[list[i][j]]);
    }
    ans += int.Parse(sb.ToString());
}

Console.WriteLine(ans);