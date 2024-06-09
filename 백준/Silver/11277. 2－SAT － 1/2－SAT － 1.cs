// BOJ_11277


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

bool[] check = new bool[25];
List<(int, int)> list = new List<(int, int)>();
for (int i = 0; i < m; i++)
{
    int[] inputf = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    list.Add((inputf[0], inputf[1]));
}

int ans = 0;
Dfs(1);

Console.WriteLine(ans);

void Dfs(int depth)
{
    if(depth == n + 1)
    {
        foreach (var one in list)
        {
            bool left = false;
            if (one.Item1 < 0)
                left = !check[-one.Item1];
            else
                left = check[one.Item1];

            bool right = false;
            if (one.Item2 < 0)
                right = !check[-one.Item2];
            else
                right = check[one.Item2];

            if (left == false && right == false)
                return;
        }
        ans = 1;
        return;
    }

    if (ans == 1)
        return;

    check[depth] = true;
    Dfs(depth + 1);
    check[depth] = false;
    Dfs(depth + 1);
}