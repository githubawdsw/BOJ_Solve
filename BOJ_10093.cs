// BOJ_10093

using System.Text;

StringBuilder sb = new StringBuilder();
string[] inputab = Console.ReadLine().Split(' ');
long a = Math.Min( long.Parse(inputab[0]) , long.Parse(inputab[1]));
long b = Math.Max(long.Parse(inputab[0]), long.Parse(inputab[1]));
List<long> list = new List<long>();
for (long i = a + 1; i < b; i++)
    list.Add(i);

sb.AppendLine(list.Count.ToString());
for (int i = 0; i < list.Count; i++)
    sb.Append($"{list[i]} ");
Console.WriteLine(sb);
