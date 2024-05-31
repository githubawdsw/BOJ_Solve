// BOJ_14650


int n = int.Parse(Console.ReadLine());
int count = 0;
int[] num = new int[10];
Dfs(0);

Console.WriteLine(count);


void Dfs(int depth)
{
    if(depth == n)
    {
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += num[i];
        }

        if (num[0] != 0 && sum % 3 == 0)
            count++;

        return;
    }

    for (int i = 0; i < 3; i++)
    {
        num[depth] = i;
        Dfs(depth + 1);
    }
}