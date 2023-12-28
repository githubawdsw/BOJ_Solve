// BOJ_1713


using System.Text;

StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());
int totalRecommend = int.Parse(Console.ReadLine());

int[] inputInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

Dictionary<int, (int, int)> dict = new Dictionary<int, (int, int)>();
for (int i = 0; i < totalRecommend; i++)
{
    if (dict.ContainsKey(inputInfo[i]))
        dict[inputInfo[i]] = (dict[inputInfo[i]].Item1 + 1, dict[inputInfo[i]].Item2);
    else
    {
        if (dict.Count >= n)
        {
            dict = dict.OrderBy(x => x.Value.Item1).ToDictionary(x => x.Key, x => x.Value);
            var val = dict.First();
            int count = 0;
            int minIdx = int.MaxValue;
            foreach (var one in dict)
            {
                if (one.Value.Item1 > val.Value.Item1)
                    break;
                count++;

                minIdx = Math.Min(minIdx, one.Value.Item2);
            }

            foreach (var one in dict)
            {
                if (one.Value.Item2 == minIdx)
                {
                    dict.Remove(one.Key);
                    break;
                }
            }
        }
        dict.Add(inputInfo[i], (1, i));
    }
}

dict = dict.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
foreach (var one in dict)
{
    sb.Append($"{one.Key} ");
}

Console.WriteLine(sb);
