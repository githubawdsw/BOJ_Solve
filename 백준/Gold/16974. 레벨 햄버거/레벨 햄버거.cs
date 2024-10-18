// BOJ_16974


long[] inputnx = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
long n = inputnx[0];
long x = inputnx[1];

long[] b = new long[55];
long[] p = new long[55];

b[0] = 1;
p[0] = 1;
for (int i = 1; i <= n; i++)
{
    b[i] = b[i - 1] * 2 + 3;
    p[i] = p[i - 1] * 2 + 1;
}

Console.WriteLine(Recursive(n,x));


long Recursive(long n, long x)
{
    if(n == 0)
    {
        if (x == 0)
            return 0;
        else if(x == 1) 
            return 1;
    }

    if (x == 1)
        return 0;
    else if (x <= b[n - 1] + 1)
        return Recursive(n - 1, x - 1);
    else if (x == b[n - 1] + 2)
        return p[n - 1] + 1;
    else if (x <= b[n - 1] * 2 + 2)
        return p[n - 1] + Recursive(n - 1, x - b[n - 1] - 2) + 1;
    else
        return p[n - 1] * 2 + 1;
}