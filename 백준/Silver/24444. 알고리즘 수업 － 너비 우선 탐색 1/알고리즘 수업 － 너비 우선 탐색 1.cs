// BOJ_24444

using System.Text;

StringBuilder sb = new StringBuilder();

string[] inputnmr = Console.ReadLine().Split(' ');
int n = int.Parse(inputnmr[0]);
int m = int.Parse(inputnmr[1]);
int r = int.Parse(inputnmr[2]);

List<int>[] arrList = new List<int>[100005];
int count = 1;
int[] vis = new int[100005];

for (int i = 0; i < m; i++)
{
    string[] inputuv = Console.ReadLine().Split(' ');
    int u = int.Parse(inputuv[0]);
    int v = int.Parse(inputuv[1]);
    if (arrList[u] == null)
        arrList[u] = new List<int>();
    arrList[u].Add(v);
    if (arrList[v] == null)
        arrList[v] = new List<int>();
    arrList[v].Add(u);
}
for (int i = 0; i <= n; i++)
    if (arrList[i] != null)
        arrList[i].Sort();

Queue<int> q = new Queue<int>();
q.Enqueue(r);
vis[r] = count++;

while (q.Count != 0)
{
    var cur = q.Dequeue();

    foreach (var one in arrList[cur])
    {
        if (vis[one] > 0)
            continue;
        vis[one] = count++;
        q.Enqueue(one);
    }
}

for (int i = 1; i <= n; i++)
    sb.AppendLine(vis[i].ToString());

Console.WriteLine(  sb);
