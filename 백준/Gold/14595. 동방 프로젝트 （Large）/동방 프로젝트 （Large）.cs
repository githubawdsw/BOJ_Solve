// BOJ_14595


int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());

int[] check = new int[1000005];

for (int i = 0; i < m; i++)
{
    int[] inputxy = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int x = inputxy[0];
    int y = inputxy[1];

    check[x]++;
    check[y]--;
}

int ans = 0;
int marking = 0;
for (int i = 1; i <= n; i++)
{
    marking += check[i];
    if (marking == 0)
        ans++;
}

Console.WriteLine(ans);
