// BOJ_7490


using System.Text;

int t = int.Parse(Console.ReadLine());
StringBuilder sb = new StringBuilder();
char[] symbol = new char[10];
int[] value = new int[10];

for (int j = 0; j < 10; j++)
{
    value[j] = j + 1;
}

for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine());

    Dfs(1, n);
    sb.AppendLine();
}

Console.WriteLine(sb);


void Dfs(int depth, int end)
{
    if(depth == end)
    {
        int sum = 1;
        for (int i = 1; i < end; i++)
        {
            if (symbol[i] == '+')
            {
                if (symbol[i + 1] == ' ')
                {
                    sum += value[i] * 10;
                    sum += value[i + 1];
                }
                else
                    sum += value[i];

            }
            else if (symbol[i] == '-')
            {
                if (symbol[i + 1] == ' ')
                {
                    sum -= value[i] * 10;
                    sum -= value[i + 1];
                }
                else
                    sum -= value[i];
            }

            else if (symbol[i] == ' ')
            {
                if (i == 1)
                {
                    sum += value[i - 1] * 10;
                    sum += value[i];
                    sum -= 1;
                }
                if (symbol[i + 1] == ' ')
                    return;
            }
        }
        if (sum == 0)
        {
            sb.Append('1');
            for (int i = 1; i < end; i++)
            {
                sb.Append($"{symbol[i]}{value[i]}");
            }
            sb.AppendLine();
        }
        return;
    }

    symbol[depth] = ' ';
    Dfs(depth + 1, end);

    symbol[depth] = '+';
    Dfs(depth + 1, end);

    symbol[depth] = '-';
    Dfs(depth + 1, end);
}
