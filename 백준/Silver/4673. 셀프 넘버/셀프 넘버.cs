// BOJ_4673


using System.Text;

StringBuilder sb = new StringBuilder();
bool[] check = new bool[10005];
check[1] = false;
for (int i = 0; i < 10000; i++)
{
    int cur = i;
    int sum = cur;
    while (cur > 0)
    {
        sum += cur % 10;
        cur /= 10;
    }

    if (sum < 10000)
        check[sum] = true;
}

for (int i = 1; i < 10000; i++)
{
    if (!check[i])
        sb.AppendLine(i.ToString());
}
Console.WriteLine(sb);