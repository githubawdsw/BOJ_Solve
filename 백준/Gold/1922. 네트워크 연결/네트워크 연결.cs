// BOJ_1922
    
List<Tuple<int, int, int>> network = new List<Tuple<int, int, int>>();
int[] par = new int[100005];
        
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
for (int i = 0; i < m; i++)
{
    string[] inputRel = Console.ReadLine().Split(' ');
    int a = int.Parse(inputRel[0]);
    int b = int.Parse(inputRel[1]);
    int cost = int.Parse(inputRel[2]);
    network.Add(new Tuple<int, int, int>(cost, a, b));
}
network.Sort();

int ans = 0;
int count = 0;
for (int i = 0; i < network.Count; i++)
{
    if (!is_diff_group(network[i].Item2, network[i].Item3))
        continue;
    ans += network[i].Item1;
    count++;
    if (count == n - 1)
        break;
}
Console.WriteLine(ans);


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