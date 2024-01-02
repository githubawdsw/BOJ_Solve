// BOJ_1174

using System.Text;

List<long> list = new List<long>();
StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= 10; i++)
{
    Dfs(0, i, 10);
    if (list.Count >= n)
        break;
}

if(n > list.Count)
    Console.WriteLine(-1);
else
{
    list.Sort();
    Console.WriteLine(list[n - 1]);
}



void Dfs(int depth, int end, int value)
{
    if(depth == end)
    {
        list.Add(long.Parse(sb.ToString()));
        return;
    }

    for (int i = 0; i < value; i++)
    {
        sb.Append($"{i}");
        Dfs(depth + 1, end, i);
        sb.Remove(sb.Length - 1, 1);
    }
}