// BOJ_2116


int n = int.Parse(Console.ReadLine());

List<int[]> list = new List<int[]>();
for (int i = 0; i < n; i++)
{
    int[] diceInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    list.Add(diceInfo);
}

int ans = 0;
for (int i = 0; i < 6; i++)
{
    int top = 0;
    if (i == 0 || i == 5)
        top = 5 - i;
    else if (i == 1 || i == 3)
        top = 4 - i;
    else
        top = 6 - i;

    int max = 0;
    for (int k = 0; k < 6; k++)
    {
        if (k == i || k == top)
            continue;
        max = Math.Max(max, list[0][k]);
    }
    int sum = max;

    for (int j = 1; j < n; j++)
    {
        int idx = Array.IndexOf(list[j], list[j - 1][top]);
        max = 0;

        if (idx == 0 || idx == 5)
            top = 5 - idx;
        else if (idx == 1 || idx == 3)
            top = 4 - idx;
        else
            top = 6 - idx;

        for (int k = 0; k < 6; k++)
        {
            if (k == idx || k == top)
                continue;
            max = Math.Max(max, list[j][k]);
        }
        sum += max;
    }
    ans = Math.Max(sum, ans);
}

Console.WriteLine(ans);
