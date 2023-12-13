// BOJ_1024


using System.Text;

StringBuilder sb = new StringBuilder();
int[] inputnl = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnl[0];
int l = inputnl[1];

int x = -1;
int length = 0;
for (int i = l; i <= 100; i++)
{
    int value = (n - (i * (i - 1) / 2));
    if (value % i == 0)
    {
        x = value / i;
        if (x < 0)
            x = -1;
        length = i;
        break;
    }
    else
        x = -1;
}

if (x != -1)
{
    for (int j = 0; j < length; j++)
        sb.Append($"{x + j} ");
}
else
    sb.AppendLine("-1");

Console.WriteLine(sb);