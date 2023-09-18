// BOJ_3273
    


int n = int.Parse(Console.ReadLine());
string[] inputarr = Console.ReadLine().Split(' ');
int x = int.Parse(Console.ReadLine());

int[] arr = new int[2000005];
for (int i = 0; i < n; i++)
    arr[int.Parse(inputarr[i])]++;

int ans = 0;
for (int i = 0; i < (x+1)/2; i++)
{
    if (arr[i] == 1 && arr[x - i] == 1)
        ans++;
}
Console.WriteLine(ans);