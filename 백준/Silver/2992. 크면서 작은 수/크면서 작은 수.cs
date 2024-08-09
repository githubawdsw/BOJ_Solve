// BOJ_2992


string x = Console.ReadLine();

int ans = int.MaxValue;

int[] arr = new int[8];
bool[] check = new bool[8];

Dfs(0);

if (ans == int.MaxValue)
    ans = 0;

Console.WriteLine(ans);


void Dfs(int depth)
{
    if(depth == x.Length)
    {
        string join = "";
        for (int i = 0; i < depth; i++)
        {
            join += arr[i];
        }
        if (int.Parse(x) < int.Parse(join))
            ans = Math.Min(ans, int.Parse(join));
    }

    for (int i = 0; i < x.Length; i++)
    {
        if (check[i])
            continue;

        arr[depth] = x[i] - '0';
        check[i] = true;
        Dfs(depth + 1);
        check[i] = false;
    }
}
