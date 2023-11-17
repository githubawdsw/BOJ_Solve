// BOJ_13397



int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m  = inputnm[1];
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int start = 0;
int end = arr.Max();
int ans = 0;
while (start <= end)
{
    int mid = (start + end) / 2;

    int count = 1;
    int max = 0;
    int min = int.MaxValue;
    for (int i = 0; i < n; i++)
    {
        if(max < arr[i])
            max = arr[i];
        if (min > arr[i])
            min = arr[i];
        if (max - min > mid)
        {
            count++;
            max = arr[i];
            min = arr[i];
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

Console.WriteLine( ans );
