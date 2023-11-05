// BOJ_3649



using System.Text;

StringBuilder sb = new StringBuilder();
while (true)
{
    string input = Console.ReadLine();
    if (input == null || input == "")
        break;
    int x = 10000000 * int.Parse(input);
    int n = int.Parse(Console.ReadLine());

    List<int> list = new List<int>();
    for (int i = 0; i < n; i++)
        list.Add(int.Parse(Console.ReadLine()));
    list.Sort();

    int start = 0;
    int end = list.Count - 1;
    int ans1 = 0;
    int ans2 = 0;
    bool check = false;
    while (start < end)
    {
        if (list[start] + list[end] < x)
            start++;
        else if(list[start] + list[end] > x)
            end--;
        else
        {
            if(Math.Abs(list[end] - list[start]) >= ans2 - ans1)
            {
                ans1 = list[start];
                ans2 = list[end];
            }
            check = true;
            end--;
        }
    }
    if (!check)
        sb.AppendLine("danger");
    else
        sb.AppendLine($"yes {ans1} {ans2}");
}
Console.WriteLine(sb);
