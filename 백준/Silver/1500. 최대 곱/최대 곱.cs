// BOJ_1500


long[] inputsk = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
long s = inputsk[0];
long k = inputsk[1];

long[] arr = new long[25];
for (long i = 0; i < k; i++)
{
    arr[i] = s / k;
}
for (long i = 0; i < s % k; i++)
{
    arr[i]++;
}

long ans = 1;
for (long i = 0; i < k; i++)
{
    ans *= arr[i];
}

Console.WriteLine(ans);
