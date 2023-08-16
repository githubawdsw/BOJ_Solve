//BOJ_27433


int n = int.Parse(Console.ReadLine());

if (n == 0)
{
    Console.WriteLine(  "1");
    return;
}

long ans = 1;
for (int i = 1; i <= n; i++)
    ans *= i;
Console.WriteLine(  ans);
