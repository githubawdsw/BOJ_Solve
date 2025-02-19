// BOJ_16678


int n = int.Parse(Console.ReadLine());
List<int> list = new List<int>();
for (int i = 0; i < n; i++)
{
    list.Add(int.Parse(Console.ReadLine()));
}

list.Sort();
long ans = 0;
int count = 1;
for (int i = 0; i < n; i++)
{
    if (list[i] >= count)
    {
        ans += list[i] - count;
        count++;
    }
}

Console.WriteLine(ans);