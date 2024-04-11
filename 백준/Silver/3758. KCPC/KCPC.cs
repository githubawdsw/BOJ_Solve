// BOJ_3758


using System.Text;

StringBuilder sb = new StringBuilder();
int T = int.Parse(Console.ReadLine());

while (T-- > 0)
{
    int[] inputnktm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int n = inputnktm[0];
    int k = inputnktm[1];
    int t = inputnktm[2];
    int m = inputnktm[3];

    Dictionary<int, int> sumDict = new Dictionary<int, int>();
    Dictionary<int, int> countDict = new Dictionary<int, int>();
    Dictionary<int, int> lastTimeDict = new Dictionary<int, int>();
    Dictionary<(int, int), (int, int)> solvedDict = new Dictionary<(int, int), (int, int)>();
    for (int a = 0; a < m; a++)
    {
        int[] inputijs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int i = inputijs[0];
        int j = inputijs[1];
        int s = inputijs[2];

        if (!countDict.ContainsKey(i))
            countDict.Add(i, 0);
        countDict[i]++;
        lastTimeDict[i] = a;

        if (!solvedDict.ContainsKey((i, j)))
            solvedDict[(i, j)] = (s, a);
        else
        {
            if(solvedDict[(i, j)].Item1 < s)
                solvedDict[(i, j)] = (s, a);
        }
    }
    foreach (var one in solvedDict)
    {
        var key = one.Key;
        var value = one.Value;

        if (!sumDict.ContainsKey(key.Item1))
            sumDict.Add(key.Item1, 0);
        sumDict[key.Item1] += value.Item1;
    }

    Dictionary<int, (int, int, int)> dict = new Dictionary<int, (int, int, int)>();
    foreach (var one in sumDict)
    {
        var key = one.Key;
        dict.Add(key, (one.Value, countDict[key], lastTimeDict[key]));
    }
    dict = dict.OrderByDescending(x => x.Value.Item1).ThenBy(x => x.Value.Item2).ThenBy(x => x.Value.Item3).ToDictionary(x => x.Key, y => y.Value);

    int ans = 0;
    int count = 0;
    foreach (var one in dict)
    {
        count++;
        if (one.Key == t)
        {
            ans = count;
            break;
        }
    }
    sb.AppendLine(ans.ToString());
}

Console.WriteLine(sb);