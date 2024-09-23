// BOJ_1354


long[] inputnpqxy = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
long n = inputnpqxy[0];
long p = inputnpqxy[1];
long q = inputnpqxy[2];
long x = inputnpqxy[3];
long y = inputnpqxy[4];

Dictionary<long, long> dict = new Dictionary<long, long>();

Console.WriteLine(Solve(n));


long Solve(long k)
{
    if (k <= 0)
        return 1;
    if (!dict.ContainsKey(k))
        dict.Add(k, Solve(k / p - x) + Solve(k / q - y));
    return dict[k];
}