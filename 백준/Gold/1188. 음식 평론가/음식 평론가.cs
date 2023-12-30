// BOJ_1188


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

Console.WriteLine(m - GCD(n,m));

int GCD(int x ,int y)
{
    if (y == 0)
        return x;
    return GCD(y, x % y);
}