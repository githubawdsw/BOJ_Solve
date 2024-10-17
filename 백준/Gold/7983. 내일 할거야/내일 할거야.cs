// BOJ_7983


int n = int.Parse(Console.ReadLine());

List<(int, int)> list = new List<(int, int)>();

for (int i = 0; i < n; i++)
{
    int[] inputdt = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int d = inputdt[0];
    int t = inputdt[1];
    list.Add((d, t));
}

list = list.OrderByDescending(x => x.Item2).ToList();

int end = list[0].Item2;
for (int i = 0; i < list.Count; i++)
{
    var cur = list[i];
    if (cur.Item2 < end)
        end = cur.Item2;
    end -= cur.Item1;
}

Console.WriteLine(end);