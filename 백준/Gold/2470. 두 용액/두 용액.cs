// BOJ_2470


int n = int.Parse(Console.ReadLine());
int[] info = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

Array.Sort(info);

int ans1 = int.MaxValue;
int ans2 = 0;

int left = 0;
int right = info.Length - 1;

int sum = int.MaxValue;
while (left < right)
{
    int temp = info[left] + info[right];
    if (sum > Math.Abs(temp))
    {
        sum = Math.Abs(temp);
        ans1 = info[left];
        ans2 = info[right];
    }
    if (temp > 0)
        right--;
    else
        left++;
}

Console.WriteLine( $"{ans1} {ans2}");
