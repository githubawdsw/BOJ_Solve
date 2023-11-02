// BOJ_16928


string[] inputnm = Console.ReadLine().Split(' ');
int n = int.Parse(inputnm[0]);
int m = int.Parse(inputnm[1]);
int[] Transport = new int[110];
int[] dis = new int[110];
Queue<int> q = new Queue<int>();

for (int i = 0; i < n; i++)
{
    string[] inputxy = Console.ReadLine().Split(" ");
    int x = int.Parse(inputxy[0]);
    int y = int.Parse(inputxy[1]);
    Transport[x] = y;
}

for (int i = 0; i < m; i++)
{
    string[] inputuv = Console.ReadLine().Split(' ');
    int u = int.Parse(inputuv[0]);
    int v = int.Parse(inputuv[1]);
    Transport[u] = v;
}

q.Enqueue(1);
while (q.Count > 0)
{
    var cur = q.Dequeue();
    if (cur > 100)
        continue;
    else if (cur == 100)
        break;
    for (int i = 1; i <= 6; i++)
    {
        int pos = cur + i;
        if (Transport[pos] != 0)
            pos = Transport[pos];
        if (dis[pos] > 0)
            continue;
        dis[pos] = dis[cur] + 1;
        q.Enqueue(pos);
    }
}

Console.WriteLine(dis[100]);

