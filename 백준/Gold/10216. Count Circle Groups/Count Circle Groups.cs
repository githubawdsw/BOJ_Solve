// BOJ_10216


using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());
int[] par = new int[3005];
while (t-- > 0)
{
    List<int>[] list = new List<int>[3005];
    List<(int, int, int)> infoList = new List<(int, int, int)>();

    int n = int.Parse(Console.ReadLine());
    for (int i = 0; i < n; i++)
    {
        int[] inputxyr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int x = inputxyr[0];
        int y = inputxyr[1];
        int r = inputxyr[2];
        infoList.Add((x, y, r));
        list[i] = new List<int>();
    }

    for (int i = 0; i < n; i++)
    {
        par[i] = -1;
    }

    for (int i = 0; i < n; i++)
    {
        for (int j = i + 1; j < n; j++)
        {
            int x1 = infoList[i].Item1;
            int y1 = infoList[i].Item2;

            int x2 = infoList[j].Item1;
            int y2 = infoList[j].Item2;
            int length = (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1);
            if (length <= (infoList[i].Item3 + infoList[j].Item3) * (infoList[i].Item3 + infoList[j].Item3))
                Is_Diff_Group(i, j);
        }
    }

    HashSet<int> hs = new HashSet<int>();
    for (int i = 0; i < n; i++)
    {
        int data = Find(i);
        if(!hs.Contains(data))
            hs.Add(data);
    }
    sb.AppendLine(hs.Count.ToString());
}

Console.WriteLine(sb);


bool Is_Diff_Group(int a, int b)
{
    a = Find(a); b = Find(b);
    if(a == b) 
        return false;
    if (par[a] == par[b])
        par[a]--;
    if (par[a] < par[b])
        par[b] = a;
    else
        par[a] = b;
    return true;
}

int Find(int x)
{
    if (par[x] < 0)
        return x;
    return par[x] = Find(par[x]);
}