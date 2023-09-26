// BOJ_1590



string[] inputnt = Console.ReadLine().Split(' ');
int n = int.Parse(inputnt[0]);
int t = int.Parse(inputnt[1]);

long ans = long.MaxValue / 2;
for (int j = 0; j < n; j++)
{
    string[] inputsic = Console.ReadLine().Split(' ');
    int s = int.Parse(inputsic[0]);
    int i = int.Parse(inputsic[1]);
    int c = int.Parse(inputsic[2]);

    if (s + i * (c - 1)  < t)
        continue;

    List<long> list = new List<long>();
    for (int k = 0; k < c; k++)
    {
        long val = s + k * i;
        list.Add(val);
    }
    
    int left = 0;
    int right = c - 1;
    int mid = 0;
    while (left < right)
    {
        mid = (left + right) / 2;
        if (list[mid] >= t)
            right = mid;
        else
            left = mid + 1;
    }
    if (list[mid] < t)
        mid++;
    ans = Math.Min(ans, list[mid] - t);
}
if(ans == long.MaxValue/2)
    Console.WriteLine(  -1 );
else
    Console.WriteLine(  ans );
