// BOJ_13411


using System.Text;

StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());
Dictionary<int, double> dict = new Dictionary<int, double>();
for (int i = 1; i <= n; i++)
{
    int[] inputxyv = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int x = inputxyv[0];
    int y = inputxyv[1];
    int v = inputxyv[2];
    double val = Math.Sqrt(x * x + y * y) / v;
    dict.Add(i, val);
}

dict = dict.OrderBy(x=>x.Value).ToDictionary(x => x.Key, x => x.Value);
foreach (var one in dict)
    sb.AppendLine(one.Key.ToString());

Console.WriteLine(sb);
