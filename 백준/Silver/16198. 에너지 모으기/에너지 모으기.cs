// BOJ_16198


int n = int.Parse(Console.ReadLine());
int[] energeInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

List<int> list = new List<int>();
for (int i = 0; i < energeInfo.Length; i++)
{
    list.Add(energeInfo[i]);
}
int ans = 0;
dfs(list.Count, 0);

Console.WriteLine(ans);


void dfs(int depth, int max)
{
    if (depth <= 2)
    {
        ans = Math.Max(ans, max);
        return;
    }

    for (int i = 1; i < list.Count - 1; i++)
    {
        int temp = list[i];
        list.RemoveAt(i);
        dfs(list.Count, max + (list[i - 1] * list[i]));
        list.Insert(i, temp);
    }
}