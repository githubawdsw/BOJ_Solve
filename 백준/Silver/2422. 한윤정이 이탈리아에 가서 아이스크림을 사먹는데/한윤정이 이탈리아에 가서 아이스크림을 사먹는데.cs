// BOJ_2422


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

HashSet<int>[] hs = new HashSet<int>[205];
for (int i = 0; i < m; i++)
{
    int[] inputRel = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int x = inputRel[0];
    int y = inputRel[1];
    if (hs[x] == null)
        hs[x] = new HashSet<int>();
    hs[x].Add(y);
    if (hs[y] == null)
        hs[y] = new HashSet<int>();
    hs[y].Add(x);
}

int ans = 0;
for (int i = 1; i <= n; i++)
{
    for (int j = i + 1; j <= n; j++)
    {
        if (hs[i] != null && hs[i].Contains(j))
            continue;
        for (int k = j + 1; k <= n; k++)
        {
            if (hs[i] != null && hs[i].Contains(k) )
                continue;
            if (hs[j] != null && hs[j].Contains(k))
                continue;

            ans++;
        }
    }
}

Console.WriteLine(ans);