// BOJ_1689


int n = int.Parse(Console.ReadLine());
List<(int, bool)> list = new List<(int, bool)>();
for (int i = 0; i < n; i++)
{
    int[] inputLineInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    list.Add((inputLineInfo[0], true));
    list.Add((inputLineInfo[1], false));
}

list = list.OrderBy(x => x.Item1).ThenBy(x => x.Item2).ToList();

int ans = 0;
int count = 0;
foreach (var one in list)
{
    if (one.Item2)
    {
        count++;
    }
    else
    {
        count--;
    }
    ans = Math.Max(ans, count);
}

Console.WriteLine(ans);
