// BOJ_6986


int[] inputnk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnk[0];
int k = inputnk[1];

List<double> list = new List<double>();
for (int i = 0; i < n; i++)
{
    list.Add(double.Parse(Console.ReadLine()));
}

list.Sort();

double sum1 = 0;
double ans1 = 0;
for (int i = k; i < list.Count - k; i++)
{
    sum1 += list[i];
}

ans1 = sum1 / (n - k - k);

double sum2 = 0;
double ans2 = 0;
for (int i = 0; i < k; i++)
{
    list[i] = list[k];
    list[list.Count - 1 - i] = list[list.Count - 1 - k];
}

for (int i = 0; i < list.Count; i++)
{
    sum2 += list[i];
}

ans2 = sum2 / n;

Console.WriteLine((ans1 + 0.00000001).ToString("F2"));
Console.WriteLine((ans2 + 0.00000001).ToString("0.00"));