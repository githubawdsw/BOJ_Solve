// BOJ_17266



int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
string[] inputPosx = Console.ReadLine().Split(' ');

int[] lampArr = new int[100005];
for (int i = 0; i < inputPosx.Length; i++)
    lampArr[i] = int.Parse(inputPosx[i]);

int left = 0;
int right = n - 1;
int ans = n;
while (left <= right)
{
    bool check = true;
    int mid = (left + right) / 2;
    if (lampArr[0] - mid > 0)
        check = false;
    if (lampArr[m-1] + mid < n)
        check = false;
    for (int i = 0; i < m - 1; i++)
    {
        if(lampArr[i] + mid < lampArr[i +1] - mid)
        {
            check = false;
            break;
        }
    }
    if (check)
    {
        ans = Math.Min(ans, mid);
        right = mid - 1;
    }
    else
        left = mid + 1;
}
Console.WriteLine(  ans );
