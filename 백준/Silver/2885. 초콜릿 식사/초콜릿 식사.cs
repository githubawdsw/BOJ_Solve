// BOJ_2885


using System.Text;

StringBuilder sb = new StringBuilder();
int k = int.Parse(Console.ReadLine());

int start = 0;
for (int i = 0; i <= 20; i++)
{
    start = (int)Math.Pow(2, i);
    if (start >= k)
        break;
}

if(k == start)
{
    Console.WriteLine($"{start} 0");
    return;
}

sb.Append($"{start} ");
int sang = start / 2;
int remain = sang;
int count = 1;
while (sang < k)
{
    count++;
    remain /= 2;
    if (sang + remain <= k)
        sang += remain;
}
sb.Append($"{count}");

Console.WriteLine(sb);