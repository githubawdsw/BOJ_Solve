// BOJ_9017


using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int n = int.Parse(Console.ReadLine());
    int[] inputRanking = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    int[] countArr = new int[205];
    Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
    int rank = 0;

    for (int i = 0; i < n; i++)
    {
        countArr[inputRanking[i]]++;
    }
    for (int i = 0; i < n; i++)
    {
        if (countArr[inputRanking[i]] < 6)
            continue;

        if (!dict.ContainsKey(inputRanking[i]))
            dict.Add(inputRanking[i], new List<int>());
        dict[inputRanking[i]].Add(rank++);
    }

    int max = int.MaxValue;
    int ans = 0;
    foreach (var one in dict)
    {
        if (dict[one.Key].Count < 6)
        {
            dict.Remove(one.Key);
            continue;
        }

        int sum = 0;
        for (int i = 0; i < 4; i++)
        {
            sum += dict[one.Key][i];
        }

        if(sum < max)
        {
            ans = one.Key;
            max = sum;
        }
        else if(sum == max)
        {
            if (dict[ans][4] > dict[one.Key][4])
                ans = one.Key;
        }
    }

    sb.AppendLine(ans.ToString());
}

Console.WriteLine(sb);
