// BOJ_15810



long[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
long n = inputnm[0];
long m = inputnm[1];

long[] inputarr = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);

long start = 0;
long end = inputarr.Max() * m;
long ans = 0;
while (start <= end)
{
    long mid = (start + end) / 2;
    long count = 0;
    for (int i = 0; i < n; i++)
        count += mid / inputarr[i];

    if (count < m)
        start = mid + 1;
    else
    {
        ans = mid;
        end = mid - 1;
    }
}

Console.WriteLine(ans);
