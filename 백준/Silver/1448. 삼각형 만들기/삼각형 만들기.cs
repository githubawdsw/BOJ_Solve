// BOJ_1448


int n = int.Parse(Console.ReadLine());
List<int> line = new List<int>();
for (int i = 0; i < n; i++)
    line.Add(int.Parse(Console.ReadLine()));
line.Sort();

int ans = -1;
for (int i = n-1; i >= 2; i--)
{
    if (line[i] < line[i - 1] + line[i - 2])
    {
        ans = (line[i] + line[i - 1] + line[i - 2]);
        break;
    }
}
Console.WriteLine(ans);