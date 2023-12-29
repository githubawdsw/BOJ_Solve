// BOJ_1850


using System.Text;

StringBuilder sb = new StringBuilder();
long[] inputab = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
long a = inputab[0];
long b = inputab[1];

long value = GCD(a, b);


for (int i = 0; i < value; i++)
{
    sb.Append('1');
}
Console.WriteLine(sb);


long GCD(long a, long b)
{
    if (b == 0)
        return a;
    return GCD(b, a % b);
}