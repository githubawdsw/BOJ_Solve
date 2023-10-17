// BOJ_7568




using System.Text;

StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());
List<Tuple<int, int, int>> tupleList = new List<Tuple<int, int, int>>();
for (int i = 0; i < n; i++)
{
    int[] inputxy = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int x = inputxy[0];
    int y = inputxy[1];
    tupleList.Add(new Tuple<int, int, int>(x, y , i+1));
}

tupleList = tupleList.OrderByDescending(x => x.Item1).ThenByDescending(x=>x.Item2).ToList();

int[] rank = new int[55];
rank[tupleList[0].Item3] = 1;

for (int i = 1; i < n; i++)
{
    int h = tupleList[i].Item2;
    int m = tupleList[i].Item1;
    int count = 1;
    for (int j = 0; j < n; j++)
    {
        if (i == j)
            continue;
        if (tupleList[j].Item2 > h && tupleList[j].Item1 > m)
            count++;
    }
    rank[tupleList[i].Item3] = count;
}

for (int i = 1; i <= n; i++)
    sb.Append($"{rank[i]} ");

Console.WriteLine(  sb );