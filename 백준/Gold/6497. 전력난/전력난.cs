// BOJ_6497

using System.Text;

string[] inputmn;
int[] par;
StringBuilder sb = new StringBuilder();

while (true)
{
    inputmn = Console.ReadLine().Split(' ');

    int m = int.Parse(inputmn[0]);
    int n = int.Parse(inputmn[1]);
    if (m == 0 && n == 0)
        break;

    List<Tuple<int, int, int>> tupleList = new List<Tuple<int, int, int>>();
    par = new int[200005];
    Array.Fill(par, -1);

    int sum = 0;
    for (int i = 0; i < n; i++)
    {
        string[] xyz = Console.ReadLine().Split(" ");
        int x = int.Parse(xyz[0]);
        int y = int.Parse(xyz[1]);
        int z = int.Parse(xyz[2]);
        tupleList.Add(new Tuple<int, int, int>(z, x, y));
        sum += z;
    }
    tupleList.Sort();

    int ans = 0;
    int count = 0;
    for (int i = 0; i < tupleList.Count; i++)
    {
        if (!is_diff_group(tupleList[i].Item2, tupleList[i].Item3))
            continue;
        ans += tupleList[i].Item1;
        count++;
        if (count == m - 1)
            break;
    }
    sb.AppendLine((sum - ans).ToString());
}
Console.WriteLine(  sb);

bool is_diff_group(int a, int b)
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

int find(int x)
{
    if (par[x] <= -1)
        return x;
    return par[x] = find(par[x]);
}
