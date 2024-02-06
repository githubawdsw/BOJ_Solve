// BOJ_2407


using System.Numerics;

int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

BigInteger numera = 1;
BigInteger denomi = 1;

if(n - m > m)
{
    for (int i = n - m + 1; i <= n; i++)
    {
        numera *= i;
    }
    for (int i = 1; i <= m; i++)
    {
        denomi *= i;
    }
}
else
{
    for (int i = m + 1; i <= n; i++)
    {
        numera *= i;
    }
    for (int i = 1; i <= n - m; i++)
    {
        denomi *= i;
    }
}

Console.WriteLine(numera / denomi); 