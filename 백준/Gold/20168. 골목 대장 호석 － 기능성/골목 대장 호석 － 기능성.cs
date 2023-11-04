// BOJ_20168



string[] inputnmabc = Console.ReadLine().Split(' ');
int n = int.Parse(inputnmabc[0]);
int m = int.Parse(inputnmabc[1]);
int a = int.Parse(inputnmabc[2]);
int b = int.Parse(inputnmabc[(3)]);
int c = int.Parse(inputnmabc[(4)]);

List<Tuple<int, int>>[] relList = new List<Tuple<int, int>>[15];
bool[] vis = new bool[15];
for (int i = 0; i < m; i++)
{
    string[] inputxym = Console.ReadLine().Split(" ");
    int x = int.Parse(inputxym[0]);
    int y = int.Parse(inputxym[1]);
    int money = int.Parse(inputxym[2]);

    if (relList[x] == null)
        relList[x] = new List<Tuple<int, int>>();
    relList[x].Add(new Tuple<int, int>(y, money));
    if (relList[y] == null)
        relList[y] = new List<Tuple<int, int>>();
    relList[y].Add(new Tuple<int, int>(x, money));
}

int ans = int.MaxValue/2;
vis[a] = true;
dfs(a, 0, 0);

if(ans == int.MaxValue/2)
    Console.WriteLine( -1 );
else
    Console.WriteLine(  ans );


void dfs(int start, int cost, int max)
{
    if(start == b)
    {
        ans = Math.Min(ans, max);
        return;
    }
    if (relList[start] == null)
        return;
    foreach (var one in relList[start])
    {
        if(c >= one.Item2 + cost && !vis[one.Item1]) 
        {
            vis[one.Item1] = true;
            dfs(one.Item1, one.Item2 + cost, Math.Max(max, one.Item2));
            vis[one.Item1] = false;

        }
    }
}
