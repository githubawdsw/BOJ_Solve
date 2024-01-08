// BOJ_2981


using System.Text;

StringBuilder sb = new StringBuilder();

int n = int.Parse(Console.ReadLine());
List<int> list = new List<int>();
List<int> ans = new List<int>();
for (int i = 0; i < n; i++)
    list.Add(int.Parse(Console.ReadLine()));
list.Sort();

int maxGCD = list[1] - list[0];
for (int i = 2; i < n; i++)
    maxGCD = GCD(maxGCD, list[i] - list[i - 1]);

for (int i = 1; i * i <= maxGCD; i++)
{
    if (maxGCD % i == 0)
    {
        if (i != 1)
            ans.Add(i);
        if (i != maxGCD / i)
            ans.Add(maxGCD / i);
    }
}

ans.Sort();
for (int i = 0; i < ans.Count; i++)
    sb.Append($"{ans[i]} ");
Console.WriteLine(sb);


int GCD(int x, int y)
{
    if (y == 0)
        return x;
    return GCD(y, x % y);
}