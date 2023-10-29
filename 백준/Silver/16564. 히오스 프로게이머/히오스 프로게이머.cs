// BOJ_16564



int[] inputnk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnk[0];
int k = inputnk[1];

List<int> level = new List<int>();
for (int i = 0; i < n; i++)
    level.Add(int.Parse(Console.ReadLine()));

long start = 0;
long end = int.MaxValue / 2;
long ans = 0;
while (start <= end)
{
    long mid = (start + end) / 2;
    long sub = 0;
    for (int i = 0; i < n; i++)
    {
        if(mid > level[i])
            sub += mid - level[i];
    }
    if (sub <= k)
    {
        ans = mid;
        start = mid + 1;
    }
    else
        end = mid - 1;
}
Console.WriteLine(ans);
