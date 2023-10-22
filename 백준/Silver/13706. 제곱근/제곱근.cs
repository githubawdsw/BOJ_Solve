// BOJ_13706

using System.Numerics;

BigInteger n = BigInteger.Parse(Console.ReadLine());
BigInteger start = 1;
BigInteger end = n;

BigInteger mid = 0;
while (start <= end)
{
    mid = (start + end) / 2;
    var val = mid * mid;
    if (val > n)
        end = mid - 1;
    else
        start = mid + 1;
    if (val == n)
        break;
}

Console.WriteLine(mid  );