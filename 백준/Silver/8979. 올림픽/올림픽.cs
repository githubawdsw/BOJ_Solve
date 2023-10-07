// BOJ_8979



string[] inputnk = Console.ReadLine().Split(' ');
int n = int.Parse(inputnk[0]);
int k = int.Parse(inputnk[1]);

Dictionary<int, Tuple<int, int, int>> dict = new Dictionary<int, Tuple<int, int, int>>();
for (int i = 0; i < n; i++)
{
    string[] inputInfo = Console.ReadLine().Split(' ');
    int country = int.Parse(inputInfo[0]);
    int gold = int.Parse(inputInfo[1]);
    int siver = int.Parse(inputInfo[2]);
    int bronze = int.Parse(inputInfo[3]);
    dict.Add(country, new Tuple<int, int, int>(gold, siver, bronze));
}
dict = dict.OrderByDescending(x => x.Value.Item1).ThenByDescending(x=>x.Value.Item2)
    .ThenByDescending(x=>x.Value.Item3).ToDictionary(x => x.Key, y => y.Value);

int[] rank = new int[1005];
int count = 1;
KeyValuePair<int,Tuple<int,int,int>> before = dict.First();
foreach (var one in dict)
{
    if (before.Value.Item1 == one.Value.Item1 && before.Value.Item2 == one.Value.Item2 && before.Value.Item3 == one.Value.Item3)
    {
        if (rank[before.Key] == 0)
            rank[one.Key] = 1;
        rank[one.Key] = rank[before.Key];
    }
    else
    {
        rank[one.Key] = count;
        before = one;
    }
    count++;

    if(one.Key == k)
    {
        Console.WriteLine(rank[k]);
        return;
    }
}
