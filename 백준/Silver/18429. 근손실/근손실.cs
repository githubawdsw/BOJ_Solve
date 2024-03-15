// BOJ_18429


int[] inputnk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnk[0];
int k = inputnk[1];
int[] inputLoss = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
bool[] used = new bool[10];

int ans = 0;
Dfs(0, 0);
Console.WriteLine(ans);


void Dfs(int depth, int remain)
{
    if(depth == n)
    {
        ans++;
        return;
    }

    for (int i = 0; i < n; i++)
    {
        if (used[i] || remain + inputLoss[i] < k)
            continue;

        used[i] = true;
        Dfs(depth + 1, remain + inputLoss[i] - k);
        used[i] = false;
    }
}