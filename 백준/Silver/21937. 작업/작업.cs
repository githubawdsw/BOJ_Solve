// BOJ_21937


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

List<int>[] list = new List<int>[100005];
for (int i = 0; i < m; i++)
{
    int[] inputab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int a = inputab[0];
    int b = inputab[1];

    if (list[b] == null)
        list[b] = new List<int>();
    list[b].Add(a);
}

int x = int.Parse(Console.ReadLine());

Queue<int> q =  new Queue<int>();
bool[] vis = new bool[100005];
q.Enqueue(x);
vis[x] = true;
int ans = 0;
while (q.Count > 0)
{
    var cur = q.Dequeue();

    if (list[cur] == null)
        continue;
    foreach (var one in list[cur])
    {
        if (vis[one])
            continue;
        vis[one] = true;
        q.Enqueue(one);
        ans++;
    }
}

Console.WriteLine(ans);