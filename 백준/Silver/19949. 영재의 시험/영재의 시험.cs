// BOJ_19949


int[] inputAnswer = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] select = new int[15];

int ans = 0;
Dfs(0);

Console.WriteLine(ans);


void Dfs(int depth)
{
    if(depth == 10)
    {
        int sum = 0;
        for (int i = 0; i < 10; i++)
        {
            if (inputAnswer[i] == select[i])
                sum++;
        }
        if (sum >= 5)
            ans++;
        return;
    }

    for (int i = 1; i <= 5; i++)
    {
        if (depth >= 2 && select[depth - 1] == i && select[depth - 1] == select[depth - 2])
            continue;
        select[depth] = i;
        Dfs(depth + 1);
    }
}