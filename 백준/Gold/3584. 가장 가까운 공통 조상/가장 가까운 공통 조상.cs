// BOJ_3584


using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());

while (t-- > 0)
{
    int n = int.Parse(Console.ReadLine());
    List<int>[] list = new List<int>[10005];
    Stack<int> s = new Stack<int>();
    bool[] vis = new bool[10005];
    while (n-- > 1)
    {
        int[] inputab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int a = inputab[0];
        int b = inputab[1];
        if (list[b] == null)
            list[b] = new List<int>();
        list[b].Add(a);
    }

    int[] inputTarget = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    s.Push(inputTarget[0]);
    s.Push(inputTarget[1]);
    vis[inputTarget[0]] = true;
    vis[inputTarget[1]] = true;

    bool check = false;
    int ans = 0;
    while (s.Count > 0)
    {
        var cur = s.Pop();

        if (list[cur] == null)
            continue;

        foreach (var one in list[cur])
        {
            if (vis[one])
            {
                ans = one;
                check = true;
                break;
            }

            vis[one] = true;
            s.Push(one);
        }

        if (check)
            break;
    }

    sb.AppendLine(ans.ToString());
}

Console.WriteLine(sb);