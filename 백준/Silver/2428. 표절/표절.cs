// BOJ_2428


int n = int.Parse(Console.ReadLine());
long[] fileSize = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
Array.Sort(fileSize);
for (int i = 0; i < n; i++)
    fileSize[i] *= 10;

long ans = 0;
for (int i = 0; i < n - 1; i++)
{
    int target = i;
    int start = target;
    int end = n - 1;
    int count = 0;
    while (start <= end)
    {
        int mid = (start + end) / 2;
        if (fileSize[mid] * 9 / 10 <= fileSize[target])
        {
            count = mid - target;
            start = mid + 1;
        }
        else
            end = mid - 1;
    }
    ans += count;
}

Console.WriteLine(ans);