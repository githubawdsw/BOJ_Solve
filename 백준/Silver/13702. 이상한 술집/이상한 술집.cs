// BOJ_13702



int[] inputnk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnk[0];
int k = inputnk[1];
List<long> list = new List<long>();
for (int i = 0; i < n; i++)
    list.Add(long.Parse(Console.ReadLine()));

long start = 1;
long end = int.MaxValue;
long ans = 0;
while (start <= end)
{
    long mid = (start + end) / 2;
    long count = 0;
    if(mid != 0)
        for (int i = 0; i < list.Count; i++)
            count += list[i] / mid;

    if (count < k)
        end = mid - 1;
    else
    {
        start = mid + 1;
        ans = mid;
    }
}

Console.WriteLine(  ans );
