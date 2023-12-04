// BOJ_1198


int n = int.Parse(Console.ReadLine());

List<Tuple<int,int>> list = new List<Tuple<int,int>>();
for (int i = 0; i < n; i++)
{
    int[] inputxy = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int x = inputxy[0];
    int y = inputxy[1];
    list.Add(new Tuple<int, int>(x, y));
}

double ans = 0;
for (int i = 0; i < n; i++)
{
    for (int j = i + 1; j < n; j++)
    {
        for (int k = j + 1; k < n; k++)
        {
            double line1 = Math.Sqrt(Math.Pow(list[i].Item2 - list[j].Item2, 2) + Math.Pow(list[i].Item1 - list[j].Item1, 2));
            double line2 = Math.Sqrt(Math.Pow(list[i].Item2 - list[k].Item2, 2) + Math.Pow(list[i].Item1 - list[k].Item1, 2));
            double line3 = Math.Sqrt(Math.Pow(list[j].Item2 - list[k].Item2, 2) + Math.Pow(list[j].Item1 - list[k].Item1, 2));

            double s = (line1 + line2 + line3) / 2;
            ans = Math.Max(ans, Math.Sqrt(s * (s - line1) * (s - line2) * (s - line3)));
        }
    }
}

Console.WriteLine(ans);
