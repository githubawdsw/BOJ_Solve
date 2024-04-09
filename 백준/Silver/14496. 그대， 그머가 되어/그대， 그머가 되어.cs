// BOJ_14496


int[] inputab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int a = inputab[0];
int b = inputab[1];

int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

List<int>[] list = new List<int>[1005];
Queue<int> q = new Queue<int>();
bool[] vis = new bool[1005];
int[] dis = new int[1005];

for (int i = 0; i < m; i++)
{
    int[] inputLinkedNum = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int x = inputLinkedNum[0];
    int y = inputLinkedNum[1];
    if (x == y)
        continue;
    if(list[x] == null)
        list[x] = new List<int>();
    list[x].Add(y);

    if (list[y] == null)
        list[y] = new List<int>();
    list[y].Add(x);
}

vis[a] = true;
q.Enqueue(a);

while (q.Count > 0)
{
    var cur = q.Dequeue();
    if (cur == b)
        break;
    if (list[cur] == null)
        continue;
    foreach (var one in list[cur])
    {
        if (!vis[one])
        {
            vis[one] = true;
            dis[one] = dis[cur] + 1;
            q.Enqueue(one);
        }
    }
}

if (!vis[b])
    Console.WriteLine(-1);
else
    Console.WriteLine(dis[b]);