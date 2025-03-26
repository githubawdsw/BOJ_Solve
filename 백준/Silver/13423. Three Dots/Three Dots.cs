// BOJ_13423


using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int n = int.Parse(Console.ReadLine());

    int[] inputDotPos = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    Array.Sort(inputDotPos);

    int sum = 0;
    HashSet<int> hs = new HashSet<int>();
    for (int i = 0; i < n; i++)
    {
        hs.Add(inputDotPos[i]);
    }

    for (int i = 0; i < n - 2; i++)
    {
        for (int j = i + 1; j < n - 1; j++)
        {
            if (hs.Contains((2 * inputDotPos[j] - inputDotPos[i])))
                sum++;
        }
    }

    sb.AppendLine(sum.ToString());
}


Console.WriteLine(sb);
