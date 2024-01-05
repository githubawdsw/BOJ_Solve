// BOJ_1722

using System.Text;

StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());
long[] inputInfo = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
bool[] check = new bool[25];
long[] storage = new long[25];
List<long> factorial = new List<long>
{
    1
};

for (int i = 1; i <= n; i++)
    factorial.Add(factorial[i - 1] * i);


if (inputInfo[0] == 1)
{
    long k = inputInfo[1];
    for (int i = 0; i < n; i++)
    {
        for (int j = 1; j <= n; j++)
        {
            if (check[j])
                continue;

            if (factorial[n - i - 1] < k)
                k -= factorial[n - i - 1];
            else
            {
                check[j] = true;
                sb.Append($"{j} ");
                break;
            }
        }
    }
}
else
{
    long ans = 0;
    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j < inputInfo[i]; j++)
        {
            if (!check[j])
                ans += factorial[n - i];
        }
        check[inputInfo[i]] = true;
    }
    sb.AppendLine((ans + 1).ToString());
}

Console.WriteLine(sb);