// BOJ_5525


int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
string inputarr = Console.ReadLine();

int ans = 0;
for (int i = 0; i < m - 2; i++)
{
    int k = 0;
    if (inputarr[i] == 'O')
        continue;
    while (i + 2 < m && inputarr[i + 1] == 'O' && inputarr[i+2] == 'I')
    {
        k++;
        if (k == n)
        {
            ans++;
            k--;
        }
        i += 2;
    }
}

Console.WriteLine(ans);
