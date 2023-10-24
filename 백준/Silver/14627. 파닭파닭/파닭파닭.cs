// BOJ_14627



int[] inputsc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int s = inputsc[0];
int c = inputsc[1];

List<long> onionList = new List<long>();
for (int i = 0; i < s; i++)
    onionList.Add(long.Parse(Console.ReadLine()));

long start = 1;
long end = onionList.Max();
long ans = 0;
while (start <= end)
{
    long mid = (start + end) / 2;

    long count = 0;
    for (int i = 0; i < s; i++)
        count += onionList[i] / mid;
    if(count  >= c)
    {
        start = mid + 1;
        ans = onionList.Sum() - mid * c;
    }
    else
        end = mid - 1;
}

Console.WriteLine(  ans );
