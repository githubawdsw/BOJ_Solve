// BOJ_2417



ulong n = ulong.Parse(Console.ReadLine());

ulong left = 0;
ulong right = 4294967296;
ulong ans = long.MaxValue;

if (n == 0)
{
    Console.WriteLine(  0 );
    return;
}

while (left <= right)
{
    ulong mid = (left + right) / 2;
    if(mid * mid >= n)
    {
        ans = Math.Min(ans, mid);
        right = mid - 1;
    }
    else
        left = mid + 1; 
    
}

Console.WriteLine(  ans );
