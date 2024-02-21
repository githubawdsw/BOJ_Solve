// BOJ_1138


using System.Text;

StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());
int[] inputinfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

List<(int, int)> list = new List<(int, int)>();
bool check = false;
int[] used = new int[15];
for (int i = 1; i <= n; i++)
{
    list.Add((i, inputinfo[i - 1]));
}

dfs(0);

Console.WriteLine(sb);



void dfs(int depth)
{
    if(check) return;

    if (depth == n)
    {
        for (int i = 0; i < n; i++)
        {
            var cur = used[i];
            int count = 0;
            for (int j = 0; j < i; j++)
            {
                if (cur < used[j])
                    count++;
            }
            if (list[cur - 1].Item2 != count)
                return;
        }
        check = true;
        for (int i = 0; i < n; i++)
        {
            sb.Append(used[i].ToString() + " ");
        }
        return;
    }

    for (int i = 0; i < n; i++)
    {
        if (used[i] != 0)
            continue;
        used[i] = list[depth].Item1;
        dfs(depth + 1);
        used[i] = 0;
    }
}