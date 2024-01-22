// BOJ_13171


long a = long.Parse(Console.ReadLine()) % 1000000007;
long x = long.Parse(Console.ReadLine());

long temp = 1;
while (x > 1)
{
    if (x % 2 == 1)
        temp = (a * temp) % 1000000007;
    a = (a * a) % 1000000007;
    x /= 2;
}

Console.WriteLine((temp * a) % 1000000007);