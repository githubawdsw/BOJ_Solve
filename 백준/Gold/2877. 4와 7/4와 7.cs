// BOJ_2877


using System.Text;

StringBuilder sb = new StringBuilder();
int k = int.Parse(Console.ReadLine());

int count = 0;
int min = 1;
int max = 0;
for (int i = 1; i < 30; i++)
{
    if (max < k)
    {
        max += (int)Math.Pow(2, i);
        count = i;
    }
    else
        break;
}
min = Math.Max(max / 2, min);

int value = 0;
for (int i = 0; i < count; i++)
{
    value = (max + min) / 2;
    if (value < k)
    {
        sb.Append('7');
        min = value;
    }
    else
    {
        sb.Append('4');
        max = value;
    }

}

Console.WriteLine(sb);