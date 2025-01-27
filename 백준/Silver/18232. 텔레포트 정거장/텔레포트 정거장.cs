// BOJ_18232


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

int[] inputse = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int s = inputse[0];
int e = inputse[1];

Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
int[] dis = new int[300005];
for (int i = 0; i < m; i++)
{
    int[] inputxy = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int x = inputxy[0];
    int y = inputxy[1];

    if (!dict.ContainsKey(x))
        dict.Add(x, new List<int>());
    dict[x].Add(y);

    if(!dict.ContainsKey(y))
        dict.Add(y, new List<int>());
    dict[y].Add(x);
}

Queue<int> q = new Queue<int>();
q.Enqueue(s);

while (q.Count > 0)
{
    var cur = q.Dequeue();
    if(cur == e)
        break;
    if(cur + 1 <= n)
        Move(cur, cur + 1);

    if(cur - 1 > 0)
        Move(cur, cur - 1);

    if (dict.ContainsKey(cur))
    {
        for (int i = 0; i < dict[cur].Count; i++)
        {
            Move(cur, dict[cur][i]);
        }
    }
}

Console.WriteLine(dis[e]);

void Move(int cur, int next)
{
    if (dis[next] > 0)
        return;

    dis[next] = dis[cur] + 1;
    q.Enqueue(next);
}