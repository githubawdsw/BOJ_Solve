// BOJ_10253


using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());

while (t-- > 0)
{
    int[] inputab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int a = inputab[0];
    int b = inputab[1];

    int x = 2;
    while (a != 1)
    {
        if (b % a == 0)
            x = b / a;
        else
            x = b / a + 1;

        a = ((a * x) - b);
        b *= x;

        int gcd = GCD(a, b);
        a /= gcd;
        b /= gcd;
    }

    sb.AppendLine(Math.Max(x, b).ToString());
}

Console.WriteLine(sb);


int GCD(int a, int b)
{
    if (b == 0)
        return a;
    return GCD(b, a % b);
}