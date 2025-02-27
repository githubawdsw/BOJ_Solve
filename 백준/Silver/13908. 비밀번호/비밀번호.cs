// BOJ_13908


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];
if(m == 0)
{
    Console.WriteLine(Math.Pow(10, n));
    return;
}

int[] inputEssential = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

List<int> list = new List<int>();
int[] check = new int[10];
int ans = 0;

Dfs(0);

Console.WriteLine(ans);


void Dfs(int depth)
{
    if(depth == n)
    {
        for (int i = 0; i < m; i++)
        {
            if(check[inputEssential[i]] == 0)
                return;
        }
        ans++;
        return;
    }

    for (int i = 0; i <= 9; i++)
    {
        check[i]++;
        Dfs(depth + 1);
        check[i]--;
    }
}