// BOJ_16922


int n = int.Parse(Console.ReadLine());
int[] romanNumeral = { 1, 5, 10, 50 };
HashSet<int> hs = new HashSet<int>();
Dfs(0, 0, 0);

Console.WriteLine(hs.Count);


void Dfs(int idx , int depth, int sum)
{
    if(depth == n)
    {
        hs.Add(sum);
        return;
    }

    for (int i = idx; i < 4; i++)
    {
        Dfs(i , depth + 1, romanNumeral[i] + sum);
    }
}

