// BOJ_16943


string[] inputab = Console.ReadLine().Split(' ');
string a = inputab[0];
int b = int.Parse(inputab[1]);

char[] arr = new char[10];
bool[] use = new bool[10];

int length = a.Length;
int ans = -1;

Dfs(0);
Console.WriteLine(ans);


void Dfs(int depth)
{
    if(depth == length)
    {
        int max = 0;
        for (int i = 0; i < length; i++)
        {
            max += (arr[i] - '0') * (int)Math.Pow(10, i);
        }
        if(max < b && max != int.Parse(a) && length <= max.ToString().Length )
            ans = Math.Max(max, ans);
        return;
    }

    for (int i = 0; i < length; i++)
    {
        if (use[i])
            continue;
        use[i] = true;
        arr[depth] = a[i];
        Dfs(depth + 1);
        use[i] = false;
    }
}