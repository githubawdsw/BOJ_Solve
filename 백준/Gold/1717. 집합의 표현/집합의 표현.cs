// BOJ_1717



using System.Text;

StringBuilder sb = new StringBuilder();
int[] par = new int[1000005];

int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];
for (int i = 0; i <= n; i++)
    par[i] = -1;

for (int i = 0; i < m; i++)
{
    int[] inputRel = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int type = inputRel[0];
    int a = inputRel[1];
    int b = inputRel[2];

    if (type == 0)
        is_diff_group(a, b);

    else
    {
        if (find(a) == find(b))
        {
            sb.AppendLine("YES");
            continue;
        }
        sb.AppendLine("NO");
    }
}
Console.WriteLine(  sb );

bool is_diff_group(int a, int b)
{
    a = find(a); b = find(b);
    if(a == b) 
        return false;
    if (par[a] == par[b])
        par[a]--;

    if (par[a] < par[b])
        par[a] = b;
    else
        par[b] = a;
    return true;
}

int find(int x)
{
    if (par[x] < 0)
        return x;
    return par[x] = find(par[x]);
}