// BOJ_7511


using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());
int count = 0;
int[] par;
while (count++ < t)
{
    int n = int.Parse(Console.ReadLine());
    par = new int[1000005];
    for (int i = 0; i < n; i++)
    {
        par[i] = -1;
    }

    int k = int.Parse(Console.ReadLine());
    for (int i = 0; i < k; i++)
    {
        int[] inputab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int a = inputab[0];
        int b = inputab[1];

        IsDiffGroup(a, b);
    }

    sb.AppendLine("Scenario " + count + ":");
    int m = int.Parse(Console.ReadLine());
    for (int i = 0; i < m; i++)
    {
        int[] inputuv = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int u = inputuv[0];
        int v = inputuv[1];
        if (Find(u) == Find(v))
            sb.AppendLine("1");
        else
            sb.AppendLine("0");
    }
    sb.AppendLine();
}

Console.WriteLine(sb);



bool IsDiffGroup(int a, int b)
{
    a = Find(a); b = Find(b);
    if(a == b) 
        return false;

    if (par[a] == par[b])
        par[a]--;
    if (par[a] > par[b])
        par[a] = b;
    else
        par[b] = a;
    return true;
}
int Find(int x)
{
    if (par[x] < 0)
        return x;
    return par[x] = Find(par[x]);
}
