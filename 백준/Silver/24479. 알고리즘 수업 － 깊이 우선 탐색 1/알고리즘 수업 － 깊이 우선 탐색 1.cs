// BOJ_24479

using System.Text;

StringBuilder sb = new StringBuilder();
int[] vis = new int[100005];
List<int>[] arrList = new List<int>[100005];
int count = 1;

string[] inputnmr = Console.ReadLine().Split(' ');
int n = int.Parse(inputnmr[0]);
int m = int.Parse(inputnmr[1]);
int r = int.Parse(inputnmr[2]);

for (int i = 0; i < m; i++)
{
    string[] inputuv = Console.ReadLine().Split(" ");
    int u = int.Parse(inputuv[0]);
    int v = int.Parse(inputuv[1]);
    if (arrList[u] == null)
        arrList[u] = new List<int>();
    arrList[u].Add(v);
    if (arrList[v] == null)
        arrList[v] = new List<int>();
    arrList[v].Add(u);
}
for (int i = 0; i < arrList.Length; i++)
    if (arrList[i] != null)
        arrList[i].Sort();

dfs( r );
for (int i = 1; i <= n; i++)
    sb.AppendLine(vis[i].ToString());

Console.WriteLine(  sb);

void dfs(int  num)
{
    if (vis[num] == 0)
        vis[num] = count++;
    if (arrList[num] == null)
        return;
    foreach (var one in arrList[num])
        if (vis[one] == 0)
            dfs(one);
}