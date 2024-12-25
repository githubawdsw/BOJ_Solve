// BOJ_6068


int n = int.Parse(Console.ReadLine());

List<(int, int)> list = new List<(int, int)>();
for (int i = 0; i < n; i++)
{
    int[] inputts = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int t = inputts[0];
    int s = inputts[1];
    list.Add((t, s));
}

list = list.OrderByDescending(x => x.Item2).ToList();
int time = list[0].Item2;
for (int i = 1; i < list.Count; i++)
{
    time = Math.Min(list[i].Item2, time - list[i - 1].Item1);
}
time -= list.Last().Item1;
if(time < 0)
    Console.WriteLine(-1);
else
    Console.WriteLine(time);