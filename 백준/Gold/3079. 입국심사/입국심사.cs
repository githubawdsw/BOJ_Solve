// BOJ_3079



ulong[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), ulong.Parse);
ulong n = inputnm[0];
ulong m  = inputnm[1];

List<ulong> time = new List<ulong>();
for (ulong i = 0; i < n; i++)
    time.Add(ulong.Parse(Console.ReadLine()));
time.Sort();

ulong start = time.First();
ulong end = long.MaxValue / 4;
ulong ans = long.MaxValue / 4;
while (start <= end)
{
    ulong mid = (start + end) / 2;
    ulong count = 0;
    for (ulong i = 0; i < n; i++)
        count += mid / time[(int)i];
    
    if(count >= m)
    {
        end = mid - 1;
        ans = Math.Min(ans, mid);
    }
    else 
        start = mid + 1;
}

Console.WriteLine(ans);
