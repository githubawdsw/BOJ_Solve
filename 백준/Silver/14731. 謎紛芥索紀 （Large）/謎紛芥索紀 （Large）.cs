// BOJ_14731


int n = int.Parse(Console.ReadLine());
long ans = 0;
for (int i = 0; i < n; i++)
{
    long[] inputck = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
    long c = inputck[0];
    long k = inputck[1];

    ans += ((c * k % 1000000007) * pow(2, k - 1)) % 1000000007;
    ans %= 1000000007;
}

Console.WriteLine(ans);

long pow(long c, long k)
{
    if (k == 0)
        return 1;

    else if (k == 1)
        return c % 1000000007;

    else
    {
        long num = pow(c, k / 2);
        if (k % 2 == 0)
            return (num * num) % 1000000007;
        else
            return ((num * num % 1000000007) * c) % 1000000007;
    }
}