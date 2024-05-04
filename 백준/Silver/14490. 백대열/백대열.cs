// BOJ_14490


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(':'), int.Parse);
int n = inputnm[0];
int m = inputnm[1];
int gcd = GCD(n, m);

Console.WriteLine($"{n/ gcd}:{m / gcd}");

int GCD(int a, int b)
{
    if (b == 0)
        return a;
    return GCD(b, a % b);
}