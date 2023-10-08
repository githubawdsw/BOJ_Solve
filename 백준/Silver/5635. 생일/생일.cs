// BOJ_5635



int n = int.Parse(Console.ReadLine());

Dictionary<string, Tuple<int, int, int>> dict = new Dictionary<string, Tuple<int, int, int>>();
for (int i = 0; i < n; i++)
{
    string[] inputinfo = Console.ReadLine().Split(' ');
    string name = inputinfo[0];
    int dd = int.Parse(inputinfo[1]);
    int mm = int.Parse(inputinfo[2]);
    int yy = int.Parse(inputinfo[3]);
    dict.Add(name, new Tuple<int, int, int>(yy, mm, dd));
}

dict = dict.OrderBy(x => x.Value.Item1).ThenBy(x => x.Value.Item2).
    ThenBy(x => x.Value.Item3).ToDictionary(x => x.Key, y => y.Value);

Console.WriteLine(  dict.Last().Key);
Console.WriteLine(  dict.First().Key);
