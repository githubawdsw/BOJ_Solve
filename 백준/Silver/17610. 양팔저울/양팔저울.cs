// BOJ_17610


int k = int.Parse(Console.ReadLine());
int[] inputWeight = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int min = 200000;
int max = 0;
bool[] check = new bool[3000000];
bool[] use = new bool[15];
for (int i = 0; i < k; i++)
{
    min = Math.Min(min, inputWeight[i]);
    max += inputWeight[i];
}

Solve(0, 0);
int ans = 0;
for (int i = 1; i <= max; i++)
{
    if (!check[i])
        ans++;
}

Console.WriteLine(ans);


void Solve(int depth, int sum)
{
    if(sum > 0)
        check[sum] = true;

    if (depth == k)
        return;

    Solve(depth + 1, sum + inputWeight[depth]);
    Solve(depth + 1, sum - inputWeight[depth]);
    Solve(depth + 1, sum);
}
