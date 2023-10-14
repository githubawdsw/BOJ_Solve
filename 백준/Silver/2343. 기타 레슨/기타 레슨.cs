// BOJ_2343



string[] inputnm = Console.ReadLine().Split(' ');
int n = int.Parse(inputnm[0]);
int m = int.Parse(inputnm[1]);

int start = 0;
int end = 0;
string[] inputinfo = Console.ReadLine().Split(" ");
for (int i = 0; i < n; i++)
{
    int info = int.Parse(inputinfo[i]);
    start = Math.Max(start, info);
    end += info;
}

int ans = 0;
while (start <= end)
{
    int mid = (start + end) / 2;
    int limit = 0;
    int count = 1;
    int info;
    for (int i = 0; i < n; i++)
    {
        info = int.Parse(inputinfo[i]);
        limit += info;
        if(limit > mid)
        {
            count++;
            limit = info;
        }
    }

    if (count <= m)
    {
        ans = mid;
        end = mid - 1;
    }
    else
        start = mid + 1;
}

Console.WriteLine(  ans );
