// BOJ_1914

using System.Numerics;
using System.Text;

StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());

BigInteger k = 1;
for (int i = 2; i <= n; i++)
{
    k = 2 * k + 1;
}

Console.WriteLine(k);

if (n <= 20)
{
    HanoiSpire(n , 1, 3);
    Console.WriteLine(sb.ToString());
}



void HanoiSpire(int n , int a, int b)
{
    if(n == 1)
    {
        sb.AppendLine($"{a} {b}");
        return;
    }

    HanoiSpire(n - 1, a, 6 - a - b);
    sb.AppendLine($"{a} {b}");
    HanoiSpire(n - 1, 6 - a - b, b);
}