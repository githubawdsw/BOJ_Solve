// BOJ_17073


int[] inputnw = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnw[0];
int w = inputnw[1];

List<int>[] list = new List<int>[500005];
bool[] vis = new bool[500005];
bool[] leaf = new bool[500005];

for (int i = 0; i < n - 1; i++)
{
    int[] inputuv = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int u = inputuv[0];
    int v = inputuv[1];

    if (list[u] == null)
        list[u] = new List<int>();
    list[u].Add(v);

    if (list[v] == null)
        list[v] = new List<int>();
    list[v].Add(u);
}

Queue<int> q =  new Queue<int>();
vis[1] = true;
q.Enqueue(1);

while (q.Count > 0)
{
    var cur = q.Dequeue();

    foreach (var one in list[cur])
    {
        if (vis[one])
            continue;
        leaf[cur] = true;
        vis[one] = true;
        q.Enqueue(one);
    }
}

double count = 0;
for (int i = 1; i <= n; i++)
{
    if (!leaf[i])
        count++;
}
double ans = w / count;

Console.WriteLine(ans);