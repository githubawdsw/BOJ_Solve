// BOJ_3980


using System.Text;

StringBuilder sb = new StringBuilder();
int c = int.Parse(Console.ReadLine());
int ans = 0;
while (c-- != 0)
{
    bool[] usingPosition = new bool[12];
    List<List<int>> list = new List<List<int>>();
    ans = 0;
    for (int i = 0; i < 11; i++)
    {
        int[] inputnk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        list.Add(new List<int>());
        for (int j = 0; j < 11; j++)
        {
            list[i].Add(inputnk[j]);
        }
    }
    Dfs(0, 0, usingPosition, list);
    sb.AppendLine(ans.ToString());
}

Console.WriteLine(sb);


void Dfs(int depth, int sum, bool[] usingPosition, List<List<int>> list)
{
    if(depth == 11)
    {
        ans = Math.Max (sum, ans);
        return;
    }

    for (int i = 0; i < 11; i++)
    {
        if (usingPosition[i] || list[depth][i] == 0)
            continue;
        usingPosition[i] = true;

        Dfs(depth + 1, sum + list[depth][i], usingPosition, list);

        usingPosition[i] = false;
    }
}