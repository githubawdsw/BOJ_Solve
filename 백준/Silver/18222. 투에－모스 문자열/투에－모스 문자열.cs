// BOJ_18222


long k = long.Parse(Console.ReadLine());

Console.WriteLine(Solve(k - 1));


long Solve(long x)
{
    if (x == 0)
        return 0;
    else if (x == 1) 
        return 1;

    else if(x % 2 == 0)
        return Solve(x / 2);
    else
        return 1 - Solve(x / 2);
}