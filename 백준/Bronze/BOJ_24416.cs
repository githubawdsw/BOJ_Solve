// BOJ_24416


int n = int.Parse(Console.ReadLine());

int acount = 0;
int bcount = 0;
acount =  fib(n);

int[] f = new int[45];
f[1] = 1;
f[2] = 2;

fibonaci(n);
Console.WriteLine(  $"{acount } {bcount}");

int fib( int n)
{
    if (n == 1 || n == 2)
        return 1;
    else
        return (fib(n - 1) + fib(n - 2));
}

void fibonaci(int n)
{
    for (int i = 3; i <= n; i++)
    {
        f[i] = f[i - 1] + f[i - 2];
        bcount++;
    }
}
