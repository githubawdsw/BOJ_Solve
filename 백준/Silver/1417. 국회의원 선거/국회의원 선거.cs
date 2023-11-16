// BOJ_1417



int n = int.Parse(Console.ReadLine());

int[] arr = new int[105];
int ds = int.Parse(Console.ReadLine());

int max = 0;
for (int i = 1; i < n; i++)
{
    int votes = int.Parse(Console.ReadLine());
    arr[votes]++;
    max = Math.Max(max, votes);
}

int ans = 0;
while(max >= ds)
{
    arr[max - 1]++;
    if (--arr[max] == 0)
        max--;

    ds++;
    ans++;
}

Console.WriteLine(ans);

