// BOJ_1484


using System.Text;

StringBuilder sb= new StringBuilder();
int g = int.Parse(Console.ReadLine());

long start = 1;
long end = 2;
int count = 0;
while (end < 100000)
{
    long val = (end * end) - (start * start);
    if (val == g)
    {
        sb.AppendLine(end.ToString());
        count++;
    }
    if (val >= g)
        start++;
    else
        end++;
}

if(count == 0)
    Console.WriteLine(-1);
else
    Console.WriteLine(sb);