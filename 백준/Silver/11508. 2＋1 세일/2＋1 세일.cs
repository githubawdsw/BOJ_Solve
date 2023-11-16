// BOJ_11508


int n = int.Parse(Console.ReadLine());
List<int> costList = new List<int>();
for (int i = 0; i < n; i++)
    costList.Add(int.Parse(Console.ReadLine()));

costList = costList.OrderByDescending(c=>c).ToList();
int ans = 0;
for (int i = 0; i < n; i++)
{
    if ((i + 1) % 3 != 0)
        ans += costList[i];
}

Console.WriteLine(ans);
