// BOJ_1459

int[] inputinfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
long x = inputinfo[0];
long y = inputinfo[1];
long w = inputinfo[2];
long s = inputinfo[3];

long ans = 0;
if (2 * w < s)
{
    ans = (x + y) * w;
}
else
{
    long diagonal = Math.Min(x, y);
    ans += diagonal * s;
    long remain = Math.Max(x, y) - diagonal;
    if(w < s)
    {
        ans += remain * w;
    }
    else
    {
        ans += (remain / 2) * 2 * s;
        ans += (remain % 2) * w;
    }
}

Console.WriteLine(ans);