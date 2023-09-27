// BOJ_1072



string[] inputxy = Console.ReadLine().Split(' ');
long x = int.Parse(inputxy[0]);
long y = int.Parse(inputxy[1]);
long z = y * 100 / x;

if(z == 99 || z == 100)
{
    Console.WriteLine( -1 );
    return;
}

long left = 1;
long right = x;
long mid = 0;
long ans = long.MaxValue / 2;
while(left < right)
{
    mid = (left + right) / 2;
    long temp = (y + mid) * 100 / (x + mid);
    if ( temp > z)
        right = mid;
    else
        left = mid + 1;
}
Console.WriteLine(  left );
