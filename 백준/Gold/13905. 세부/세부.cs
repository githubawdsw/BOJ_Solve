// BOJ_13905


string[] inputnm = Console.ReadLine().Split(' ');
int n = int.Parse(inputnm[0]);
int m = int.Parse(inputnm[1]);

string[] inputse = Console.ReadLine().Split(' ');
int s = int.Parse(inputse[0]);
int e = int.Parse(inputse[1]);

int[] par = new int[100005];
List<(int, int, int)> info = new List<(int, int, int)>();
int[] weight = new int[100005];
List<(int, int)>[] list = new List<(int, int)>[100005];

for (int i = 0; i < m; i++)
{
    string[] inputhk = Console.ReadLine().Split(' ');
    int h1 = int.Parse(inputhk[0]);
    int h2 = int.Parse(inputhk[1]);
    int k = int.Parse(inputhk[2]);

    info.Add((h1, h2, k));
}

info = info.OrderByDescending(x => x.Item3).ToList();
for (int i = 0; i < m; i++)
{
    var cur = info[i];
    if (!IsDiffGroup(cur.Item1, cur.Item2))
        continue;

    if (list[cur.Item1] == null)
        list[cur.Item1] = new List<(int, int)>();
    list[cur.Item1].Add((cur.Item2, cur.Item3));

    if (list[cur.Item2] == null)
        list[cur.Item2] = new List<(int, int)>();
    list[cur.Item2].Add((cur.Item1, cur.Item3));
}

Queue<int> q = new Queue<int>();
q.Enqueue(s);
Array.Fill(weight, int.MaxValue);

while (q.Count > 0)
{
    var cur = q.Dequeue();
    if (list[cur] == null)
        continue;

    foreach (var one in list[cur])
    {
        if (weight[one.Item1] != int.MaxValue)
            continue;
        weight[one.Item1] = Math.Min(one.Item2, weight[cur]);
        q.Enqueue(one.Item1);
    }
}

if (weight[e] != int.MaxValue)
    Console.WriteLine(weight[e]);
else
    Console.WriteLine("0");


bool IsDiffGroup(int a, int b)
{
    a = Find(a); b = Find(b);
    if (a == b)
        return false;
    if (par[a] == par[b])
        par[a]--;

    if (par[a] < par[b])
        par[b] = a;
    else
        par[a] = b;
    return true;
}

int Find(int x)
{
    if (par[x] <= 0)
        return x;
    return par[x] = Find(par[x]);
}