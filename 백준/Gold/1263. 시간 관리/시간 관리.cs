// BOJ_1263


int n = int.Parse(Console.ReadLine());
List<(int, int)> list = new List<(int, int)>();
for (int i = 0; i < n; i++)
{
    int[] inputts = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    list.Add((inputts[0], inputts[1]));
}

list = list.OrderBy(x => x.Item2).ToList();
int time = 0;
int ans = int.MaxValue;
for (int i = 0; i < n; i++)
{
    time += list[i].Item1;
    if(list[i].Item2 - time < 0)
    {
        ans = -1;
        break;
    }

    ans = Math.Min(ans, list[i].Item2 - time);
}

Console.WriteLine(ans);