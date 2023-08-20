// BOJ_2231


int n = int.Parse(Console.ReadLine());


int ans = 1;
while (ans < n)
{
    string temps = ans.ToString();
    int tempint = ans;
    for (int i = 0; i < temps.Length; i++)
    {
        tempint += temps[i] - '0';
    }
    if(tempint == n)
    {
        Console.WriteLine( ans );
        return;
    }
    ans++;
}
Console.WriteLine( 0 );
