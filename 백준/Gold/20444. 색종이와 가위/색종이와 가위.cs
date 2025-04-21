// BOJ_20444


long[] inputnk = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
long n = inputnk[0];
long k = inputnk[1];

long left = 0;
long right = n / 2;

while (left <= right)
{
    long row = (left + right) / 2;
    long col = n - row;
    long count = (row + 1) * (col + 1);

    if (count < k)
        left = row + 1;
    else if (count == k)
    {
        Console.WriteLine("YES");
        return;
    }
    else
        right = row - 1;

}

Console.WriteLine("NO");