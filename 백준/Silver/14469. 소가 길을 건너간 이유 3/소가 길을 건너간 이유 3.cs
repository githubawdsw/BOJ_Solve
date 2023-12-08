// BOJ_14469


int n = int.Parse(Console.ReadLine());
List<(int,int)> list = new List<(int,int)> ();
for (int i = 0; i < n; i++)
{
    int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    list.Add(new(input[0], input[1]));
}

list = list.OrderBy(x => x.Item1).ToList();

int time = list[0].Item1 + list[0].Item2;
for (int i = 1;i < list.Count; i++)
{
    if (time < list[i].Item1)
        time = list[i].Item1 + list[i].Item2;
    else
        time += list[i].Item2;
}

Console.WriteLine(time);