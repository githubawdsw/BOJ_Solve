//BOJ_10870


int n = int.Parse(Console.ReadLine());
if(n == 0)
{
    Console.WriteLine(  0 );
    return;
}
int ans = Fibonacci(n);
Console.WriteLine(  ans );


int Fibonacci(int num)
{
    if (num == 1 || num == 2)
        return 1;
    return Fibonacci(num - 2) + Fibonacci(num - 1);
}

