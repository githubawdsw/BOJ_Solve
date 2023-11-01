// BOJ_13023


string[] inputnm = Console.ReadLine().Split(' ');
int n = int.Parse(inputnm[0]);
int m = int.Parse(inputnm[1]);

List<int>[] arrList = new List<int>[2005];
bool[] vis;
for (int i = 0; i < m; i++)
{
    string[] inputab = Console.ReadLine().Split(' ');
    int a = int.Parse(inputab[0]);
    int b = int.Parse(inputab[1]);

    if (arrList[a] == null)
        arrList[a] = new List<int>();
    arrList[a].Add(b);
    if (arrList[b] == null)
        arrList[b] = new List<int>();
    arrList[b].Add(a);
}

bool check = false;
for (int i = 0; i < n; i++)
{
    vis = new bool[2005];
    vis[i] = true;
    dfs(i , 1);
    if (check)
        break;
}

if(check)
    Console.WriteLine(  1);
else
    Console.WriteLine(  0);


void dfs(int idx, int count)
{
    if (count == 5)
    {
        check = true;
        return;
    }
    if (arrList[idx] == null)
        return;

    foreach (var one in arrList[idx])
    {
        if (vis[one])
            continue;
        vis[one] = true;
        dfs(one, count + 1);
        vis[one] = false;
    }
}