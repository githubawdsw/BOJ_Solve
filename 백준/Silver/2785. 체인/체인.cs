// BOJ_2785


int n = int.Parse(Console.ReadLine());
int[] inputLength = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

Array.Sort(inputLength);

int maxidx = 0;
int use = 0;
int ans = 0;

while(maxidx < n - 1 - use)
{
    inputLength[use]--;
    if (inputLength[use] == 0)
        use++;

    maxidx++;
    ans++;
}

Console.WriteLine(ans);
