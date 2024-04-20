// BOJ_1802


using System.Text;

StringBuilder sb = new StringBuilder(); 
int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    string inputCurve = Console.ReadLine();
    int length = inputCurve.Length;

    if (!Solve(0, length, 1, inputCurve))
        sb.AppendLine("NO");
    else
        sb.AppendLine("YES");
}

Console.WriteLine(sb);

bool Solve(int first, int last, int idx, string str)
{
    if (last - first == 1)
        return true;
    int center = (first + last) / 2;
    while (center + idx < last)
    {
        if (str[center + idx] == str[center - idx])
        {
            return false;
        }
        idx++;
    }
    if (!Solve(first, center, 1, str))
        return false;

    if (!Solve(center + 1, last, 1, str))
        return false;
    return true;
}