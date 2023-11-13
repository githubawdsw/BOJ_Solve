// BOJ_1939



int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

Dictionary<int,int>[] dict = new Dictionary<int, int>[10005];
for (int i = 0; i < m; i++)
{
    int[] infoabc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int a = infoabc[0];
    int b = infoabc[1];
    int c = infoabc[2];

    if (dict[a] == null)
        dict[a] = new Dictionary<int, int>();
    if(!dict[a].ContainsKey(b) || dict[a][b] < c)
        dict[a][b] = c;

    if (dict[b] == null)
        dict[b] = new Dictionary<int, int>();
    if (!dict[b].ContainsKey(b) || dict[b][a] < c)
        dict[b][a] = c;

}

int[] inputse = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int s = inputse[0];
int e = inputse[1];

int left = 1;
int right = 1000000000;
int ans = 0;
while (left <= right)
{
    int mid = (left + right) / 2;
    
    if (bfs(mid))
    {
        left = mid + 1;
        ans = mid;
    }
    else
        right = mid - 1;
}

Console.WriteLine(ans);


bool bfs(int mid)
{
    bool[] vis = new bool[10005];
    vis[s] = true;

    Queue<int> q = new Queue<int>();
    q.Enqueue(s);

    while (q.Count > 0)
    {
        var cur = q.Dequeue();
        if (cur == e)
            return true;
        foreach (var one in dict[cur])
        {
            if (!vis[one.Key] && one.Value >= mid)
            {
                vis[one.Key] = true;
                q.Enqueue(one.Key);
            }
        }
    }
    return false;
}