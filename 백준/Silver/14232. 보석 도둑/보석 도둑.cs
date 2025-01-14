// BOJ_14232


using System.Text;

StringBuilder sb = new StringBuilder();
long k = long.Parse(Console.ReadLine());

long temp = k;
int count = 0;
for (long i = 2; i * i <= k; i++)
{
    while (temp % i == 0)
    {
        count++;
        sb.Append(i + " ");
        temp /= i;
    }
}

if(temp != 1)
{
    count++;
    sb.Append(temp + " ");
}

Console.WriteLine(count);
Console.WriteLine(sb);