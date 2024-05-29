// BOJ_2168


int[] inputxy = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int x = inputxy[0];
int y = inputxy[1];

int gcd = GCD(x, y);

int a = x / gcd;
int b = y / gcd;

int max = Math.Max(a, b);
int min = Math.Min(a, b);

Console.WriteLine((max + min - 1) * gcd);


int GCD(int x,int y)
{
    if (y == 0)
        return x;
    return GCD(y, x % y);
}