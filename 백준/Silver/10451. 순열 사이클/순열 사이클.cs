// BOJ_10451

using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int n = int.Parse(Console.ReadLine());
    int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    bool[] used = new bool[1005];
    int ans = 0;
    for (int i = 1; i <= n; i++)
    {
        if (used[i - 1])
            continue;

        ans++;
        int idx = i - 1;
        int value = inputArr[i - 1];
        used[i - 1] = true;
        while (!used[value - 1])
        {
            used[value - 1] = true;
            idx = value - 1;
            value = inputArr[idx];
        }
    }
    sb.AppendLine(ans.ToString());
}

Console.WriteLine(sb);


