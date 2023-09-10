// BOJ_9372
    
List<Tuple<int, int>> airplane;
int[] par;
        
int t = int.Parse(Console.ReadLine());
while(t-- > 0)
{
    airplane = new List<Tuple<int, int>>();
    par = new int[1005];

    string[] inputnm = Console.ReadLine().Split(' ');
    int n = int.Parse(inputnm[0]);
    int m = int.Parse(inputnm[1]);
    for (int i = 0; i < m; i++)
    {
        string[] inputab = Console.ReadLine().Split(' ');
        int a = int.Parse(inputab[0]);
        int b = int.Parse(inputab[1]);
        airplane.Add(new Tuple<int, int>(a, b));
    }

    int ans = 0;
    for (int i = 0; i < airplane.Count; i++)
    {
        if (!is_diff_group(airplane[i].Item1, airplane[i].Item2))
            continue;
        ans++;
        if (ans == n - 1)
            break;
    }
    Console.WriteLine(ans);
}

bool is_diff_group(int a, int b)
{
    a = unionfind(a); b = unionfind(b);
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

int unionfind(int x)
{
    if (par[x] <= 0)
        return x;
    return par[x] = unionfind(par[x]);
}