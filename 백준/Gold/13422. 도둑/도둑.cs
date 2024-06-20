// BOJ_13422


using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int[] inputnmk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int n = inputnmk[0];
    int m = inputnmk[1];
    int k = inputnmk[2];

    int[] inputMoney = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    List<int> list = new List<int>();
    for (int i = 0; i < n; i++)
    {
        list.Add(inputMoney[i]);
    }
    list.AddRange(list);

    int sum = 0;
    for (int i = 0; i < m; i++)
    {
        sum += list[i];
    }

    int count = 0;
    if (sum < k)
        count++;

    int left = 0;
    int right = m;
    while (left < n - 1)
    {
        sum += list[right] - list[left];
        if (sum < k)
            count++;

        right++;
        left++;
    }

    if (n == m && count > 0)
        sb.AppendLine("1");
    else
        sb.AppendLine(count.ToString());
}

Console.WriteLine(sb);