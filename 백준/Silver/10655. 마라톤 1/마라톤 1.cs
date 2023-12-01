// BOJ_10655



int n = int.Parse(Console.ReadLine());

List<Tuple<int, int>> list = new List<Tuple<int, int>>();
for (int i = 0; i < n; i++)
{
    int[] inputxy = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int x = inputxy[0];
    int y = inputxy[1];
    list.Add(new Tuple<int, int>(x, y));
}

List<int> lengthList = new List<int>();
int sum = 0;
for (int i = 1; i < n; i++)
{
    int length = Math.Abs(list[i].Item1 - list[i - 1].Item1) + Math.Abs(list[i].Item2 - list[i - 1].Item2);
    lengthList.Add(length);
    sum += length;
}

int ans = int.MaxValue;
for (int i = 0; i < lengthList.Count - 1; i++)
{
     int value = sum - lengthList[i]  - lengthList[i + 1] + Math.Abs(list[i].Item1 - list[i + 2].Item1) + Math.Abs(list[i].Item2 - list[i + 2].Item2);
    ans = Math.Min(ans, value);
}

Console.WriteLine(ans);
