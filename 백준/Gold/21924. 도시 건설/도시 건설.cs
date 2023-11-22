// BOJ_21924


string[] inputnm = Console.ReadLine().Split(' ');
int n = int.Parse(inputnm[0]);  
int m = int.Parse(inputnm[1]);

List<Tuple<int, int, int>> tupleList = new List<Tuple<int, int, int>>();
int[] par = new int[100005];

List<int>[] arrList = new List<int>[100005];
bool[] vis = new bool[n + 5];
Queue<int> q= new Queue<int>();

long max = 0;
for (int i = 0; i < m; i++)
{
    string[] inputinfo = Console.ReadLine().Split(" ");
    int a = int.Parse(inputinfo[0]);
    int b = int.Parse(inputinfo[1]);
    int c = int.Parse(inputinfo[2]);
    max += c;
    tupleList.Add(new Tuple<int, int, int>(c, a, b));
    if (arrList[a] == null)
        arrList[a] = new List<int>();
    arrList[a].Add(b);
    if (arrList[b] == null)
        arrList[b] = new List<int>();
    arrList[b].Add(a);
}

tupleList.Sort();
List<Tuple<int, int, int>> copy = tupleList.ToList();
long cost = 0;
int count = 0;

vis[1] = true;
q.Enqueue(1);
while (q.Count > 0)
{
    var cur = q.Dequeue();
    foreach (var one in arrList[cur])
    {
        if (vis[one])
            continue;
        vis[one] = true;
        q.Enqueue(one);
    }
}

for (int j = 0; j < copy.Count; j++)
{
    var cur = copy[j];
    if (!is_diff_group(cur.Item2, cur.Item3))
        continue;
    cost += cur.Item1;
    count++;
    if (count == n - 1)
        break;
}

for (int i = 1; i <= n; i++)
    if (!vis[i])
    {
        Console.WriteLine(  -1);
        return;
    }

Console.WriteLine( max - cost);


bool is_diff_group(int a , int b)
{
    a = find(a); b = find(b);
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

int find(int x )
{
    if (par[x] <= 0)
        return x;
    return par[x] = find(par[x]);
}