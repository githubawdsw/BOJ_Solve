// BOJ_4307


using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());

while (t-- > 0)
{
    int[] inputln = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int l = inputln[0];
    int n = inputln[1];
    int maxTime = 0;
    int minTime = 0;
    for (int i = 0; i < n; i++)
    {
        int pos = int.Parse(Console.ReadLine());
        int shortTime = Math.Min(pos, l - pos);
        int longTime = Math.Max(pos, l - pos);

        maxTime = Math.Max(maxTime, longTime);
        minTime = Math.Max(minTime, shortTime);
    }
    sb.AppendLine($"{minTime} {maxTime}");
}

Console.WriteLine(sb);