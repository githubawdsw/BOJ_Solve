// BOJ_2118


int n = int.Parse(Console.ReadLine());
int total = 0;
int[] dis = new int[50005];
int ans = 0;
for (int i = 0; i < n; i++)
{
    int distance = int.Parse(Console.ReadLine());
    total += distance;
    dis[i] = distance;
}


int left = 0;
int right = 0;
int sum = dis[0];
while (right >= left && right < n)
{
    int min = Math.Min(sum, total - sum);
    ans = Math.Max(min, ans);

    if(min == sum)
    {
        right++;
        sum += dis[right];
    }
    else
    {
        sum -= dis[left];
        left++;
    }
}

Console.WriteLine(ans);
