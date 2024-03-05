// BOJ_2166


int n = int.Parse(Console.ReadLine());
List<(double, double)> list = new List<(double, double)>();

for (int i = 0; i < n; i++)
{
    int[] inputab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    list.Add((inputab[0], inputab[1]));
}

list.Add(list[0]);
double sum1 = 0;
double sum2 = 0;
for (int i = 1; i < list.Count; i++)
{
    (double, double) a = list[i - 1];
    (double, double) b = list[i];

    sum1 += a.Item1 * b.Item2;
    sum2 += a.Item2 * b.Item1;
}

double ans = Math.Abs(sum1 - sum2) / 2;
Console.WriteLine(ans.ToString("0.0"));
