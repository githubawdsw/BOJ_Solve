// BOJ_2108


using System.Text;

int n = int.Parse(Console.ReadLine());
List<int> list = new List<int>();
int[] counting = new int[8005];

double sum = 0;
for (int i = 0; i < n; i++)
{
    int input = int.Parse(Console.ReadLine());
    list.Add(input);
    sum += input;
    counting[input + 4000]++;
}
list.Sort();
int max = counting.Max();
int count = 0;
int idx = 0;
for (int i = 0; i < counting.Length; i++)
{
    if (counting[i] == max)
    {
        count++;
        idx = i - 4000;
    }
    if (count == 2)
        break;
}
StringBuilder sb = new StringBuilder();
sb.AppendLine(Convert.ToInt32( Math.Round(sum / n )).ToString());
sb.AppendLine(list[n / 2].ToString());
sb.AppendLine(idx.ToString());
sb.AppendLine((list[n-1] -  list[0]).ToString());

Console.WriteLine(  sb);
